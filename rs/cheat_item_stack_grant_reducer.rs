// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

// This was generated using spacetimedb cli version 1.2.0 (commit dev).

#![allow(unused, clippy::all)]
use spacetimedb_sdk::__codegen::{self as __sdk, __lib, __sats, __ws};

#[derive(__lib::ser::Serialize, __lib::de::Deserialize, Clone, PartialEq, Debug)]
#[sats(crate = __lib)]
pub(super) struct CheatItemStackGrantArgs {
    pub player_entity_id: u64,
    pub item_id: i32,
    pub quantity: i32,
    pub is_cargo: bool,
}

impl From<CheatItemStackGrantArgs> for super::Reducer {
    fn from(args: CheatItemStackGrantArgs) -> Self {
        Self::CheatItemStackGrant {
            player_entity_id: args.player_entity_id,
            item_id: args.item_id,
            quantity: args.quantity,
            is_cargo: args.is_cargo,
        }
    }
}

impl __sdk::InModule for CheatItemStackGrantArgs {
    type Module = super::RemoteModule;
}

pub struct CheatItemStackGrantCallbackId(__sdk::CallbackId);

#[allow(non_camel_case_types)]
/// Extension trait for access to the reducer `cheat_item_stack_grant`.
///
/// Implemented for [`super::RemoteReducers`].
pub trait cheat_item_stack_grant {
    /// Request that the remote module invoke the reducer `cheat_item_stack_grant` to run as soon as possible.
    ///
    /// This method returns immediately, and errors only if we are unable to send the request.
    /// The reducer will run asynchronously in the future,
    ///  and its status can be observed by listening for [`Self::on_cheat_item_stack_grant`] callbacks.
    fn cheat_item_stack_grant(
        &self,
        player_entity_id: u64,
        item_id: i32,
        quantity: i32,
        is_cargo: bool,
    ) -> __sdk::Result<()>;
    /// Register a callback to run whenever we are notified of an invocation of the reducer `cheat_item_stack_grant`.
    ///
    /// Callbacks should inspect the [`__sdk::ReducerEvent`] contained in the [`super::ReducerEventContext`]
    /// to determine the reducer's status.
    ///
    /// The returned [`CheatItemStackGrantCallbackId`] can be passed to [`Self::remove_on_cheat_item_stack_grant`]
    /// to cancel the callback.
    fn on_cheat_item_stack_grant(
        &self,
        callback: impl FnMut(&super::ReducerEventContext, &u64, &i32, &i32, &bool) + Send + 'static,
    ) -> CheatItemStackGrantCallbackId;
    /// Cancel a callback previously registered by [`Self::on_cheat_item_stack_grant`],
    /// causing it not to run in the future.
    fn remove_on_cheat_item_stack_grant(&self, callback: CheatItemStackGrantCallbackId);
}

impl cheat_item_stack_grant for super::RemoteReducers {
    fn cheat_item_stack_grant(
        &self,
        player_entity_id: u64,
        item_id: i32,
        quantity: i32,
        is_cargo: bool,
    ) -> __sdk::Result<()> {
        self.imp.call_reducer(
            "cheat_item_stack_grant",
            CheatItemStackGrantArgs {
                player_entity_id,
                item_id,
                quantity,
                is_cargo,
            },
        )
    }
    fn on_cheat_item_stack_grant(
        &self,
        mut callback: impl FnMut(&super::ReducerEventContext, &u64, &i32, &i32, &bool) + Send + 'static,
    ) -> CheatItemStackGrantCallbackId {
        CheatItemStackGrantCallbackId(self.imp.on_reducer(
            "cheat_item_stack_grant",
            Box::new(move |ctx: &super::ReducerEventContext| {
                let super::ReducerEventContext {
                    event:
                        __sdk::ReducerEvent {
                            reducer:
                                super::Reducer::CheatItemStackGrant {
                                    player_entity_id,
                                    item_id,
                                    quantity,
                                    is_cargo,
                                },
                            ..
                        },
                    ..
                } = ctx
                else {
                    unreachable!()
                };
                callback(ctx, player_entity_id, item_id, quantity, is_cargo)
            }),
        ))
    }
    fn remove_on_cheat_item_stack_grant(&self, callback: CheatItemStackGrantCallbackId) {
        self.imp
            .remove_on_reducer("cheat_item_stack_grant", callback.0)
    }
}

#[allow(non_camel_case_types)]
#[doc(hidden)]
/// Extension trait for setting the call-flags for the reducer `cheat_item_stack_grant`.
///
/// Implemented for [`super::SetReducerFlags`].
///
/// This type is currently unstable and may be removed without a major version bump.
pub trait set_flags_for_cheat_item_stack_grant {
    /// Set the call-reducer flags for the reducer `cheat_item_stack_grant` to `flags`.
    ///
    /// This type is currently unstable and may be removed without a major version bump.
    fn cheat_item_stack_grant(&self, flags: __ws::CallReducerFlags);
}

impl set_flags_for_cheat_item_stack_grant for super::SetReducerFlags {
    fn cheat_item_stack_grant(&self, flags: __ws::CallReducerFlags) {
        self.imp
            .set_call_reducer_flags("cheat_item_stack_grant", flags);
    }
}
