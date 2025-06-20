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
        public delegate void ImportBuffTypeDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<BuffTypeDesc> records);
        public event ImportBuffTypeDescHandler? OnImportBuffTypeDesc;

        public void ImportBuffTypeDesc(System.Collections.Generic.List<BuffTypeDesc> records)
        {
            conn.InternalCallReducer(new Reducer.ImportBuffTypeDesc(records), this.SetCallReducerFlags.ImportBuffTypeDescFlags);
        }

        public bool InvokeImportBuffTypeDesc(ReducerEventContext ctx, Reducer.ImportBuffTypeDesc args)
        {
            if (OnImportBuffTypeDesc == null)
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
            OnImportBuffTypeDesc(
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
        public sealed partial class ImportBuffTypeDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<BuffTypeDesc> Records;

            public ImportBuffTypeDesc(System.Collections.Generic.List<BuffTypeDesc> Records)
            {
                this.Records = Records;
            }

            public ImportBuffTypeDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "import_buff_type_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ImportBuffTypeDescFlags;
        public void ImportBuffTypeDesc(CallReducerFlags flags) => ImportBuffTypeDescFlags = flags;
    }
}
