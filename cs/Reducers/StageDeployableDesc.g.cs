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
        public delegate void StageDeployableDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<DeployableDesc> records);
        public event StageDeployableDescHandler? OnStageDeployableDesc;

        public void StageDeployableDesc(System.Collections.Generic.List<DeployableDesc> records)
        {
            conn.InternalCallReducer(new Reducer.StageDeployableDesc(records), this.SetCallReducerFlags.StageDeployableDescFlags);
        }

        public bool InvokeStageDeployableDesc(ReducerEventContext ctx, Reducer.StageDeployableDesc args)
        {
            if (OnStageDeployableDesc == null)
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
            OnStageDeployableDesc(
                ctx,
                args.Records
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class StageDeployableDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<DeployableDesc> Records;

            public StageDeployableDesc(System.Collections.Generic.List<DeployableDesc> Records)
            {
                this.Records = Records;
            }

            public StageDeployableDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "stage_deployable_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags StageDeployableDescFlags;
        public void StageDeployableDesc(CallReducerFlags flags) => StageDeployableDescFlags = flags;
    }
}
