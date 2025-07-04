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
        public delegate void SleepHandler(ReducerEventContext ctx, PlayerSleepRequest request);
        public event SleepHandler? OnSleep;

        public void Sleep(PlayerSleepRequest request)
        {
            conn.InternalCallReducer(new Reducer.Sleep(request), this.SetCallReducerFlags.SleepFlags);
        }

        public bool InvokeSleep(ReducerEventContext ctx, Reducer.Sleep args)
        {
            if (OnSleep == null)
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
            OnSleep(
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
        public sealed partial class Sleep : Reducer, IReducerArgs
        {
            [DataMember(Name = "_request")]
            public PlayerSleepRequest Request;

            public Sleep(PlayerSleepRequest Request)
            {
                this.Request = Request;
            }

            public Sleep()
            {
                this.Request = new();
            }

            string IReducerArgs.ReducerName => "sleep";
        }
    }

    public sealed partial class SetReducerFlags
    {
        internal CallReducerFlags SleepFlags;
        public void Sleep(CallReducerFlags flags) => SleepFlags = flags;
    }
}
