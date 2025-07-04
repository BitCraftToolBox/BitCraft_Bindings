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
        public delegate void PlayerHousingEvictPlayerHandler(ReducerEventContext ctx, PlayerHousingEvictPlayerRequest request);
        public event PlayerHousingEvictPlayerHandler? OnPlayerHousingEvictPlayer;

        public void PlayerHousingEvictPlayer(PlayerHousingEvictPlayerRequest request)
        {
            conn.InternalCallReducer(new Reducer.PlayerHousingEvictPlayer(request), this.SetCallReducerFlags.PlayerHousingEvictPlayerFlags);
        }

        public bool InvokePlayerHousingEvictPlayer(ReducerEventContext ctx, Reducer.PlayerHousingEvictPlayer args)
        {
            if (OnPlayerHousingEvictPlayer == null)
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
            OnPlayerHousingEvictPlayer(
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
        public sealed partial class PlayerHousingEvictPlayer : Reducer, IReducerArgs
        {
            [DataMember(Name = "request")]
            public PlayerHousingEvictPlayerRequest Request;

            public PlayerHousingEvictPlayer(PlayerHousingEvictPlayerRequest Request)
            {
                this.Request = Request;
            }

            public PlayerHousingEvictPlayer()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "player_housing_evict_player";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags PlayerHousingEvictPlayerFlags;
        public void PlayerHousingEvictPlayer(CallReducerFlags flags) => PlayerHousingEvictPlayerFlags = flags;
    }
}
