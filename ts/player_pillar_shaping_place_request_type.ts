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
import { OffsetCoordinatesLargeMessage as __OffsetCoordinatesLargeMessage } from "./offset_coordinates_large_message_type";

export type PlayerPillarShapingPlaceRequest = {
  coordinates: __OffsetCoordinatesLargeMessage,
  pillarTypeId: number,
  timestamp: bigint,
};

/**
 * A namespace for generated helper functions.
 */
export namespace PlayerPillarShapingPlaceRequest {
  /**
  * A function which returns this type represented as an AlgebraicType.
  * This function is derived from the AlgebraicType used to generate this type.
  */
  export function getTypeScriptAlgebraicType(): AlgebraicType {
    return AlgebraicType.createProductType([
      new ProductTypeElement("coordinates", __OffsetCoordinatesLargeMessage.getTypeScriptAlgebraicType()),
      new ProductTypeElement("pillarTypeId", AlgebraicType.createI32Type()),
      new ProductTypeElement("timestamp", AlgebraicType.createU64Type()),
    ]);
  }

  export function serialize(writer: BinaryWriter, value: PlayerPillarShapingPlaceRequest): void {
    PlayerPillarShapingPlaceRequest.getTypeScriptAlgebraicType().serialize(writer, value);
  }

  export function deserialize(reader: BinaryReader): PlayerPillarShapingPlaceRequest {
    return PlayerPillarShapingPlaceRequest.getTypeScriptAlgebraicType().deserialize(reader);
  }

}


