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
    public sealed partial class GrowthState
    {
        [DataMember(Name = "entity_id")]
        public ulong EntityId;
        [DataMember(Name = "end_timestamp")]
        public SpacetimeDB.Timestamp EndTimestamp;
        [DataMember(Name = "growth_recipe_id")]
        public int GrowthRecipeId;

        public GrowthState(
            ulong EntityId,
            SpacetimeDB.Timestamp EndTimestamp,
            int GrowthRecipeId
        )
        {
            this.EntityId = EntityId;
            this.EndTimestamp = EndTimestamp;
            this.GrowthRecipeId = GrowthRecipeId;
        }

        public GrowthState()
        {
        }
    }
}
