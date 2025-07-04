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
        public sealed class ResourceCountHandle : RemoteTableHandle<EventContext, ResourceCount>
        {
            protected override string RemoteTableName => "resource_count";

            public sealed class ResourceIdUniqueIndex : UniqueIndexBase<int>
            {
                protected override int GetKey(ResourceCount row) => row.ResourceId;

                public ResourceIdUniqueIndex(ResourceCountHandle table) : base(table) { }
            }

            public readonly ResourceIdUniqueIndex ResourceId;

            internal ResourceCountHandle(DbConnection conn) : base(conn)
            {
                ResourceId = new(this);
            }

            protected override object GetPrimaryKey(ResourceCount row) => row.ResourceId;
        }

        public readonly ResourceCountHandle ResourceCount;
    }
}
