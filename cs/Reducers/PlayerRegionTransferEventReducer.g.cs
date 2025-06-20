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
        public delegate void PlayerRegionTransferEventReducerHandler(ReducerEventContext ctx, PlayerRegionTransferEvent timer);
        public event PlayerRegionTransferEventReducerHandler? OnPlayerRegionTransferEventReducer;

        public void PlayerRegionTransferEventReducer(PlayerRegionTransferEvent timer)
        {
            conn.InternalCallReducer(new Reducer.PlayerRegionTransferEventReducer(timer), this.SetCallReducerFlags.PlayerRegionTransferEventReducerFlags);
        }

        public bool InvokePlayerRegionTransferEventReducer(ReducerEventContext ctx, Reducer.PlayerRegionTransferEventReducer args)
        {
            if (OnPlayerRegionTransferEventReducer == null)
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
            OnPlayerRegionTransferEventReducer(
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
        public sealed partial class PlayerRegionTransferEventReducer : Reducer, IReducerArgs
        {
            [DataMember(Name = "_timer")]
            public PlayerRegionTransferEvent Timer;

            public PlayerRegionTransferEventReducer(PlayerRegionTransferEvent Timer)
            {
                this.Timer = Timer;
            }

            public PlayerRegionTransferEventReducer()
            {
                this.Timer = new();
            }

            string IReducerArgs.ReducerName => "player_region_transfer_event_reducer";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags PlayerRegionTransferEventReducerFlags;
        public void PlayerRegionTransferEventReducer(CallReducerFlags flags) => PlayerRegionTransferEventReducerFlags = flags;
    }
}
