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
        public delegate void AdminClearAllResourcesHandler(ReducerEventContext ctx);
        public event AdminClearAllResourcesHandler? OnAdminClearAllResources;

        public void AdminClearAllResources()
        {
            conn.InternalCallReducer(new Reducer.AdminClearAllResources(), this.SetCallReducerFlags.AdminClearAllResourcesFlags);
        }

        public bool InvokeAdminClearAllResources(ReducerEventContext ctx, Reducer.AdminClearAllResources args)
        {
            if (OnAdminClearAllResources == null)
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
            OnAdminClearAllResources(
                ctx
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class AdminClearAllResources : Reducer, IReducerArgs
        {
            string IReducerArgs.ReducerName => "admin_clear_all_resources";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags AdminClearAllResourcesFlags;
        public void AdminClearAllResources(CallReducerFlags flags) => AdminClearAllResourcesFlags = flags;
    }
}
