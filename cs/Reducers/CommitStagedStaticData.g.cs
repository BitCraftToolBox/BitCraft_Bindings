// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

// This was generated using spacetimedb cli version 1.2.0 (commit dev).

#nullable enable

using System;
using SpacetimeDB.ClientApi;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
    public sealed partial class RemoteReducers : RemoteBase
    {
        public delegate void CommitStagedStaticDataHandler(ReducerEventContext ctx);
        public event CommitStagedStaticDataHandler? OnCommitStagedStaticData;

        public void CommitStagedStaticData()
        {
            conn.InternalCallReducer(new Reducer.CommitStagedStaticData(), this.SetCallReducerFlags.CommitStagedStaticDataFlags);
        }

        public bool InvokeCommitStagedStaticData(ReducerEventContext ctx, Reducer.CommitStagedStaticData args)
        {
            if (OnCommitStagedStaticData == null)
            {
                if (InternalOnUnhandledReducerError != null)
                {
                    switch(ctx.Event.Status)
                    {
                        case Status.Failed(var reason): InternalOnUnhandledReducerError(ctx, new Exception(reason)); break;
                        case Status.OutOfEnergy(var _): InternalOnUnhandledReducerError(ctx, new Exception("out of energy")); break;
                    }
                }
                return false;
            }
            OnCommitStagedStaticData(
                ctx
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class CommitStagedStaticData : Reducer, IReducerArgs
        {
            string IReducerArgs.ReducerName => "commit_staged_static_data";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags CommitStagedStaticDataFlags;
        public void CommitStagedStaticData(CallReducerFlags flags) => CommitStagedStaticDataFlags = flags;
    }
}
