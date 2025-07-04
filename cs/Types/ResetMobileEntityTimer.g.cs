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
    public sealed partial class ResetMobileEntityTimer
    {
        [DataMember(Name = "scheduled_id")]
        public ulong ScheduledId;
        [DataMember(Name = "scheduled_at")]
        public SpacetimeDB.ScheduleAt ScheduledAt;
        [DataMember(Name = "owner_entity_id")]
        public ulong OwnerEntityId;
        [DataMember(Name = "position")]
        public OffsetCoordinatesFloat? Position;
        [DataMember(Name = "strike_counter_to_update")]
        public MoveValidationStrikeCounterState? StrikeCounterToUpdate;

        public ResetMobileEntityTimer(
            ulong ScheduledId,
            SpacetimeDB.ScheduleAt ScheduledAt,
            ulong OwnerEntityId,
            OffsetCoordinatesFloat? Position,
            MoveValidationStrikeCounterState? StrikeCounterToUpdate
        )
        {
            this.ScheduledId = ScheduledId;
            this.ScheduledAt = ScheduledAt;
            this.OwnerEntityId = OwnerEntityId;
            this.Position = Position;
            this.StrikeCounterToUpdate = StrikeCounterToUpdate;
        }

        public ResetMobileEntityTimer()
        {
            this.ScheduledAt = null!;
        }
    }
}
