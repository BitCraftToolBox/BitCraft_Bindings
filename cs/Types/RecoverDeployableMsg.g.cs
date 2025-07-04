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
    public sealed partial class RecoverDeployableMsg
    {
        [DataMember(Name = "player_entity_id")]
        public ulong PlayerEntityId;
        [DataMember(Name = "deployable_entity_id")]
        public ulong DeployableEntityId;
        [DataMember(Name = "deployable_desc_id")]
        public int DeployableDescId;

        public RecoverDeployableMsg(
            ulong PlayerEntityId,
            ulong DeployableEntityId,
            int DeployableDescId
        )
        {
            this.PlayerEntityId = PlayerEntityId;
            this.DeployableEntityId = DeployableEntityId;
            this.DeployableDescId = DeployableDescId;
        }

        public RecoverDeployableMsg()
        {
        }
    }
}
