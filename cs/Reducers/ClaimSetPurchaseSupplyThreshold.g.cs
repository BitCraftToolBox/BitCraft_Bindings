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
        public delegate void ClaimSetPurchaseSupplyThresholdHandler(ReducerEventContext ctx, ClaimSetPurchaseSupplyThresholdRequest request);
        public event ClaimSetPurchaseSupplyThresholdHandler? OnClaimSetPurchaseSupplyThreshold;

        public void ClaimSetPurchaseSupplyThreshold(ClaimSetPurchaseSupplyThresholdRequest request)
        {
            conn.InternalCallReducer(new Reducer.ClaimSetPurchaseSupplyThreshold(request), this.SetCallReducerFlags.ClaimSetPurchaseSupplyThresholdFlags);
        }

        public bool InvokeClaimSetPurchaseSupplyThreshold(ReducerEventContext ctx, Reducer.ClaimSetPurchaseSupplyThreshold args)
        {
            if (OnClaimSetPurchaseSupplyThreshold == null)
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
            OnClaimSetPurchaseSupplyThreshold(
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
        public sealed partial class ClaimSetPurchaseSupplyThreshold : Reducer, IReducerArgs
        {
            [DataMember(Name = "request")]
            public ClaimSetPurchaseSupplyThresholdRequest Request;

            public ClaimSetPurchaseSupplyThreshold(ClaimSetPurchaseSupplyThresholdRequest Request)
            {
                this.Request = Request;
            }

            public ClaimSetPurchaseSupplyThreshold()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "claim_set_purchase_supply_threshold";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ClaimSetPurchaseSupplyThresholdFlags;
        public void ClaimSetPurchaseSupplyThreshold(CallReducerFlags flags) => ClaimSetPurchaseSupplyThresholdFlags = flags;
    }
}
