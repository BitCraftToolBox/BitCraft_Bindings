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
    public sealed partial class DimensionNetworkState
    {
        [DataMember(Name = "entity_id")]
        public ulong EntityId;
        [DataMember(Name = "building_id")]
        public ulong BuildingId;
        [DataMember(Name = "collapse_respawn_timestamp")]
        public ulong CollapseRespawnTimestamp;
        [DataMember(Name = "rent_entity_id")]
        public ulong RentEntityId;
        [DataMember(Name = "claim_entity_id")]
        public ulong ClaimEntityId;
        [DataMember(Name = "entrance_dimension_id")]
        public uint EntranceDimensionId;
        [DataMember(Name = "is_collapsed")]
        public bool IsCollapsed;

        public DimensionNetworkState(
            ulong EntityId,
            ulong BuildingId,
            ulong CollapseRespawnTimestamp,
            ulong RentEntityId,
            ulong ClaimEntityId,
            uint EntranceDimensionId,
            bool IsCollapsed
        )
        {
            this.EntityId = EntityId;
            this.BuildingId = BuildingId;
            this.CollapseRespawnTimestamp = CollapseRespawnTimestamp;
            this.RentEntityId = RentEntityId;
            this.ClaimEntityId = ClaimEntityId;
            this.EntranceDimensionId = EntranceDimensionId;
            this.IsCollapsed = IsCollapsed;
        }

        public DimensionNetworkState()
        {
        }
    }
}
