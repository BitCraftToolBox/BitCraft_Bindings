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
        public delegate void ImportConstructionRecipeDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<ConstructionRecipeDesc> records);
        public event ImportConstructionRecipeDescHandler? OnImportConstructionRecipeDesc;

        public void ImportConstructionRecipeDesc(System.Collections.Generic.List<ConstructionRecipeDesc> records)
        {
            conn.InternalCallReducer(new Reducer.ImportConstructionRecipeDesc(records), this.SetCallReducerFlags.ImportConstructionRecipeDescFlags);
        }

        public bool InvokeImportConstructionRecipeDesc(ReducerEventContext ctx, Reducer.ImportConstructionRecipeDesc args)
        {
            if (OnImportConstructionRecipeDesc == null)
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
            OnImportConstructionRecipeDesc(
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
        public sealed partial class ImportConstructionRecipeDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<ConstructionRecipeDesc> Records;

            public ImportConstructionRecipeDesc(System.Collections.Generic.List<ConstructionRecipeDesc> Records)
            {
                this.Records = Records;
            }

            public ImportConstructionRecipeDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "import_construction_recipe_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ImportConstructionRecipeDescFlags;
        public void ImportConstructionRecipeDesc(CallReducerFlags flags) => ImportConstructionRecipeDescFlags = flags;
    }
}
