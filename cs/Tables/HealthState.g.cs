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
        public sealed class HealthStateHandle : RemoteTableHandle<EventContext, HealthState>
        {
            protected override string RemoteTableName => "health_state";

            public sealed class EntityIdUniqueIndex : UniqueIndexBase<ulong>
            {
                protected override ulong GetKey(HealthState row) => row.EntityId;

                public EntityIdUniqueIndex(HealthStateHandle table) : base(table) { }
            }

            public readonly EntityIdUniqueIndex EntityId;

            internal HealthStateHandle(DbConnection conn) : base(conn)
            {
                EntityId = new(this);
            }

            protected override object GetPrimaryKey(HealthState row) => row.EntityId;
        }

        public readonly HealthStateHandle HealthState;
    }
}
