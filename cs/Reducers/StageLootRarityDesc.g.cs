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
        public delegate void StageLootRarityDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<LootRarityDesc> records);
        public event StageLootRarityDescHandler? OnStageLootRarityDesc;

        public void StageLootRarityDesc(System.Collections.Generic.List<LootRarityDesc> records)
        {
            conn.InternalCallReducer(new Reducer.StageLootRarityDesc(records), this.SetCallReducerFlags.StageLootRarityDescFlags);
        }

        public bool InvokeStageLootRarityDesc(ReducerEventContext ctx, Reducer.StageLootRarityDesc args)
        {
            if (OnStageLootRarityDesc == null)
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
            OnStageLootRarityDesc(
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
        public sealed partial class StageLootRarityDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<LootRarityDesc> Records;

            public StageLootRarityDesc(System.Collections.Generic.List<LootRarityDesc> Records)
            {
                this.Records = Records;
            }

            public StageLootRarityDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "stage_loot_rarity_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags StageLootRarityDescFlags;
        public void StageLootRarityDesc(CallReducerFlags flags) => StageLootRarityDescFlags = flags;
    }
}
