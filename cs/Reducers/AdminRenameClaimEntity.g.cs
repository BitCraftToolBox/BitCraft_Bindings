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
        public delegate void AdminRenameClaimEntityHandler(ReducerEventContext ctx, ulong entityId, string newName);
        public event AdminRenameClaimEntityHandler? OnAdminRenameClaimEntity;

        public void AdminRenameClaimEntity(ulong entityId, string newName)
        {
            conn.InternalCallReducer(new Reducer.AdminRenameClaimEntity(entityId, newName), this.SetCallReducerFlags.AdminRenameClaimEntityFlags);
        }

        public bool InvokeAdminRenameClaimEntity(ReducerEventContext ctx, Reducer.AdminRenameClaimEntity args)
        {
            if (OnAdminRenameClaimEntity == null)
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
            OnAdminRenameClaimEntity(
                ctx,
                args.EntityId,
                args.NewName
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class AdminRenameClaimEntity : Reducer, IReducerArgs
        {
            [DataMember(Name = "entity_id")]
            public ulong EntityId;
            [DataMember(Name = "new_name")]
            public string NewName;

            public AdminRenameClaimEntity(
                ulong EntityId,
                string NewName
            )
            {
                this.EntityId = EntityId;
                this.NewName = NewName;
            }

            public AdminRenameClaimEntity()
            {
                this.NewName = "";
            }

            string IReducerArgs.ReducerName => "admin_rename_claim_entity";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags AdminRenameClaimEntityFlags;
        public void AdminRenameClaimEntity(CallReducerFlags flags) => AdminRenameClaimEntityFlags = flags;
    }
}
