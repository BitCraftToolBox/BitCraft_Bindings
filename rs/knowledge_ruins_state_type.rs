// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

// This was generated using spacetimedb cli version 1.2.0 (commit dev).

#![allow(unused, clippy::all)]
use spacetimedb_sdk::__codegen::{self as __sdk, __lib, __sats, __ws};

use super::knowledge_location_entry_type::KnowledgeLocationEntry;

#[derive(__lib::ser::Serialize, __lib::de::Deserialize, Clone, PartialEq, Debug)]
#[sats(crate = __lib)]
pub struct KnowledgeRuinsState {
    pub entity_id: u64,
    pub entries: Vec<KnowledgeLocationEntry>,
}

impl __sdk::InModule for KnowledgeRuinsState {
    type Module = super::RemoteModule;
}
