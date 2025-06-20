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
        public delegate void CheatPavingAddTileHandler(ReducerEventContext ctx, PlayerPavingPlaceTileRequest request);
        public event CheatPavingAddTileHandler? OnCheatPavingAddTile;

        public void CheatPavingAddTile(PlayerPavingPlaceTileRequest request)
        {
            conn.InternalCallReducer(new Reducer.CheatPavingAddTile(request), this.SetCallReducerFlags.CheatPavingAddTileFlags);
        }

        public bool InvokeCheatPavingAddTile(ReducerEventContext ctx, Reducer.CheatPavingAddTile args)
        {
            if (OnCheatPavingAddTile == null)
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
            OnCheatPavingAddTile(
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
        public sealed partial class CheatPavingAddTile : Reducer, IReducerArgs
        {
            [DataMember(Name = "request")]
            public PlayerPavingPlaceTileRequest Request;

            public CheatPavingAddTile(PlayerPavingPlaceTileRequest Request)
            {
                this.Request = Request;
            }

            public CheatPavingAddTile()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "cheat_paving_add_tile";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags CheatPavingAddTileFlags;
        public void CheatPavingAddTile(CallReducerFlags flags) => CheatPavingAddTileFlags = flags;
    }
}
