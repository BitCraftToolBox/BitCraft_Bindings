// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

// This was generated using spacetimedb cli version 1.2.0 (commit dev).

#nullable enable

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
    [SpacetimeDB.Type]
    [DataContract]
    public sealed partial class WorldGenMountain
    {
        [DataMember(Name = "center")]
        public WorldGenVector2 Center;
        [DataMember(Name = "radius")]
        public float Radius;
        [DataMember(Name = "height")]
        public int Height;
        [DataMember(Name = "peak_offset")]
        public WorldGenVector2 PeakOffset;
        [DataMember(Name = "shape")]
        public WorldGenAnimationCurve Shape;

        public WorldGenMountain(
            WorldGenVector2 Center,
            float Radius,
            int Height,
            WorldGenVector2 PeakOffset,
            WorldGenAnimationCurve Shape
        )
        {
            this.Center = Center;
            this.Radius = Radius;
            this.Height = Height;
            this.PeakOffset = PeakOffset;
            this.Shape = Shape;
        }

        public WorldGenMountain()
        {
            this.Center = new();
            this.PeakOffset = new();
            this.Shape = new();
        }
    }
}
