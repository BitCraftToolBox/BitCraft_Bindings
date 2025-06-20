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
        public delegate void StageCombatActionDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<CombatActionDesc> records);
        public event StageCombatActionDescHandler? OnStageCombatActionDesc;

        public void StageCombatActionDesc(System.Collections.Generic.List<CombatActionDesc> records)
        {
            conn.InternalCallReducer(new Reducer.StageCombatActionDesc(records), this.SetCallReducerFlags.StageCombatActionDescFlags);
        }

        public bool InvokeStageCombatActionDesc(ReducerEventContext ctx, Reducer.StageCombatActionDesc args)
        {
            if (OnStageCombatActionDesc == null)
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
            OnStageCombatActionDesc(
                ctx,
                args.Records
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class StageCombatActionDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<CombatActionDesc> Records;

            public StageCombatActionDesc(System.Collections.Generic.List<CombatActionDesc> Records)
            {
                this.Records = Records;
            }

            public StageCombatActionDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "stage_combat_action_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags StageCombatActionDescFlags;
        public void StageCombatActionDesc(CallReducerFlags flags) => StageCombatActionDescFlags = flags;
    }
}
