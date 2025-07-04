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
        public delegate void CheatBuildingMoveHandler(ReducerEventContext ctx, PlayerBuildingMoveRequest request);
        public event CheatBuildingMoveHandler? OnCheatBuildingMove;

        public void CheatBuildingMove(PlayerBuildingMoveRequest request)
        {
            conn.InternalCallReducer(new Reducer.CheatBuildingMove(request), this.SetCallReducerFlags.CheatBuildingMoveFlags);
        }

        public bool InvokeCheatBuildingMove(ReducerEventContext ctx, Reducer.CheatBuildingMove args)
        {
            if (OnCheatBuildingMove == null)
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
            OnCheatBuildingMove(
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
        public sealed partial class CheatBuildingMove : Reducer, IReducerArgs
        {
            [DataMember(Name = "request")]
            public PlayerBuildingMoveRequest Request;

            public CheatBuildingMove(PlayerBuildingMoveRequest Request)
            {
                this.Request = Request;
            }

            public CheatBuildingMove()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "cheat_building_move";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags CheatBuildingMoveFlags;
        public void CheatBuildingMove(CallReducerFlags flags) => CheatBuildingMoveFlags = flags;
    }
}
