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
        public sealed class PlayerVoteStateHandle : RemoteTableHandle<EventContext, PlayerVoteState>
        {
            protected override string RemoteTableName => "player_vote_state";

            public sealed class EntityIdUniqueIndex : UniqueIndexBase<ulong>
            {
                protected override ulong GetKey(PlayerVoteState row) => row.EntityId;

                public EntityIdUniqueIndex(PlayerVoteStateHandle table) : base(table) { }
            }

            public readonly EntityIdUniqueIndex EntityId;

            internal PlayerVoteStateHandle(DbConnection conn) : base(conn)
            {
                EntityId = new(this);
            }

            protected override object GetPrimaryKey(PlayerVoteState row) => row.EntityId;
        }

        public readonly PlayerVoteStateHandle PlayerVoteState;
    }
}
