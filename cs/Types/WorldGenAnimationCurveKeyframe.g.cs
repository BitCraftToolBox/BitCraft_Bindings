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
    public sealed partial class WorldGenAnimationCurveKeyframe
    {
        [DataMember(Name = "time")]
        public float Time;
        [DataMember(Name = "value")]
        public float Value;
        [DataMember(Name = "in_tangent")]
        public float InTangent;
        [DataMember(Name = "out_tangent")]
        public float OutTangent;

        public WorldGenAnimationCurveKeyframe(
            float Time,
            float Value,
            float InTangent,
            float OutTangent
        )
        {
            this.Time = Time;
            this.Value = Value;
            this.InTangent = InTangent;
            this.OutTangent = OutTangent;
        }

        public WorldGenAnimationCurveKeyframe()
        {
        }
    }
}
