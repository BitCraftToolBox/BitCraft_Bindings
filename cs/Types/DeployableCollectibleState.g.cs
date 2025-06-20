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
    public sealed partial class DeployableCollectibleState
    {
        [DataMember(Name = "deployable_entity_id")]
        public ulong DeployableEntityId;
        [DataMember(Name = "owner_entity_id")]
        public ulong OwnerEntityId;
        [DataMember(Name = "collectible_id")]
        public int CollectibleId;
        [DataMember(Name = "deployable_desc_id")]
        public int DeployableDescId;
        [DataMember(Name = "location")]
        public OffsetCoordinatesSmallMessage? Location;

        public DeployableCollectibleState(
            ulong DeployableEntityId,
            ulong OwnerEntityId,
            int CollectibleId,
            int DeployableDescId,
            OffsetCoordinatesSmallMessage? Location
        )
        {
            this.DeployableEntityId = DeployableEntityId;
            this.OwnerEntityId = OwnerEntityId;
            this.CollectibleId = CollectibleId;
            this.DeployableDescId = DeployableDescId;
            this.Location = Location;
        }

        public DeployableCollectibleState()
        {
        }
    }
}
