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
    public sealed partial class ClaimTileState
    {
        [DataMember(Name = "entity_id")]
        public ulong EntityId;
        [DataMember(Name = "claim_id")]
        public ulong ClaimId;

        public ClaimTileState(
            ulong EntityId,
            ulong ClaimId
        )
        {
            this.EntityId = EntityId;
            this.ClaimId = ClaimId;
        }

        public ClaimTileState()
        {
        }
    }
}
