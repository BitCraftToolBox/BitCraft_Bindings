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
        public delegate void StageToolTypeDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<ToolTypeDesc> records);
        public event StageToolTypeDescHandler? OnStageToolTypeDesc;

        public void StageToolTypeDesc(System.Collections.Generic.List<ToolTypeDesc> records)
        {
            conn.InternalCallReducer(new Reducer.StageToolTypeDesc(records), this.SetCallReducerFlags.StageToolTypeDescFlags);
        }

        public bool InvokeStageToolTypeDesc(ReducerEventContext ctx, Reducer.StageToolTypeDesc args)
        {
            if (OnStageToolTypeDesc == null)
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
            OnStageToolTypeDesc(
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
        public sealed partial class StageToolTypeDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<ToolTypeDesc> Records;

            public StageToolTypeDesc(System.Collections.Generic.List<ToolTypeDesc> Records)
            {
                this.Records = Records;
            }

            public StageToolTypeDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "stage_tool_type_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags StageToolTypeDescFlags;
        public void StageToolTypeDesc(CallReducerFlags flags) => StageToolTypeDescFlags = flags;
    }
}
