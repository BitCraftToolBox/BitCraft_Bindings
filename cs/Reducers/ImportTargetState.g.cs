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
        public delegate void ImportTargetStateHandler(ReducerEventContext ctx, System.Collections.Generic.List<TargetState> records);
        public event ImportTargetStateHandler? OnImportTargetState;

        public void ImportTargetState(System.Collections.Generic.List<TargetState> records)
        {
            conn.InternalCallReducer(new Reducer.ImportTargetState(records), this.SetCallReducerFlags.ImportTargetStateFlags);
        }

        public bool InvokeImportTargetState(ReducerEventContext ctx, Reducer.ImportTargetState args)
        {
            if (OnImportTargetState == null)
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
            OnImportTargetState(
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
        public sealed partial class ImportTargetState : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<TargetState> Records;

            public ImportTargetState(System.Collections.Generic.List<TargetState> Records)
            {
                this.Records = Records;
            }

            public ImportTargetState()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "import_target_state";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ImportTargetStateFlags;
        public void ImportTargetState(CallReducerFlags flags) => ImportTargetStateFlags = flags;
    }
}
