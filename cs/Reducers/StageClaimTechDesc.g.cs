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
        public delegate void StageClaimTechDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<ClaimTechDesc> records);
        public event StageClaimTechDescHandler? OnStageClaimTechDesc;

        public void StageClaimTechDesc(System.Collections.Generic.List<ClaimTechDesc> records)
        {
            conn.InternalCallReducer(new Reducer.StageClaimTechDesc(records), this.SetCallReducerFlags.StageClaimTechDescFlags);
        }

        public bool InvokeStageClaimTechDesc(ReducerEventContext ctx, Reducer.StageClaimTechDesc args)
        {
            if (OnStageClaimTechDesc == null)
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
            OnStageClaimTechDesc(
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
        public sealed partial class StageClaimTechDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<ClaimTechDesc> Records;

            public StageClaimTechDesc(System.Collections.Generic.List<ClaimTechDesc> Records)
            {
                this.Records = Records;
            }

            public StageClaimTechDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "stage_claim_tech_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags StageClaimTechDescFlags;
        public void StageClaimTechDesc(CallReducerFlags flags) => StageClaimTechDescFlags = flags;
    }
}
