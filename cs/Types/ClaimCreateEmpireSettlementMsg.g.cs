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
    public sealed partial class ClaimCreateEmpireSettlementMsg
    {
        [DataMember(Name = "claim_entity_id")]
        public ulong ClaimEntityId;
        [DataMember(Name = "building_entity_id")]
        public ulong BuildingEntityId;
        [DataMember(Name = "location")]
        public OffsetCoordinatesSmallMessage Location;

        public ClaimCreateEmpireSettlementMsg(
            ulong ClaimEntityId,
            ulong BuildingEntityId,
            OffsetCoordinatesSmallMessage Location
        )
        {
            this.ClaimEntityId = ClaimEntityId;
            this.BuildingEntityId = BuildingEntityId;
            this.Location = Location;
        }

        public ClaimCreateEmpireSettlementMsg()
        {
            this.Location = new();
        }
    }
}
