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
    public sealed partial class PlayerPermissionEditRequest
    {
        [DataMember(Name = "ordained_entity_id")]
        public ulong OrdainedEntityId;
        [DataMember(Name = "allowed_entity_id")]
        public ulong AllowedEntityId;
        [DataMember(Name = "permission")]
        public Permission? Permission;

        public PlayerPermissionEditRequest(
            ulong OrdainedEntityId,
            ulong AllowedEntityId,
            Permission? Permission
        )
        {
            this.OrdainedEntityId = OrdainedEntityId;
            this.AllowedEntityId = AllowedEntityId;
            this.Permission = Permission;
        }

        public PlayerPermissionEditRequest()
        {
        }
    }
}
