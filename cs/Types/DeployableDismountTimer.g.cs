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
    public sealed partial class DeployableDismountTimer
    {
        [DataMember(Name = "scheduled_id")]
        public ulong ScheduledId;
        [DataMember(Name = "scheduled_at")]
        public SpacetimeDB.ScheduleAt ScheduledAt;
        [DataMember(Name = "deployable_entity_id")]
        public ulong DeployableEntityId;
        [DataMember(Name = "player_entity_id")]
        public ulong PlayerEntityId;
        [DataMember(Name = "coordinates")]
        public OffsetCoordinatesFloat? Coordinates;
        [DataMember(Name = "skip_deployable_icon")]
        public bool SkipDeployableIcon;

        public DeployableDismountTimer(
            ulong ScheduledId,
            SpacetimeDB.ScheduleAt ScheduledAt,
            ulong DeployableEntityId,
            ulong PlayerEntityId,
            OffsetCoordinatesFloat? Coordinates,
            bool SkipDeployableIcon
        )
        {
            this.ScheduledId = ScheduledId;
            this.ScheduledAt = ScheduledAt;
            this.DeployableEntityId = DeployableEntityId;
            this.PlayerEntityId = PlayerEntityId;
            this.Coordinates = Coordinates;
            this.SkipDeployableIcon = SkipDeployableIcon;
        }

        public DeployableDismountTimer()
        {
            this.ScheduledAt = null!;
        }
    }
}
