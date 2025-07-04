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
    public sealed partial class PlayerNotificationEvent
    {
        [DataMember(Name = "scheduled_id")]
        public ulong ScheduledId;
        [DataMember(Name = "scheduled_at")]
        public SpacetimeDB.ScheduleAt ScheduledAt;
        [DataMember(Name = "player_entity_id")]
        public ulong PlayerEntityId;
        [DataMember(Name = "message")]
        public string Message;
        [DataMember(Name = "severity")]
        public NotificationSeverity Severity;

        public PlayerNotificationEvent(
            ulong ScheduledId,
            SpacetimeDB.ScheduleAt ScheduledAt,
            ulong PlayerEntityId,
            string Message,
            NotificationSeverity Severity
        )
        {
            this.ScheduledId = ScheduledId;
            this.ScheduledAt = ScheduledAt;
            this.PlayerEntityId = PlayerEntityId;
            this.Message = Message;
            this.Severity = Severity;
        }

        public PlayerNotificationEvent()
        {
            this.ScheduledAt = null!;
            this.Message = "";
        }
    }
}
