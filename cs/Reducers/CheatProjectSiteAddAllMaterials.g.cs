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
        public delegate void CheatProjectSiteAddAllMaterialsHandler(ReducerEventContext ctx, ulong projectSiteEntityId);
        public event CheatProjectSiteAddAllMaterialsHandler? OnCheatProjectSiteAddAllMaterials;

        public void CheatProjectSiteAddAllMaterials(ulong projectSiteEntityId)
        {
            conn.InternalCallReducer(new Reducer.CheatProjectSiteAddAllMaterials(projectSiteEntityId), this.SetCallReducerFlags.CheatProjectSiteAddAllMaterialsFlags);
        }

        public bool InvokeCheatProjectSiteAddAllMaterials(ReducerEventContext ctx, Reducer.CheatProjectSiteAddAllMaterials args)
        {
            if (OnCheatProjectSiteAddAllMaterials == null)
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
            OnCheatProjectSiteAddAllMaterials(
                ctx,
                args.ProjectSiteEntityId
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class CheatProjectSiteAddAllMaterials : Reducer, IReducerArgs
        {
            [DataMember(Name = "project_site_entity_id")]
            public ulong ProjectSiteEntityId;

            public CheatProjectSiteAddAllMaterials(ulong ProjectSiteEntityId)
            {
                this.ProjectSiteEntityId = ProjectSiteEntityId;
            }

            public CheatProjectSiteAddAllMaterials()
            {
            }

            string IReducerArgs.ReducerName => "cheat_project_site_add_all_materials";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags CheatProjectSiteAddAllMaterialsFlags;
        public void CheatProjectSiteAddAllMaterials(CallReducerFlags flags) => CheatProjectSiteAddAllMaterialsFlags = flags;
    }
}
