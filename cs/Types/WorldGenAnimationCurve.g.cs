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
    public sealed partial class WorldGenAnimationCurve
    {
        [DataMember(Name = "keyframes")]
        public System.Collections.Generic.List<WorldGenAnimationCurveKeyframe> Keyframes;

        public WorldGenAnimationCurve(System.Collections.Generic.List<WorldGenAnimationCurveKeyframe> Keyframes)
        {
            this.Keyframes = Keyframes;
        }

        public WorldGenAnimationCurve()
        {
            this.Keyframes = new();
        }
    }
}
