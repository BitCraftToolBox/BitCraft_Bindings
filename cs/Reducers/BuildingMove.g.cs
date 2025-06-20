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
        public delegate void BuildingMoveHandler(ReducerEventContext ctx, PlayerBuildingMoveRequest request);
        public event BuildingMoveHandler? OnBuildingMove;

        public void BuildingMove(PlayerBuildingMoveRequest request)
        {
            conn.InternalCallReducer(new Reducer.BuildingMove(request), this.SetCallReducerFlags.BuildingMoveFlags);
        }

        public bool InvokeBuildingMove(ReducerEventContext ctx, Reducer.BuildingMove args)
        {
            if (OnBuildingMove == null)
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
            OnBuildingMove(
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
        public sealed partial class BuildingMove : Reducer, IReducerArgs
        {
            [DataMember(Name = "request")]
            public PlayerBuildingMoveRequest Request;

            public BuildingMove(PlayerBuildingMoveRequest Request)
            {
                this.Request = Request;
            }

            public BuildingMove()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "building_move";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags BuildingMoveFlags;
        public void BuildingMove(CallReducerFlags flags) => BuildingMoveFlags = flags;
    }
}
