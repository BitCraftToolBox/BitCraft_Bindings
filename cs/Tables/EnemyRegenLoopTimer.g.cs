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
        public sealed class EnemyRegenLoopTimerHandle : RemoteTableHandle<EventContext, EnemyRegenLoopTimer>
        {
            protected override string RemoteTableName => "enemy_regen_loop_timer";

            public sealed class ScheduledIdUniqueIndex : UniqueIndexBase<ulong>
            {
                protected override ulong GetKey(EnemyRegenLoopTimer row) => row.ScheduledId;

                public ScheduledIdUniqueIndex(EnemyRegenLoopTimerHandle table) : base(table) { }
            }

            public readonly ScheduledIdUniqueIndex ScheduledId;

            internal EnemyRegenLoopTimerHandle(DbConnection conn) : base(conn)
            {
                ScheduledId = new(this);
            }

            protected override object GetPrimaryKey(EnemyRegenLoopTimer row) => row.ScheduledId;
        }

        public readonly EnemyRegenLoopTimerHandle EnemyRegenLoopTimer;
    }
}
