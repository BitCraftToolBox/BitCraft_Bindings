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
    public sealed partial class PlayerBarterStallOrderAccept
    {
        [DataMember(Name = "trade_order_entity_id")]
        public ulong TradeOrderEntityId;
        [DataMember(Name = "shop_entity_id")]
        public ulong ShopEntityId;

        public PlayerBarterStallOrderAccept(
            ulong TradeOrderEntityId,
            ulong ShopEntityId
        )
        {
            this.TradeOrderEntityId = TradeOrderEntityId;
            this.ShopEntityId = ShopEntityId;
        }

        public PlayerBarterStallOrderAccept()
        {
        }
    }
}
