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
        public delegate void PlayerRegenAgentLoopHandler(ReducerEventContext ctx, PlayerRegenLoopTimer timer);
        public event PlayerRegenAgentLoopHandler? OnPlayerRegenAgentLoop;

        public void PlayerRegenAgentLoop(PlayerRegenLoopTimer timer)
        {
            conn.InternalCallReducer(new Reducer.PlayerRegenAgentLoop(timer), this.SetCallReducerFlags.PlayerRegenAgentLoopFlags);
        }

        public bool InvokePlayerRegenAgentLoop(ReducerEventContext ctx, Reducer.PlayerRegenAgentLoop args)
        {
            if (OnPlayerRegenAgentLoop == null)
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
            OnPlayerRegenAgentLoop(
                ctx,
                args.Timer
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class PlayerRegenAgentLoop : Reducer, IReducerArgs
        {
            [DataMember(Name = "_timer")]
            public PlayerRegenLoopTimer Timer;

            public PlayerRegenAgentLoop(PlayerRegenLoopTimer Timer)
            {
                this.Timer = Timer;
            }

            public PlayerRegenAgentLoop()
            {
                this.Timer = new();
            }

            string IReducerArgs.ReducerName => "player_regen_agent_loop";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags PlayerRegenAgentLoopFlags;
        public void PlayerRegenAgentLoop(CallReducerFlags flags) => PlayerRegenAgentLoopFlags = flags;
    }
}
