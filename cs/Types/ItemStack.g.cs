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
    public sealed partial class ItemStack
    {
        [DataMember(Name = "item_id")]
        public int ItemId;
        [DataMember(Name = "quantity")]
        public int Quantity;
        [DataMember(Name = "item_type")]
        public ItemType ItemType;
        [DataMember(Name = "durability")]
        public int? Durability;

        public ItemStack(
            int ItemId,
            int Quantity,
            ItemType ItemType,
            int? Durability
        )
        {
            this.ItemId = ItemId;
            this.Quantity = Quantity;
            this.ItemType = ItemType;
            this.Durability = Durability;
        }

        public ItemStack()
        {
        }
    }
}
