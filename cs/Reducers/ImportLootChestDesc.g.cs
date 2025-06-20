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
        public delegate void ImportLootChestDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<LootChestDesc> records);
        public event ImportLootChestDescHandler? OnImportLootChestDesc;

        public void ImportLootChestDesc(System.Collections.Generic.List<LootChestDesc> records)
        {
            conn.InternalCallReducer(new Reducer.ImportLootChestDesc(records), this.SetCallReducerFlags.ImportLootChestDescFlags);
        }

        public bool InvokeImportLootChestDesc(ReducerEventContext ctx, Reducer.ImportLootChestDesc args)
        {
            if (OnImportLootChestDesc == null)
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
            OnImportLootChestDesc(
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
        public sealed partial class ImportLootChestDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<LootChestDesc> Records;

            public ImportLootChestDesc(System.Collections.Generic.List<LootChestDesc> Records)
            {
                this.Records = Records;
            }

            public ImportLootChestDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "import_loot_chest_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ImportLootChestDescFlags;
        public void ImportLootChestDesc(CallReducerFlags flags) => ImportLootChestDescFlags = flags;
    }
}
