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
        public delegate void ImportElevatorDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<ElevatorDesc> records);
        public event ImportElevatorDescHandler? OnImportElevatorDesc;

        public void ImportElevatorDesc(System.Collections.Generic.List<ElevatorDesc> records)
        {
            conn.InternalCallReducer(new Reducer.ImportElevatorDesc(records), this.SetCallReducerFlags.ImportElevatorDescFlags);
        }

        public bool InvokeImportElevatorDesc(ReducerEventContext ctx, Reducer.ImportElevatorDesc args)
        {
            if (OnImportElevatorDesc == null)
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
            OnImportElevatorDesc(
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
        public sealed partial class ImportElevatorDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<ElevatorDesc> Records;

            public ImportElevatorDesc(System.Collections.Generic.List<ElevatorDesc> Records)
            {
                this.Records = Records;
            }

            public ImportElevatorDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "import_elevator_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ImportElevatorDescFlags;
        public void ImportElevatorDesc(CallReducerFlags flags) => ImportElevatorDescFlags = flags;
    }
}
