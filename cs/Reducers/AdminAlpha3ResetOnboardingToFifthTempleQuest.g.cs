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
        public delegate void AdminAlpha3ResetOnboardingToFifthTempleQuestHandler(ReducerEventContext ctx, ulong entityId);
        public event AdminAlpha3ResetOnboardingToFifthTempleQuestHandler? OnAdminAlpha3ResetOnboardingToFifthTempleQuest;

        public void AdminAlpha3ResetOnboardingToFifthTempleQuest(ulong entityId)
        {
            conn.InternalCallReducer(new Reducer.AdminAlpha3ResetOnboardingToFifthTempleQuest(entityId), this.SetCallReducerFlags.AdminAlpha3ResetOnboardingToFifthTempleQuestFlags);
        }

        public bool InvokeAdminAlpha3ResetOnboardingToFifthTempleQuest(ReducerEventContext ctx, Reducer.AdminAlpha3ResetOnboardingToFifthTempleQuest args)
        {
            if (OnAdminAlpha3ResetOnboardingToFifthTempleQuest == null)
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
            OnAdminAlpha3ResetOnboardingToFifthTempleQuest(
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
        public sealed partial class AdminAlpha3ResetOnboardingToFifthTempleQuest : Reducer, IReducerArgs
        {
            [DataMember(Name = "entity_id")]
            public ulong EntityId;

            public AdminAlpha3ResetOnboardingToFifthTempleQuest(ulong EntityId)
            {
                this.EntityId = EntityId;
            }

            public AdminAlpha3ResetOnboardingToFifthTempleQuest()
            {
            }

            string IReducerArgs.ReducerName => "admin_alpha3_reset_onboarding_to_fifth_temple_quest";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags AdminAlpha3ResetOnboardingToFifthTempleQuestFlags;
        public void AdminAlpha3ResetOnboardingToFifthTempleQuest(CallReducerFlags flags) => AdminAlpha3ResetOnboardingToFifthTempleQuestFlags = flags;
    }
}
