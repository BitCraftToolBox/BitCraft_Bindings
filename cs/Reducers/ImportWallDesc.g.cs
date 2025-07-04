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
        public delegate void ImportWallDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<WallDesc> records);
        public event ImportWallDescHandler? OnImportWallDesc;

        public void ImportWallDesc(System.Collections.Generic.List<WallDesc> records)
        {
            conn.InternalCallReducer(new Reducer.ImportWallDesc(records), this.SetCallReducerFlags.ImportWallDescFlags);
        }

        public bool InvokeImportWallDesc(ReducerEventContext ctx, Reducer.ImportWallDesc args)
        {
            if (OnImportWallDesc == null)
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
            OnImportWallDesc(
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
        public sealed partial class ImportWallDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<WallDesc> Records;

            public ImportWallDesc(System.Collections.Generic.List<WallDesc> Records)
            {
                this.Records = Records;
            }

            public ImportWallDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "import_wall_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ImportWallDescFlags;
        public void ImportWallDesc(CallReducerFlags flags) => ImportWallDescFlags = flags;
    }
}
