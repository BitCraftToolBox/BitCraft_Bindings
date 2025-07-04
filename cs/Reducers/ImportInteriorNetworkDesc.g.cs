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
        public delegate void ImportInteriorNetworkDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<InteriorNetworkDesc> records);
        public event ImportInteriorNetworkDescHandler? OnImportInteriorNetworkDesc;

        public void ImportInteriorNetworkDesc(System.Collections.Generic.List<InteriorNetworkDesc> records)
        {
            conn.InternalCallReducer(new Reducer.ImportInteriorNetworkDesc(records), this.SetCallReducerFlags.ImportInteriorNetworkDescFlags);
        }

        public bool InvokeImportInteriorNetworkDesc(ReducerEventContext ctx, Reducer.ImportInteriorNetworkDesc args)
        {
            if (OnImportInteriorNetworkDesc == null)
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
            OnImportInteriorNetworkDesc(
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
        public sealed partial class ImportInteriorNetworkDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<InteriorNetworkDesc> Records;

            public ImportInteriorNetworkDesc(System.Collections.Generic.List<InteriorNetworkDesc> Records)
            {
                this.Records = Records;
            }

            public ImportInteriorNetworkDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "import_interior_network_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ImportInteriorNetworkDescFlags;
        public void ImportInteriorNetworkDesc(CallReducerFlags flags) => ImportInteriorNetworkDescFlags = flags;
    }
}
