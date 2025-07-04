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
        public sealed class GateDescHandle : RemoteTableHandle<EventContext, GateDesc>
        {
            protected override string RemoteTableName => "gate_desc";

            public sealed class BuildingIdUniqueIndex : UniqueIndexBase<int>
            {
                protected override int GetKey(GateDesc row) => row.BuildingId;

                public BuildingIdUniqueIndex(GateDescHandle table) : base(table) { }
            }

            public readonly BuildingIdUniqueIndex BuildingId;

            internal GateDescHandle(DbConnection conn) : base(conn)
            {
                BuildingId = new(this);
            }

            protected override object GetPrimaryKey(GateDesc row) => row.BuildingId;
        }

        public readonly GateDescHandle GateDesc;
    }
}
