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
        public delegate void ClaimRemoveRecruitmentHandler(ReducerEventContext ctx, PlayerClaimRemoveRecruitmentRequest request);
        public event ClaimRemoveRecruitmentHandler? OnClaimRemoveRecruitment;

        public void ClaimRemoveRecruitment(PlayerClaimRemoveRecruitmentRequest request)
        {
            conn.InternalCallReducer(new Reducer.ClaimRemoveRecruitment(request), this.SetCallReducerFlags.ClaimRemoveRecruitmentFlags);
        }

        public bool InvokeClaimRemoveRecruitment(ReducerEventContext ctx, Reducer.ClaimRemoveRecruitment args)
        {
            if (OnClaimRemoveRecruitment == null)
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
            OnClaimRemoveRecruitment(
                ctx,
                args.Request
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class ClaimRemoveRecruitment : Reducer, IReducerArgs
        {
            [DataMember(Name = "request")]
            public PlayerClaimRemoveRecruitmentRequest Request;

            public ClaimRemoveRecruitment(PlayerClaimRemoveRecruitmentRequest Request)
            {
                this.Request = Request;
            }

            public ClaimRemoveRecruitment()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "claim_remove_recruitment";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ClaimRemoveRecruitmentFlags;
        public void ClaimRemoveRecruitment(CallReducerFlags flags) => ClaimRemoveRecruitmentFlags = flags;
    }
}
