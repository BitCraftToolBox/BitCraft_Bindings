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
        public delegate void AdminDespawnOverworldEnemiesHandler(ReducerEventContext ctx);
        public event AdminDespawnOverworldEnemiesHandler? OnAdminDespawnOverworldEnemies;

        public void AdminDespawnOverworldEnemies()
        {
            conn.InternalCallReducer(new Reducer.AdminDespawnOverworldEnemies(), this.SetCallReducerFlags.AdminDespawnOverworldEnemiesFlags);
        }

        public bool InvokeAdminDespawnOverworldEnemies(ReducerEventContext ctx, Reducer.AdminDespawnOverworldEnemies args)
        {
            if (OnAdminDespawnOverworldEnemies == null)
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
            OnAdminDespawnOverworldEnemies(
                ctx
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class AdminDespawnOverworldEnemies : Reducer, IReducerArgs
        {
            string IReducerArgs.ReducerName => "admin_despawn_overworld_enemies";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags AdminDespawnOverworldEnemiesFlags;
        public void AdminDespawnOverworldEnemies(CallReducerFlags flags) => AdminDespawnOverworldEnemiesFlags = flags;
    }
}
