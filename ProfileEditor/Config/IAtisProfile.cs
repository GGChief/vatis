﻿namespace ProfileEditor.Config
{
    public interface IAtisProfile
    {
        string Name { get; set; }
        string AirportConditions { get; set; }
        string Notams { get; set; }
        string ArbitraryText { get; set; }
        string Template { get; set; }
    }
}