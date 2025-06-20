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
        public delegate void AdminAlpha3ResetOnboardingToFirstExpandQuestHandler(ReducerEventContext ctx, ulong entityId);
        public event AdminAlpha3ResetOnboardingToFirstExpandQuestHandler? OnAdminAlpha3ResetOnboardingToFirstExpandQuest;

        public void AdminAlpha3ResetOnboardingToFirstExpandQuest(ulong entityId)
        {
            conn.InternalCallReducer(new Reducer.AdminAlpha3ResetOnboardingToFirstExpandQuest(entityId), this.SetCallReducerFlags.AdminAlpha3ResetOnboardingToFirstExpandQuestFlags);
        }

        public bool InvokeAdminAlpha3ResetOnboardingToFirstExpandQuest(ReducerEventContext ctx, Reducer.AdminAlpha3ResetOnboardingToFirstExpandQuest args)
        {
            if (OnAdminAlpha3ResetOnboardingToFirstExpandQuest == null)
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
            OnAdminAlpha3ResetOnboardingToFirstExpandQuest(
                ctx,
                args.EntityId
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class AdminAlpha3ResetOnboardingToFirstExpandQuest : Reducer, IReducerArgs
        {
            [DataMember(Name = "entity_id")]
            public ulong EntityId;

            public AdminAlpha3ResetOnboardingToFirstExpandQuest(ulong EntityId)
            {
                this.EntityId = EntityId;
            }

            public AdminAlpha3ResetOnboardingToFirstExpandQuest()
            {
            }

            string IReducerArgs.ReducerName => "admin_alpha3_reset_onboarding_to_first_expand_quest";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags AdminAlpha3ResetOnboardingToFirstExpandQuestFlags;
        public void AdminAlpha3ResetOnboardingToFirstExpandQuest(CallReducerFlags flags) => AdminAlpha3ResetOnboardingToFirstExpandQuestFlags = flags;
    }
}
