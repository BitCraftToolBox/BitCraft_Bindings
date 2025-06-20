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
        public sealed class PlayerPrefsStateHandle : RemoteTableHandle<EventContext, PlayerPrefsState>
        {
            protected override string RemoteTableName => "player_prefs_state";

            public sealed class EntityIdUniqueIndex : UniqueIndexBase<ulong>
            {
                protected override ulong GetKey(PlayerPrefsState row) => row.EntityId;

                public EntityIdUniqueIndex(PlayerPrefsStateHandle table) : base(table) { }
            }

            public readonly EntityIdUniqueIndex EntityId;

            internal PlayerPrefsStateHandle(DbConnection conn) : base(conn)
            {
                EntityId = new(this);
            }

            protected override object GetPrimaryKey(PlayerPrefsState row) => row.EntityId;
        }

        public readonly PlayerPrefsStateHandle PlayerPrefsState;
    }
}
