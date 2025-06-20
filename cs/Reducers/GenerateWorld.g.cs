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
        public delegate void GenerateWorldHandler(ReducerEventContext ctx, WorldGenWorldDefinition worldDefinition);
        public event GenerateWorldHandler? OnGenerateWorld;

        public void GenerateWorld(WorldGenWorldDefinition worldDefinition)
        {
            conn.InternalCallReducer(new Reducer.GenerateWorld(worldDefinition), this.SetCallReducerFlags.GenerateWorldFlags);
        }

        public bool InvokeGenerateWorld(ReducerEventContext ctx, Reducer.GenerateWorld args)
        {
            if (OnGenerateWorld == null)
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
            OnGenerateWorld(
                ctx,
                args.WorldDefinition
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class GenerateWorld : Reducer, IReducerArgs
        {
            [DataMember(Name = "world_definition")]
            public WorldGenWorldDefinition WorldDefinition;

            public GenerateWorld(WorldGenWorldDefinition WorldDefinition)
            {
                this.WorldDefinition = WorldDefinition;
            }

            public GenerateWorld()
            {
                this.WorldDefinition = new();
            }

            string IReducerArgs.ReducerName => "generate_world";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags GenerateWorldFlags;
        public void GenerateWorld(CallReducerFlags flags) => GenerateWorldFlags = flags;
    }
}
