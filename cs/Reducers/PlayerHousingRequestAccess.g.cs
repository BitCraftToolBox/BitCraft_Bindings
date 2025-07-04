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
        public delegate void PlayerHousingRequestAccessHandler(ReducerEventContext ctx, PlayerHousingRequestAccessRequest request);
        public event PlayerHousingRequestAccessHandler? OnPlayerHousingRequestAccess;

        public void PlayerHousingRequestAccess(PlayerHousingRequestAccessRequest request)
        {
            conn.InternalCallReducer(new Reducer.PlayerHousingRequestAccess(request), this.SetCallReducerFlags.PlayerHousingRequestAccessFlags);
        }

        public bool InvokePlayerHousingRequestAccess(ReducerEventContext ctx, Reducer.PlayerHousingRequestAccess args)
        {
            if (OnPlayerHousingRequestAccess == null)
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
            OnPlayerHousingRequestAccess(
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
        public sealed partial class PlayerHousingRequestAccess : Reducer, IReducerArgs
        {
            [DataMember(Name = "request")]
            public PlayerHousingRequestAccessRequest Request;

            public PlayerHousingRequestAccess(PlayerHousingRequestAccessRequest Request)
            {
                this.Request = Request;
            }

            public PlayerHousingRequestAccess()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "player_housing_request_access";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags PlayerHousingRequestAccessFlags;
        public void PlayerHousingRequestAccess(CallReducerFlags flags) => PlayerHousingRequestAccessFlags = flags;
    }
}
