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
        public delegate void ClaimTakeOwnershipHandler(ReducerEventContext ctx, PlayerClaimTakeOwnershipRequest request);
        public event ClaimTakeOwnershipHandler? OnClaimTakeOwnership;

        public void ClaimTakeOwnership(PlayerClaimTakeOwnershipRequest request)
        {
            conn.InternalCallReducer(new Reducer.ClaimTakeOwnership(request), this.SetCallReducerFlags.ClaimTakeOwnershipFlags);
        }

        public bool InvokeClaimTakeOwnership(ReducerEventContext ctx, Reducer.ClaimTakeOwnership args)
        {
            if (OnClaimTakeOwnership == null)
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
            OnClaimTakeOwnership(
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
        public sealed partial class ClaimTakeOwnership : Reducer, IReducerArgs
        {
            [DataMember(Name = "request")]
            public PlayerClaimTakeOwnershipRequest Request;

            public ClaimTakeOwnership(PlayerClaimTakeOwnershipRequest Request)
            {
                this.Request = Request;
            }

            public ClaimTakeOwnership()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "claim_take_ownership";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ClaimTakeOwnershipFlags;
        public void ClaimTakeOwnership(CallReducerFlags flags) => ClaimTakeOwnershipFlags = flags;
    }
}
