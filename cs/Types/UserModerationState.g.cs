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
    public sealed partial class UserModerationState
    {
        [DataMember(Name = "entity_id")]
        public ulong EntityId;
        [DataMember(Name = "target_entity_id")]
        public ulong TargetEntityId;
        [DataMember(Name = "created_by_entity_id")]
        public ulong CreatedByEntityId;
        [DataMember(Name = "user_moderation_policy")]
        public UserModerationPolicy UserModerationPolicy;
        [DataMember(Name = "created_time")]
        public SpacetimeDB.Timestamp CreatedTime;
        [DataMember(Name = "expiration_time")]
        public SpacetimeDB.Timestamp ExpirationTime;
        [DataMember(Name = "duration_ms")]
        public ulong DurationMs;

        public UserModerationState(
            ulong EntityId,
            ulong TargetEntityId,
            ulong CreatedByEntityId,
            UserModerationPolicy UserModerationPolicy,
            SpacetimeDB.Timestamp CreatedTime,
            SpacetimeDB.Timestamp ExpirationTime,
            ulong DurationMs
        )
        {
            this.EntityId = EntityId;
            this.TargetEntityId = TargetEntityId;
            this.CreatedByEntityId = CreatedByEntityId;
            this.UserModerationPolicy = UserModerationPolicy;
            this.CreatedTime = CreatedTime;
            this.ExpirationTime = ExpirationTime;
            this.DurationMs = DurationMs;
        }

        public UserModerationState()
        {
        }
    }
}
