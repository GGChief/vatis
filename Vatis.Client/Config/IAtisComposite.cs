﻿using System.Collections.Generic;

namespace Vatsim.Vatis.Client.Config
{
    public interface IAtisComposite
    {
        string Name { get; set; }
        string Identifier { get; set; }
        List<ContractionMeta> Contractions { get; set; }
        List<DefinedText> AirportConditionDefinitions { get; set; }
        List<DefinedText> NotamDefinitions { get; set; }
        List<TransitionLevel> TransitionLevels { get; set; }
        int AtisFrequency { get; set; }
        ObservationTimeMeta ObservationTime { get; set; }
        MagneticVariationMeta MagneticVariation { get; set; }
        AtisVoiceMeta AtisVoice { get; set; }
        string IDSEndpoint { get; set; }
        List<AtisPreset> Presets { get; set; }
        AtisPreset CurrentPreset { get; set; }
        string CurrentAtisLetter { get; set; }
    }
}