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
        public sealed class ToolbarStateHandle : RemoteTableHandle<EventContext, ToolbarState>
        {
            protected override string RemoteTableName => "toolbar_state";

            public sealed class EntityIdUniqueIndex : UniqueIndexBase<ulong>
            {
                protected override ulong GetKey(ToolbarState row) => row.EntityId;

                public EntityIdUniqueIndex(ToolbarStateHandle table) : base(table) { }
            }

            public readonly EntityIdUniqueIndex EntityId;

            public sealed class OwnerEntityIdIndex : BTreeIndexBase<ulong>
            {
                protected override ulong GetKey(ToolbarState row) => row.OwnerEntityId;

                public OwnerEntityIdIndex(ToolbarStateHandle table) : base(table) { }
            }

            public readonly OwnerEntityIdIndex OwnerEntityId;

            internal ToolbarStateHandle(DbConnection conn) : base(conn)
            {
                EntityId = new(this);
                OwnerEntityId = new(this);
            }

            protected override object GetPrimaryKey(ToolbarState row) => row.EntityId;
        }

        public readonly ToolbarStateHandle ToolbarState;
    }
}
