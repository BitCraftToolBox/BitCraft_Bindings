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
        public delegate void PlayerRespawnHandler(ReducerEventContext ctx, bool teleportHome);
        public event PlayerRespawnHandler? OnPlayerRespawn;

        public void PlayerRespawn(bool teleportHome)
        {
            conn.InternalCallReducer(new Reducer.PlayerRespawn(teleportHome), this.SetCallReducerFlags.PlayerRespawnFlags);
        }

        public bool InvokePlayerRespawn(ReducerEventContext ctx, Reducer.PlayerRespawn args)
        {
            if (OnPlayerRespawn == null)
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
            OnPlayerRespawn(
                ctx,
                args.TeleportHome
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class PlayerRespawn : Reducer, IReducerArgs
        {
            [DataMember(Name = "teleport_home")]
            public bool TeleportHome;

            public PlayerRespawn(bool TeleportHome)
            {
                this.TeleportHome = TeleportHome;
            }

            public PlayerRespawn()
            {
            }

            string IReducerArgs.ReducerName => "player_respawn";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags PlayerRespawnFlags;
        public void PlayerRespawn(CallReducerFlags flags) => PlayerRespawnFlags = flags;
    }
}
