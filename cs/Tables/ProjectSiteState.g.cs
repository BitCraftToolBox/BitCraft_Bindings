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
        public sealed class ProjectSiteStateHandle : RemoteTableHandle<EventContext, ProjectSiteState>
        {
            protected override string RemoteTableName => "project_site_state";

            public sealed class EntityIdUniqueIndex : UniqueIndexBase<ulong>
            {
                protected override ulong GetKey(ProjectSiteState row) => row.EntityId;

                public EntityIdUniqueIndex(ProjectSiteStateHandle table) : base(table) { }
            }

            public readonly EntityIdUniqueIndex EntityId;

            internal ProjectSiteStateHandle(DbConnection conn) : base(conn)
            {
                EntityId = new(this);
            }

            protected override object GetPrimaryKey(ProjectSiteState row) => row.EntityId;
        }

        public readonly ProjectSiteStateHandle ProjectSiteState;
    }
}
