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
        public delegate void BuildingRepairHandler(ReducerEventContext ctx, PlayerBuildingRepairRequest request);
        public event BuildingRepairHandler? OnBuildingRepair;

        public void BuildingRepair(PlayerBuildingRepairRequest request)
        {
            conn.InternalCallReducer(new Reducer.BuildingRepair(request), this.SetCallReducerFlags.BuildingRepairFlags);
        }

        public bool InvokeBuildingRepair(ReducerEventContext ctx, Reducer.BuildingRepair args)
        {
            if (OnBuildingRepair == null)
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
            OnBuildingRepair(
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
        public sealed partial class BuildingRepair : Reducer, IReducerArgs
        {
            [DataMember(Name = "request")]
            public PlayerBuildingRepairRequest Request;

            public BuildingRepair(PlayerBuildingRepairRequest Request)
            {
                this.Request = Request;
            }

            public BuildingRepair()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "building_repair";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags BuildingRepairFlags;
        public void BuildingRepair(CallReducerFlags flags) => BuildingRepairFlags = flags;
    }
}
