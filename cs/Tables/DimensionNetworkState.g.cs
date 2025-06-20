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
        public sealed class DimensionNetworkStateHandle : RemoteTableHandle<EventContext, DimensionNetworkState>
        {
            protected override string RemoteTableName => "dimension_network_state";

            public sealed class BuildingIdUniqueIndex : UniqueIndexBase<ulong>
            {
                protected override ulong GetKey(DimensionNetworkState row) => row.BuildingId;

                public BuildingIdUniqueIndex(DimensionNetworkStateHandle table) : base(table) { }
            }

            public readonly BuildingIdUniqueIndex BuildingId;

            public sealed class EntityIdUniqueIndex : UniqueIndexBase<ulong>
            {
                protected override ulong GetKey(DimensionNetworkState row) => row.EntityId;

                public EntityIdUniqueIndex(DimensionNetworkStateHandle table) : base(table) { }
            }

            public readonly EntityIdUniqueIndex EntityId;

            internal DimensionNetworkStateHandle(DbConnection conn) : base(conn)
            {
                BuildingId = new(this);
                EntityId = new(this);
            }

            protected override object GetPrimaryKey(DimensionNetworkState row) => row.EntityId;
        }

        public readonly DimensionNetworkStateHandle DimensionNetworkState;
    }
}
