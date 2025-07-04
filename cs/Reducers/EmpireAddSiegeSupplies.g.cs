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
        public delegate void EmpireAddSiegeSuppliesHandler(ReducerEventContext ctx, EmpireAddSiegeSuppliesRequest request);
        public event EmpireAddSiegeSuppliesHandler? OnEmpireAddSiegeSupplies;

        public void EmpireAddSiegeSupplies(EmpireAddSiegeSuppliesRequest request)
        {
            conn.InternalCallReducer(new Reducer.EmpireAddSiegeSupplies(request), this.SetCallReducerFlags.EmpireAddSiegeSuppliesFlags);
        }

        public bool InvokeEmpireAddSiegeSupplies(ReducerEventContext ctx, Reducer.EmpireAddSiegeSupplies args)
        {
            if (OnEmpireAddSiegeSupplies == null)
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
            OnEmpireAddSiegeSupplies(
                ctx,
                args.Request
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class EmpireAddSiegeSupplies : Reducer, IReducerArgs
        {
            [DataMember(Name = "request")]
            public EmpireAddSiegeSuppliesRequest Request;

            public EmpireAddSiegeSupplies(EmpireAddSiegeSuppliesRequest Request)
            {
                this.Request = Request;
            }

            public EmpireAddSiegeSupplies()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "empire_add_siege_supplies";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags EmpireAddSiegeSuppliesFlags;
        public void EmpireAddSiegeSupplies(CallReducerFlags flags) => EmpireAddSiegeSuppliesFlags = flags;
    }
}
