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
    public sealed partial class ReportPlayerMessage
    {
        [DataMember(Name = "player_entity_id")]
        public ulong PlayerEntityId;
        [DataMember(Name = "report_type")]
        public string ReportType;
        [DataMember(Name = "message")]
        public string Message;

        public ReportPlayerMessage(
            ulong PlayerEntityId,
            string ReportType,
            string Message
        )
        {
            this.PlayerEntityId = PlayerEntityId;
            this.ReportType = ReportType;
            this.Message = Message;
        }

        public ReportPlayerMessage()
        {
            this.ReportType = "";
            this.Message = "";
        }
    }
}
