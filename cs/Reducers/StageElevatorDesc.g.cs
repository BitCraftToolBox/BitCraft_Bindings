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
        public delegate void StageElevatorDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<ElevatorDesc> records);
        public event StageElevatorDescHandler? OnStageElevatorDesc;

        public void StageElevatorDesc(System.Collections.Generic.List<ElevatorDesc> records)
        {
            conn.InternalCallReducer(new Reducer.StageElevatorDesc(records), this.SetCallReducerFlags.StageElevatorDescFlags);
        }

        public bool InvokeStageElevatorDesc(ReducerEventContext ctx, Reducer.StageElevatorDesc args)
        {
            if (OnStageElevatorDesc == null)
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
            OnStageElevatorDesc(
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
        public sealed partial class StageElevatorDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<ElevatorDesc> Records;

            public StageElevatorDesc(System.Collections.Generic.List<ElevatorDesc> Records)
            {
                this.Records = Records;
            }

            public StageElevatorDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "stage_elevator_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags StageElevatorDescFlags;
        public void StageElevatorDesc(CallReducerFlags flags) => StageElevatorDescFlags = flags;
    }
}
