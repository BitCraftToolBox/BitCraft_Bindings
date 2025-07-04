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
        public delegate void ImportLocationStateHandler(ReducerEventContext ctx, System.Collections.Generic.List<LocationState> records);
        public event ImportLocationStateHandler? OnImportLocationState;

        public void ImportLocationState(System.Collections.Generic.List<LocationState> records)
        {
            conn.InternalCallReducer(new Reducer.ImportLocationState(records), this.SetCallReducerFlags.ImportLocationStateFlags);
        }

        public bool InvokeImportLocationState(ReducerEventContext ctx, Reducer.ImportLocationState args)
        {
            if (OnImportLocationState == null)
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
            OnImportLocationState(
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
        public sealed partial class ImportLocationState : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<LocationState> Records;

            public ImportLocationState(System.Collections.Generic.List<LocationState> Records)
            {
                this.Records = Records;
            }

            public ImportLocationState()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "import_location_state";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ImportLocationStateFlags;
        public void ImportLocationState(CallReducerFlags flags) => ImportLocationStateFlags = flags;
    }
}
