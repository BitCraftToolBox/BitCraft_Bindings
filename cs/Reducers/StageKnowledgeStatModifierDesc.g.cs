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
        public delegate void StageKnowledgeStatModifierDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<KnowledgeStatModifierDesc> records);
        public event StageKnowledgeStatModifierDescHandler? OnStageKnowledgeStatModifierDesc;

        public void StageKnowledgeStatModifierDesc(System.Collections.Generic.List<KnowledgeStatModifierDesc> records)
        {
            conn.InternalCallReducer(new Reducer.StageKnowledgeStatModifierDesc(records), this.SetCallReducerFlags.StageKnowledgeStatModifierDescFlags);
        }

        public bool InvokeStageKnowledgeStatModifierDesc(ReducerEventContext ctx, Reducer.StageKnowledgeStatModifierDesc args)
        {
            if (OnStageKnowledgeStatModifierDesc == null)
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
            OnStageKnowledgeStatModifierDesc(
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
        public sealed partial class StageKnowledgeStatModifierDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<KnowledgeStatModifierDesc> Records;

            public StageKnowledgeStatModifierDesc(System.Collections.Generic.List<KnowledgeStatModifierDesc> Records)
            {
                this.Records = Records;
            }

            public StageKnowledgeStatModifierDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "stage_knowledge_stat_modifier_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags StageKnowledgeStatModifierDescFlags;
        public void StageKnowledgeStatModifierDesc(CallReducerFlags flags) => StageKnowledgeStatModifierDescFlags = flags;
    }
}
