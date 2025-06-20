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
        public delegate void StageInteriorShapeDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<InteriorShapeDesc> records);
        public event StageInteriorShapeDescHandler? OnStageInteriorShapeDesc;

        public void StageInteriorShapeDesc(System.Collections.Generic.List<InteriorShapeDesc> records)
        {
            conn.InternalCallReducer(new Reducer.StageInteriorShapeDesc(records), this.SetCallReducerFlags.StageInteriorShapeDescFlags);
        }

        public bool InvokeStageInteriorShapeDesc(ReducerEventContext ctx, Reducer.StageInteriorShapeDesc args)
        {
            if (OnStageInteriorShapeDesc == null)
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
            OnStageInteriorShapeDesc(
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
        public sealed partial class StageInteriorShapeDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<InteriorShapeDesc> Records;

            public StageInteriorShapeDesc(System.Collections.Generic.List<InteriorShapeDesc> Records)
            {
                this.Records = Records;
            }

            public StageInteriorShapeDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "stage_interior_shape_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags StageInteriorShapeDescFlags;
        public void StageInteriorShapeDesc(CallReducerFlags flags) => StageInteriorShapeDescFlags = flags;
    }
}
