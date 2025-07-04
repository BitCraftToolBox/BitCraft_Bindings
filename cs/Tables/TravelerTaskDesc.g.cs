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
        public sealed class TravelerTaskDescHandle : RemoteTableHandle<EventContext, TravelerTaskDesc>
        {
            protected override string RemoteTableName => "traveler_task_desc";

            public sealed class IdUniqueIndex : UniqueIndexBase<int>
            {
                protected override int GetKey(TravelerTaskDesc row) => row.Id;

                public IdUniqueIndex(TravelerTaskDescHandle table) : base(table) { }
            }

            public readonly IdUniqueIndex Id;

            internal TravelerTaskDescHandle(DbConnection conn) : base(conn)
            {
                Id = new(this);
            }

            protected override object GetPrimaryKey(TravelerTaskDesc row) => row.Id;
        }

        public readonly TravelerTaskDescHandle TravelerTaskDesc;
    }
}
