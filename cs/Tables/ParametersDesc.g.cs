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
        public sealed class ParametersDescHandle : RemoteTableHandle<EventContext, ParametersDesc>
        {
            protected override string RemoteTableName => "parameters_desc";

            public sealed class VersionUniqueIndex : UniqueIndexBase<int>
            {
                protected override int GetKey(ParametersDesc row) => row.Version;

                public VersionUniqueIndex(ParametersDescHandle table) : base(table) { }
            }

            public readonly VersionUniqueIndex Version;

            internal ParametersDescHandle(DbConnection conn) : base(conn)
            {
                Version = new(this);
            }

            protected override object GetPrimaryKey(ParametersDesc row) => row.Version;
        }

        public readonly ParametersDescHandle ParametersDesc;
    }
}
