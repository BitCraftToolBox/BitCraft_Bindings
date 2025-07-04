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
    public sealed partial class EmpireSiegeAddSuppliesMsg
    {
        [DataMember(Name = "siege_entity_id")]
        public ulong SiegeEntityId;
        [DataMember(Name = "player_entity_id")]
        public ulong PlayerEntityId;
        [DataMember(Name = "supplies")]
        public int Supplies;
        [DataMember(Name = "supply_cargo_id")]
        public int SupplyCargoId;

        public EmpireSiegeAddSuppliesMsg(
            ulong SiegeEntityId,
            ulong PlayerEntityId,
            int Supplies,
            int SupplyCargoId
        )
        {
            this.SiegeEntityId = SiegeEntityId;
            this.PlayerEntityId = PlayerEntityId;
            this.Supplies = Supplies;
            this.SupplyCargoId = SupplyCargoId;
        }

        public EmpireSiegeAddSuppliesMsg()
        {
        }
    }
}
