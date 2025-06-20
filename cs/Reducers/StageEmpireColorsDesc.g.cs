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
        public delegate void StageEmpireColorsDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<EmpireColorDesc> records);
        public event StageEmpireColorsDescHandler? OnStageEmpireColorsDesc;

        public void StageEmpireColorsDesc(System.Collections.Generic.List<EmpireColorDesc> records)
        {
            conn.InternalCallReducer(new Reducer.StageEmpireColorsDesc(records), this.SetCallReducerFlags.StageEmpireColorsDescFlags);
        }

        public bool InvokeStageEmpireColorsDesc(ReducerEventContext ctx, Reducer.StageEmpireColorsDesc args)
        {
            if (OnStageEmpireColorsDesc == null)
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
            OnStageEmpireColorsDesc(
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
        public sealed partial class StageEmpireColorsDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<EmpireColorDesc> Records;

            public StageEmpireColorsDesc(System.Collections.Generic.List<EmpireColorDesc> Records)
            {
                this.Records = Records;
            }

            public StageEmpireColorsDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "stage_empire_colors_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags StageEmpireColorsDescFlags;
        public void StageEmpireColorsDesc(CallReducerFlags flags) => StageEmpireColorsDescFlags = flags;
    }
}
