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
        public delegate void ImportResourceGrowthRecipeDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<ResourceGrowthRecipeDesc> records);
        public event ImportResourceGrowthRecipeDescHandler? OnImportResourceGrowthRecipeDesc;

        public void ImportResourceGrowthRecipeDesc(System.Collections.Generic.List<ResourceGrowthRecipeDesc> records)
        {
            conn.InternalCallReducer(new Reducer.ImportResourceGrowthRecipeDesc(records), this.SetCallReducerFlags.ImportResourceGrowthRecipeDescFlags);
        }

        public bool InvokeImportResourceGrowthRecipeDesc(ReducerEventContext ctx, Reducer.ImportResourceGrowthRecipeDesc args)
        {
            if (OnImportResourceGrowthRecipeDesc == null)
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
            OnImportResourceGrowthRecipeDesc(
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
        public sealed partial class ImportResourceGrowthRecipeDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<ResourceGrowthRecipeDesc> Records;

            public ImportResourceGrowthRecipeDesc(System.Collections.Generic.List<ResourceGrowthRecipeDesc> Records)
            {
                this.Records = Records;
            }

            public ImportResourceGrowthRecipeDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "import_resource_growth_recipe_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags ImportResourceGrowthRecipeDescFlags;
        public void ImportResourceGrowthRecipeDesc(CallReducerFlags flags) => ImportResourceGrowthRecipeDescFlags = flags;
    }
}
