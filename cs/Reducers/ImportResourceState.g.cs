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
        public delegate void ImportResourceStateHandler(ReducerEventContext ctx, System.Collections.Generic.List<ResourceState> records);
        public event ImportResourceStateHandler? OnImportResourceState;

        public void ImportResourceState(System.Collections.Generic.List<ResourceState> records)
        {
            conn.InternalCallReducer(new Reducer.ImportResourceState(records), this.SetCallReducerFlags.ImportResourceStateFlags);
        }

        public bool InvokeImportResourceState(ReducerEventContext ctx, Reducer.ImportResourceState args)
        {
            if (OnImportResourceState == null)
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
            OnImportResourceState(
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
        public sealed partial class ImportResourceState : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<ResourceState> Records;

            public ImportResourceState(System.Collections.Generic.List<ResourceState> Records)
            {
                this.Records = Records;
            }

            public ImportResourceState()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "import_resource_state";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ImportResourceStateFlags;
        public void ImportResourceState(CallReducerFlags flags) => ImportResourceStateFlags = flags;
    }
}
