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
        public sealed class UserPreviousRegionStateHandle : RemoteTableHandle<EventContext, UserPreviousRegionState>
        {
            protected override string RemoteTableName => "user_previous_region_state";

            public sealed class IdentityUniqueIndex : UniqueIndexBase<SpacetimeDB.Identity>
            {
                protected override SpacetimeDB.Identity GetKey(UserPreviousRegionState row) => row.Identity;

                public IdentityUniqueIndex(UserPreviousRegionStateHandle table) : base(table) { }
            }

            public readonly IdentityUniqueIndex Identity;

            internal UserPreviousRegionStateHandle(DbConnection conn) : base(conn)
            {
                Identity = new(this);
            }

            protected override object GetPrimaryKey(UserPreviousRegionState row) => row.Identity;
        }

        public readonly UserPreviousRegionStateHandle UserPreviousRegionState;
    }
}
