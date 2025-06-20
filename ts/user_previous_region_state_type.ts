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
import { FloatHexTileMessage as __FloatHexTileMessage } from "./float_hex_tile_message_type";

export type UserPreviousRegionState = {
  identity: Identity,
  previousRegionLocation: __FloatHexTileMessage,
  withVehicle: boolean,
  allowCancel: boolean,
  teleportEnergyCost: number,
};

/**
 * A namespace for generated helper functions.
 */
export namespace UserPreviousRegionState {
  /**
  * A function which returns this type represented as an AlgebraicType.
  * This function is derived from the AlgebraicType used to generate this type.
  */
  export function getTypeScriptAlgebraicType(): AlgebraicType {
    return AlgebraicType.createProductType([
      new ProductTypeElement("identity", AlgebraicType.createIdentityType()),
      new ProductTypeElement("previousRegionLocation", __FloatHexTileMessage.getTypeScriptAlgebraicType()),
      new ProductTypeElement("withVehicle", AlgebraicType.createBoolType()),
      new ProductTypeElement("allowCancel", AlgebraicType.createBoolType()),
      new ProductTypeElement("teleportEnergyCost", AlgebraicType.createF32Type()),
    ]);
  }

  export function serialize(writer: BinaryWriter, value: UserPreviousRegionState): void {
    UserPreviousRegionState.getTypeScriptAlgebraicType().serialize(writer, value);
  }

  export function deserialize(reader: BinaryReader): UserPreviousRegionState {
    return UserPreviousRegionState.getTypeScriptAlgebraicType().deserialize(reader);
  }

}


