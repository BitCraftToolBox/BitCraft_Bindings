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
        public sealed class BuildingPortalDescHandle : RemoteTableHandle<EventContext, BuildingPortalDesc>
        {
            protected override string RemoteTableName => "building_portal_desc";

            public sealed class BuildingIdIndex : BTreeIndexBase<int>
            {
                protected override int GetKey(BuildingPortalDesc row) => row.BuildingId;

                public BuildingIdIndex(BuildingPortalDescHandle table) : base(table) { }
            }

            public readonly BuildingIdIndex BuildingId;

            public sealed class IdUniqueIndex : UniqueIndexBase<int>
            {
                protected override int GetKey(BuildingPortalDesc row) => row.Id;

                public IdUniqueIndex(BuildingPortalDescHandle table) : base(table) { }
            }

            public readonly IdUniqueIndex Id;

            internal BuildingPortalDescHandle(DbConnection conn) : base(conn)
            {
                BuildingId = new(this);
                Id = new(this);
            }

            protected override object GetPrimaryKey(BuildingPortalDesc row) => row.Id;
        }

        public readonly BuildingPortalDescHandle BuildingPortalDesc;
    }
}
