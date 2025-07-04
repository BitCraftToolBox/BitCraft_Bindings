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
export type ClaimMemberState = {
  entityId: bigint,
  claimEntityId: bigint,
  playerEntityId: bigint,
  userName: string,
  inventoryPermission: boolean,
  buildPermission: boolean,
  officerPermission: boolean,
  coOwnerPermission: boolean,
};

/**
 * A namespace for generated helper functions.
 */
export namespace ClaimMemberState {
  /**
  * A function which returns this type represented as an AlgebraicType.
  * This function is derived from the AlgebraicType used to generate this type.
  */
  export function getTypeScriptAlgebraicType(): AlgebraicType {
    return AlgebraicType.createProductType([
      new ProductTypeElement("entityId", AlgebraicType.createU64Type()),
      new ProductTypeElement("claimEntityId", AlgebraicType.createU64Type()),
      new ProductTypeElement("playerEntityId", AlgebraicType.createU64Type()),
      new ProductTypeElement("userName", AlgebraicType.createStringType()),
      new ProductTypeElement("inventoryPermission", AlgebraicType.createBoolType()),
      new ProductTypeElement("buildPermission", AlgebraicType.createBoolType()),
      new ProductTypeElement("officerPermission", AlgebraicType.createBoolType()),
      new ProductTypeElement("coOwnerPermission", AlgebraicType.createBoolType()),
    ]);
  }

  export function serialize(writer: BinaryWriter, value: ClaimMemberState): void {
    ClaimMemberState.getTypeScriptAlgebraicType().serialize(writer, value);
  }

  export function deserialize(reader: BinaryReader): ClaimMemberState {
    return ClaimMemberState.getTypeScriptAlgebraicType().deserialize(reader);
  }

}


