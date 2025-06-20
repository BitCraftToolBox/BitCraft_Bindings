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
    public sealed partial class PlayerMoveRequest
    {
        [DataMember(Name = "timestamp")]
        public ulong Timestamp;
        [DataMember(Name = "destination")]
        public OffsetCoordinatesFloat? Destination;
        [DataMember(Name = "origin")]
        public OffsetCoordinatesFloat? Origin;
        [DataMember(Name = "duration")]
        public float Duration;
        [DataMember(Name = "move_type")]
        public int MoveType;
        [DataMember(Name = "running")]
        public bool Running;

        public PlayerMoveRequest(
            ulong Timestamp,
            OffsetCoordinatesFloat? Destination,
            OffsetCoordinatesFloat? Origin,
            float Duration,
            int MoveType,
            bool Running
        )
        {
            this.Timestamp = Timestamp;
            this.Destination = Destination;
            this.Origin = Origin;
            this.Duration = Duration;
            this.MoveType = MoveType;
            this.Running = Running;
        }

        public PlayerMoveRequest()
        {
        }
    }
}
