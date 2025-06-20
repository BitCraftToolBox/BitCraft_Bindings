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
        public delegate void RentDepositCoinsHandler(ReducerEventContext ctx, RentDepositCoinsRequest request);
        public event RentDepositCoinsHandler? OnRentDepositCoins;

        public void RentDepositCoins(RentDepositCoinsRequest request)
        {
            conn.InternalCallReducer(new Reducer.RentDepositCoins(request), this.SetCallReducerFlags.RentDepositCoinsFlags);
        }

        public bool InvokeRentDepositCoins(ReducerEventContext ctx, Reducer.RentDepositCoins args)
        {
            if (OnRentDepositCoins == null)
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
            OnRentDepositCoins(
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
        public sealed partial class RentDepositCoins : Reducer, IReducerArgs
        {
            [DataMember(Name = "request")]
            public RentDepositCoinsRequest Request;

            public RentDepositCoins(RentDepositCoinsRequest Request)
            {
                this.Request = Request;
            }

            public RentDepositCoins()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "rent_deposit_coins";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags RentDepositCoinsFlags;
        public void RentDepositCoins(CallReducerFlags flags) => RentDepositCoinsFlags = flags;
    }
}
