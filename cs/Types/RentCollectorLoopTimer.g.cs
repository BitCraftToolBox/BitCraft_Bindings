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
    public sealed partial class RentCollectorLoopTimer
    {
        [DataMember(Name = "scheduled_id")]
        public ulong ScheduledId;
        [DataMember(Name = "scheduled_at")]
        public SpacetimeDB.ScheduleAt ScheduledAt;
        [DataMember(Name = "first_tick")]
        public bool FirstTick;

        public RentCollectorLoopTimer(
            ulong ScheduledId,
            SpacetimeDB.ScheduleAt ScheduledAt,
            bool FirstTick
        )
        {
            this.ScheduledId = ScheduledId;
            this.ScheduledAt = ScheduledAt;
            this.FirstTick = FirstTick;
        }

        public RentCollectorLoopTimer()
        {
            this.ScheduledAt = null!;
        }
    }
}
