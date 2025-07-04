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
        public delegate void AdminRenameDeployableHandler(ReducerEventContext ctx, string deployableName, string newName);
        public event AdminRenameDeployableHandler? OnAdminRenameDeployable;

        public void AdminRenameDeployable(string deployableName, string newName)
        {
            conn.InternalCallReducer(new Reducer.AdminRenameDeployable(deployableName, newName), this.SetCallReducerFlags.AdminRenameDeployableFlags);
        }

        public bool InvokeAdminRenameDeployable(ReducerEventContext ctx, Reducer.AdminRenameDeployable args)
        {
            if (OnAdminRenameDeployable == null)
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
            OnAdminRenameDeployable(
                ctx,
                args.DeployableName,
                args.NewName
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class AdminRenameDeployable : Reducer, IReducerArgs
        {
            [DataMember(Name = "deployable_name")]
            public string DeployableName;
            [DataMember(Name = "new_name")]
            public string NewName;

            public AdminRenameDeployable(
                string DeployableName,
                string NewName
            )
            {
                this.DeployableName = DeployableName;
                this.NewName = NewName;
            }

            public AdminRenameDeployable()
            {
                this.DeployableName = "";
                this.NewName = "";
            }

            string IReducerArgs.ReducerName => "admin_rename_deployable";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags AdminRenameDeployableFlags;
        public void AdminRenameDeployable(CallReducerFlags flags) => AdminRenameDeployableFlags = flags;
    }
}
