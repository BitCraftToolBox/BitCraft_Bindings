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
    public sealed partial class ResourceGrowthRecipeDesc
    {
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "resource_id")]
        public int ResourceId;
        [DataMember(Name = "time")]
        public System.Collections.Generic.List<float> Time;
        [DataMember(Name = "grown_resource_id")]
        public int GrownResourceId;

        public ResourceGrowthRecipeDesc(
            int Id,
            int ResourceId,
            System.Collections.Generic.List<float> Time,
            int GrownResourceId
        )
        {
            this.Id = Id;
            this.ResourceId = ResourceId;
            this.Time = Time;
            this.GrownResourceId = GrownResourceId;
        }

        public ResourceGrowthRecipeDesc()
        {
            this.Time = new();
        }
    }
}
