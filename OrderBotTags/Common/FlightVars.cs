﻿namespace ExBuddy.OrderBotTags.Common
{
    using System.ComponentModel;

    using Clio.XmlEngine;

    using ff14bot.NeoProfiles;

    public interface IFlightNavigationArgs
    {
        int InverseParabolicMagnitude { get; set; }

        float Smoothing { get; set; }

        float ForcedAltitude { get; set; }

        bool LogWaypoints { get; set; }
    }

    public interface IFlightMovementArgs
    {
        int MountId { get; set; }
        float Radius { get; set; }
        bool ForceLanding { get; set; }
    }

    public interface IFlightVars : IFlightMovementArgs, IFlightNavigationArgs
    {
    }

    public class FlightMovementArgs : IFlightMovementArgs
    {
        public FlightMovementArgs()
        {
            this.Radius = 2.7f;
        }

        public int MountId { get; set; }

        public float Radius { get; set; }

        public bool ForceLanding { get; set; }
    }

    public class FlightNavigationArgs : IFlightNavigationArgs
    {
        public FlightNavigationArgs()
        {
            this.InverseParabolicMagnitude = 10;
            this.Smoothing = 0.1f;
            this.LogWaypoints = true;
        }

        public int InverseParabolicMagnitude { get; set; }

        public float Smoothing { get; set; }

        public float ForcedAltitude { get; set; }

        public bool LogWaypoints { get; set; }
    }

    public abstract class FlightVars : ProfileBehavior, IFlightVars
    {
        [DefaultValue(3.0f)]
        [XmlAttribute("Radius")]
        public float Radius { get; set; }

        [DefaultValue(10)]
        [XmlAttribute("InverseParabolicMagnitude")]
        public int InverseParabolicMagnitude { get; set; }

        [DefaultValue(0.5f)]
        [XmlAttribute("Smoothing")]
        public float Smoothing { get; set; }

        [DefaultValue(0)]
        [XmlAttribute("MountId")]
        public int MountId { get; set; }

        [DefaultValue(0.0f)]
        [XmlAttribute("ForcedAltitude")]
        public float ForcedAltitude { get; set; }

        [XmlAttribute("ForceLanding")]
        public bool ForceLanding { get; set; }

        [XmlAttribute("LogWaypoints")]
        public bool LogWaypoints { get; set; }
    }
}
