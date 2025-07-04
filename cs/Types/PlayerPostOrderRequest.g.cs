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
    public sealed partial class PlayerPostOrderRequest
    {
        [DataMember(Name = "building_entity_id")]
        public ulong BuildingEntityId;
        [DataMember(Name = "item_id")]
        public int ItemId;
        [DataMember(Name = "item_type")]
        public ItemType ItemType;
        [DataMember(Name = "coins")]
        public int Coins;
        [DataMember(Name = "quantity")]
        public int Quantity;
        [DataMember(Name = "persist_order")]
        public bool PersistOrder;

        public PlayerPostOrderRequest(
            ulong BuildingEntityId,
            int ItemId,
            ItemType ItemType,
            int Coins,
            int Quantity,
            bool PersistOrder
        )
        {
            this.BuildingEntityId = BuildingEntityId;
            this.ItemId = ItemId;
            this.ItemType = ItemType;
            this.Coins = Coins;
            this.Quantity = Quantity;
            this.PersistOrder = PersistOrder;
        }

        public PlayerPostOrderRequest()
        {
        }
    }
}
