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
        public delegate void StageTerraformRecipeDescHandler(ReducerEventContext ctx, System.Collections.Generic.List<TerraformRecipeDesc> records);
        public event StageTerraformRecipeDescHandler? OnStageTerraformRecipeDesc;

        public void StageTerraformRecipeDesc(System.Collections.Generic.List<TerraformRecipeDesc> records)
        {
            conn.InternalCallReducer(new Reducer.StageTerraformRecipeDesc(records), this.SetCallReducerFlags.StageTerraformRecipeDescFlags);
        }

        public bool InvokeStageTerraformRecipeDesc(ReducerEventContext ctx, Reducer.StageTerraformRecipeDesc args)
        {
            if (OnStageTerraformRecipeDesc == null)
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
            OnStageTerraformRecipeDesc(
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
        public sealed partial class StageTerraformRecipeDesc : Reducer, IReducerArgs
        {
            [DataMember(Name = "records")]
            public System.Collections.Generic.List<TerraformRecipeDesc> Records;

            public StageTerraformRecipeDesc(System.Collections.Generic.List<TerraformRecipeDesc> Records)
            {
                this.Records = Records;
            }

            public StageTerraformRecipeDesc()
            {
                this.Records = new();
            }

            string IReducerArgs.ReducerName => "stage_terraform_recipe_desc";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags StageTerraformRecipeDescFlags;
        public void StageTerraformRecipeDesc(CallReducerFlags flags) => StageTerraformRecipeDescFlags = flags;
    }
}
