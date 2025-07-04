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
        public sealed class BuffTypeDescHandle : RemoteTableHandle<EventContext, BuffTypeDesc>
        {
            protected override string RemoteTableName => "buff_type_desc";

            public sealed class CategoryIndex : BTreeIndexBase<int>
            {
                protected override int GetKey(BuffTypeDesc row) => row.Category;

                public CategoryIndex(BuffTypeDescHandle table) : base(table) { }
            }

            public readonly CategoryIndex Category;

            public sealed class IdUniqueIndex : UniqueIndexBase<int>
            {
                protected override int GetKey(BuffTypeDesc row) => row.Id;

                public IdUniqueIndex(BuffTypeDescHandle table) : base(table) { }
            }

            public readonly IdUniqueIndex Id;

            internal BuffTypeDescHandle(DbConnection conn) : base(conn)
            {
                Category = new(this);
                Id = new(this);
            }

            protected override object GetPrimaryKey(BuffTypeDesc row) => row.Id;
        }

        public readonly BuffTypeDescHandle BuffTypeDesc;
    }
}
