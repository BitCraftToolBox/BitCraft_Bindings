// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

// This was generated using spacetimedb cli version 1.2.0 (commit dev).

/* eslint-disable */
/* tslint:disable */
// @ts-nocheck
import {
  AlgebraicType,
  AlgebraicValue,
  BinaryReader,
  BinaryWriter,
  ConnectionId,
  DbConnectionBuilder,
  DbConnectionImpl,
  Identity,
  ProductType,
  ProductTypeElement,
  SubscriptionBuilderImpl,
  SumType,
  SumTypeVariant,
  TableCache,
  TimeDuration,
  Timestamp,
  deepEqual,
  type CallReducerFlags,
  type DbContext,
  type ErrorContextInterface,
  type Event,
  type EventContextInterface,
  type ReducerEventContextInterface,
  type SubscriptionEventContextInterface,
} from "@clockworklabs/spacetimedb-sdk";
import { NpcAiLoopTimer } from "./npc_ai_loop_timer_type";
import { type EventContext, type Reducer, RemoteReducers, RemoteTables } from ".";

/**
 * Table handle for the table `npc_ai_loop_timer`.
 *
 * Obtain a handle from the [`npcAiLoopTimer`] property on [`RemoteTables`],
 * like `ctx.db.npcAiLoopTimer`.
 *
 * Users are encouraged not to explicitly reference this type,
 * but to directly chain method calls,
 * like `ctx.db.npcAiLoopTimer.on_insert(...)`.
 */
export class NpcAiLoopTimerTableHandle {
  tableCache: TableCache<NpcAiLoopTimer>;

  constructor(tableCache: TableCache<NpcAiLoopTimer>) {
    this.tableCache = tableCache;
  }

  count(): number {
    return this.tableCache.count();
  }

  iter(): Iterable<NpcAiLoopTimer> {
    return this.tableCache.iter();
  }
  /**
   * Access to the `scheduledId` unique index on the table `npc_ai_loop_timer`,
   * which allows point queries on the field of the same name
   * via the [`NpcAiLoopTimerScheduledIdUnique.find`] method.
   *
   * Users are encouraged not to explicitly reference this type,
   * but to directly chain method calls,
   * like `ctx.db.npcAiLoopTimer.scheduledId().find(...)`.
   *
   * Get a handle on the `scheduledId` unique index on the table `npc_ai_loop_timer`.
   */
  scheduledId = {
    // Find the subscribed row whose `scheduledId` column value is equal to `col_val`,
    // if such a row is present in the client cache.
    find: (col_val: bigint): NpcAiLoopTimer | undefined => {
      for (let row of this.tableCache.iter()) {
        if (deepEqual(row.scheduledId, col_val)) {
          return row;
        }
      }
    },
  };

  onInsert = (cb: (ctx: EventContext, row: NpcAiLoopTimer) => void) => {
    return this.tableCache.onInsert(cb);
  }

  removeOnInsert = (cb: (ctx: EventContext, row: NpcAiLoopTimer) => void) => {
    return this.tableCache.removeOnInsert(cb);
  }

  onDelete = (cb: (ctx: EventContext, row: NpcAiLoopTimer) => void) => {
    return this.tableCache.onDelete(cb);
  }

  removeOnDelete = (cb: (ctx: EventContext, row: NpcAiLoopTimer) => void) => {
    return this.tableCache.removeOnDelete(cb);
  }

  // Updates are only defined for tables with primary keys.
  onUpdate = (cb: (ctx: EventContext, oldRow: NpcAiLoopTimer, newRow: NpcAiLoopTimer) => void) => {
    return this.tableCache.onUpdate(cb);
  }

  removeOnUpdate = (cb: (ctx: EventContext, onRow: NpcAiLoopTimer, newRow: NpcAiLoopTimer) => void) => {
    return this.tableCache.removeOnUpdate(cb);
  }}
