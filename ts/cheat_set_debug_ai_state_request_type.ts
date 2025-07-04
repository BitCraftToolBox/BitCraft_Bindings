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
import { OffsetCoordinatesFloat as __OffsetCoordinatesFloat } from "./offset_coordinates_float_type";

export type CheatSetDebugAiStateRequest = {
  entityId: bigint,
  targetEntityId: bigint,
  targetPosition: __OffsetCoordinatesFloat,
  currentPosition: __OffsetCoordinatesFloat,
  currentDestination: __OffsetCoordinatesFloat,
  dp: number,
};

/**
 * A namespace for generated helper functions.
 */
export namespace CheatSetDebugAiStateRequest {
  /**
  * A function which returns this type represented as an AlgebraicType.
  * This function is derived from the AlgebraicType used to generate this type.
  */
  export function getTypeScriptAlgebraicType(): AlgebraicType {
    return AlgebraicType.createProductType([
      new ProductTypeElement("entityId", AlgebraicType.createU64Type()),
      new ProductTypeElement("targetEntityId", AlgebraicType.createU64Type()),
      new ProductTypeElement("targetPosition", __OffsetCoordinatesFloat.getTypeScriptAlgebraicType()),
      new ProductTypeElement("currentPosition", __OffsetCoordinatesFloat.getTypeScriptAlgebraicType()),
      new ProductTypeElement("currentDestination", __OffsetCoordinatesFloat.getTypeScriptAlgebraicType()),
      new ProductTypeElement("dp", AlgebraicType.createF32Type()),
    ]);
  }

  export function serialize(writer: BinaryWriter, value: CheatSetDebugAiStateRequest): void {
    CheatSetDebugAiStateRequest.getTypeScriptAlgebraicType().serialize(writer, value);
  }

  export function deserialize(reader: BinaryReader): CheatSetDebugAiStateRequest {
    return CheatSetDebugAiStateRequest.getTypeScriptAlgebraicType().deserialize(reader);
  }

}


