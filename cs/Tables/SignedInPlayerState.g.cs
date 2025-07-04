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
        public sealed class SignedInPlayerStateHandle : RemoteTableHandle<EventContext, SignedInPlayerState>
        {
            protected override string RemoteTableName => "signed_in_player_state";

            public sealed class EntityIdUniqueIndex : UniqueIndexBase<ulong>
            {
                protected override ulong GetKey(SignedInPlayerState row) => row.EntityId;

                public EntityIdUniqueIndex(SignedInPlayerStateHandle table) : base(table) { }
            }

            public readonly EntityIdUniqueIndex EntityId;

            internal SignedInPlayerStateHandle(DbConnection conn) : base(conn)
            {
                EntityId = new(this);
            }

            protected override object GetPrimaryKey(SignedInPlayerState row) => row.EntityId;
        }

        public readonly SignedInPlayerStateHandle SignedInPlayerState;
    }
}
