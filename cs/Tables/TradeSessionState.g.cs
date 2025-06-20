// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

// This was generated using spacetimedb cli version 1.2.0 (commit dev).

#nullable enable

using System;
using SpacetimeDB.BSATN;
using SpacetimeDB.ClientApi;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
    public sealed partial class RemoteTables
    {
        public sealed class TradeSessionStateHandle : RemoteTableHandle<EventContext, TradeSessionState>
        {
            protected override string RemoteTableName => "trade_session_state";

            public sealed class AcceptorEntityIdIndex : BTreeIndexBase<ulong>
            {
                protected override ulong GetKey(TradeSessionState row) => row.AcceptorEntityId;

                public AcceptorEntityIdIndex(TradeSessionStateHandle table) : base(table) { }
            }

            public readonly AcceptorEntityIdIndex AcceptorEntityId;

            public sealed class EntityIdUniqueIndex : UniqueIndexBase<ulong>
            {
                protected override ulong GetKey(TradeSessionState row) => row.EntityId;

                public EntityIdUniqueIndex(TradeSessionStateHandle table) : base(table) { }
            }

            public readonly EntityIdUniqueIndex EntityId;

            public sealed class InitiatorEntityIdIndex : BTreeIndexBase<ulong>
            {
                protected override ulong GetKey(TradeSessionState row) => row.InitiatorEntityId;

                public InitiatorEntityIdIndex(TradeSessionStateHandle table) : base(table) { }
            }

            public readonly InitiatorEntityIdIndex InitiatorEntityId;

            internal TradeSessionStateHandle(DbConnection conn) : base(conn)
            {
                AcceptorEntityId = new(this);
                EntityId = new(this);
                InitiatorEntityId = new(this);
            }

            protected override object GetPrimaryKey(TradeSessionState row) => row.EntityId;
        }

        public readonly TradeSessionStateHandle TradeSessionState;
    }
}
