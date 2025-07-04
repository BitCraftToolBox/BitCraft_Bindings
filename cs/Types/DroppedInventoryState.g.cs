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
    public sealed partial class DroppedInventoryState
    {
        [DataMember(Name = "entity_id")]
        public ulong EntityId;
        [DataMember(Name = "owner_entity_id")]
        public ulong OwnerEntityId;
        [DataMember(Name = "active_timer_id")]
        public ulong ActiveTimerId;

        public DroppedInventoryState(
            ulong EntityId,
            ulong OwnerEntityId,
            ulong ActiveTimerId
        )
        {
            this.EntityId = EntityId;
            this.OwnerEntityId = OwnerEntityId;
            this.ActiveTimerId = ActiveTimerId;
        }

        public DroppedInventoryState()
        {
        }
    }
}
