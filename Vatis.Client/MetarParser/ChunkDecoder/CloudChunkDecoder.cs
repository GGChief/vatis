using System.Collections.Generic;
using System.Linq;

namespace MetarDecoder
{
    public sealed class CloudChunkDecoder : MetarChunkDecoder
    {
        public const string CloudsParameterName = "Clouds";

        private const string NoCloudRegexPattern = "(NSC|NCD|CLR|SKC)";
        private const string LayerRegexPattern = "(VV|FEW|SCT|BKN|OVC|///)([0-9]{3}|///)(CB|TCU|///)?";

        public override string GetRegex()
        {
            // vertical visibility VV is handled as a regular cloud layer
            return $"^({NoCloudRegexPattern}|({LayerRegexPattern})( {LayerRegexPattern})?( {LayerRegexPattern})?( {LayerRegexPattern})?( {LayerRegexPattern})?( {LayerRegexPattern})?)( )";
        }

        public override Dictionary<string, object> Parse(string remainingMetar, bool withCavok = true)
        {
            var consumed = Consume(remainingMetar);
            var found = consumed.Value;
            var newRemainingMetar = consumed.Key;
            var result = new Dictionary<string, object>();

            // default case: CAVOK or clear sky, no cloud layer
            var layers = new List<CloudLayer>();

            // handle the case where nothing has been found and metar is not cavok
            if (found.Count <= 1 && !withCavok)
            {
                throw new MetarChunkDecoderException(remainingMetar, newRemainingMetar, MetarChunkDecoderException.Messages.CloudsInformationBadFormat, this);
            }

            if (found.Count > 1)
            {
                // there are clouds, handle cloud layers and visibility
                if (found.Count > 2 && string.IsNullOrEmpty(found[2].Value))
                {
                    for (var i = 3; i <= 23; i += 4)
                    {
                        if (!string.IsNullOrEmpty(found[i].Value))
                        {
                            var layer = new CloudLayer();
                            layer.RawValue = found[i].Value;
                            var layerHeight = Value.ToInt(found[i + 2].Value);
                            int? layerHeightFeet = null;
                            if (layerHeight.HasValue)
                            {
                                layerHeightFeet = layerHeight * 100;
                            }

                            switch (found[i + 1].Value)
                            {
                                case "FEW":
                                    layer.Amount = CloudLayer.CloudAmount.FEW;
                                    break;
                                case "SCT":
                                    layer.Amount = CloudLayer.CloudAmount.SCT;
                                    break;
                                case "BKN":
                                    layer.Amount = CloudLayer.CloudAmount.BKN;
                                    break;
                                case "OVC":
                                    layer.Amount = CloudLayer.CloudAmount.OVC;
                                    break;
                                case "VV":
                                    layer.Amount = CloudLayer.CloudAmount.VV;
                                    break;
                            }

                            if (layerHeightFeet.HasValue)
                            {
                                layer.BaseHeight = new Value(layerHeightFeet.Value, Value.Unit.Feet);
                            }
                            switch (found[i + 3].Value)
                            {
                                case "CB":
                                    layer.Type = CloudLayer.CloudType.CB;
                                    break;
                                case "TCU":
                                    layer.Type = CloudLayer.CloudType.TCU;
                                    break;
                                case "///":
                                    layer.Type = CloudLayer.CloudType.CannotMeasure;
                                    break;
                            }
                            layers.Add(layer);
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(found[1].Value))
                    {
                        var layer = new CloudLayer();
                        layer.RawValue = found[1].Value;
                        layer.Type = CloudLayer.CloudType.NULL;
                        layer.BaseHeight = new Value(0, Value.Unit.Feet);

                        switch (found[1].Value)
                        {
                            case "NCD":
                                layer.Amount = CloudLayer.CloudAmount.NCD;
                                break;
                            case "CLR":
                                layer.Amount = CloudLayer.CloudAmount.CLR;
                                break;
                            case "NCS":
                                layer.Amount = CloudLayer.CloudAmount.NSC;
                                break;
                            case "SKC":
                                layer.Amount = CloudLayer.CloudAmount.SKC;
                                break;
                        }

                        layers.Add(layer);
                    }
                }
            }

            // determine ceiling layer
            var ceiling = (from x in layers.Where(o => o.Amount == CloudLayer.CloudAmount.BKN || o.Amount == CloudLayer.CloudAmount.OVC)
                           let i = new { a = x.Amount, b = x.BaseHeight.ActualValue }
                           orderby i.b
                           select i).FirstOrDefault();

            foreach (var x in layers)
            {
                if (x.Amount == CloudLayer.CloudAmount.BKN || x.Amount == CloudLayer.CloudAmount.OVC)
                {
                    x.IsCeiling = (ceiling.a == x.Amount && ceiling.b == x.BaseHeight.ActualValue) ? true : false;
                }
            }

            result.Add(CloudsParameterName, layers);

            return GetResults(newRemainingMetar, result);
        }
    }
}
