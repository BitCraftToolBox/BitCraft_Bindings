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
        public delegate void ClaimSetMemberPermissionsHandler(ReducerEventContext ctx, PlayerClaimSetMemberPermissionsRequest request);
        public event ClaimSetMemberPermissionsHandler? OnClaimSetMemberPermissions;

        public void ClaimSetMemberPermissions(PlayerClaimSetMemberPermissionsRequest request)
        {
            conn.InternalCallReducer(new Reducer.ClaimSetMemberPermissions(request), this.SetCallReducerFlags.ClaimSetMemberPermissionsFlags);
        }

        public bool InvokeClaimSetMemberPermissions(ReducerEventContext ctx, Reducer.ClaimSetMemberPermissions args)
        {
            if (OnClaimSetMemberPermissions == null)
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
            OnClaimSetMemberPermissions(
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
        public sealed partial class ClaimSetMemberPermissions : Reducer, IReducerArgs
        {
            [DataMember(Name = "request")]
            public PlayerClaimSetMemberPermissionsRequest Request;

            public ClaimSetMemberPermissions(PlayerClaimSetMemberPermissionsRequest Request)
            {
                this.Request = Request;
            }

            public ClaimSetMemberPermissions()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "claim_set_member_permissions";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ClaimSetMemberPermissionsFlags;
        public void ClaimSetMemberPermissions(CallReducerFlags flags) => ClaimSetMemberPermissionsFlags = flags;
    }
}
