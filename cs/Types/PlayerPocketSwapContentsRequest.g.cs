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
    public sealed partial class PlayerPocketSwapContentsRequest
    {
        [DataMember(Name = "from_pocket")]
        public PocketKey FromPocket;
        [DataMember(Name = "to_pocket")]
        public PocketKey ToPocket;
        [DataMember(Name = "quantity")]
        public int Quantity;

        public PlayerPocketSwapContentsRequest(
            PocketKey FromPocket,
            PocketKey ToPocket,
            int Quantity
        )
        {
            this.FromPocket = FromPocket;
            this.ToPocket = ToPocket;
            this.Quantity = Quantity;
        }

        public PlayerPocketSwapContentsRequest()
        {
            this.FromPocket = new();
            this.ToPocket = new();
        }
    }
}
