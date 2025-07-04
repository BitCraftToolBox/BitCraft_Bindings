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
        public delegate void ImportKnowledgeNpcStateHandler(ReducerEventContext ctx, System.Collections.Generic.List<KnowledgeNpcState> records);
        public event ImportKnowledgeNpcStateHandler? OnImportKnowledgeNpcState;

        public void ImportKnowledgeNpcState(System.Collections.Generic.List<KnowledgeNpcState> records)
        {
            conn.InternalCallReducer(new Reducer.ImportKnowledgeNpcState(records), this.SetCallReducerFlags.ImportKnowledgeNpcStateFlags);
        }

        public bool InvokeImportKnowledgeNpcState(ReducerEventContext ctx, Reducer.ImportKnowledgeNpcState args)
        {
            if (OnImportKnowledgeNpcState == null)
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
            OnImportKnowledgeNpcState(
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
        public sealed partial class ImportKnowledgeNpcState : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<KnowledgeNpcState> Records;

            public ImportKnowledgeNpcState(System.Collections.Generic.List<KnowledgeNpcState> Records)
            {
                this.Records = Records;
            }

            public ImportKnowledgeNpcState()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "import_knowledge_npc_state";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ImportKnowledgeNpcStateFlags;
        public void ImportKnowledgeNpcState(CallReducerFlags flags) => ImportKnowledgeNpcStateFlags = flags;
    }
}
