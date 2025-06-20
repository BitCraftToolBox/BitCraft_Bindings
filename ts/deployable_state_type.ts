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
export type DeployableState = {
  entityId: bigint,
  ownerId: bigint,
  claimEntityId: bigint,
  direction: number,
  deployableDescriptionId: number,
  nickname: string,
  hidden: boolean,
};

/**
 * A namespace for generated helper functions.
 */
export namespace DeployableState {
  /**
  * A function which returns this type represented as an AlgebraicType.
  * This function is derived from the AlgebraicType used to generate this type.
  */
  export function getTypeScriptAlgebraicType(): AlgebraicType {
    return AlgebraicType.createProductType([
      new ProductTypeElement("entityId", AlgebraicType.createU64Type()),
      new ProductTypeElement("ownerId", AlgebraicType.createU64Type()),
      new ProductTypeElement("claimEntityId", AlgebraicType.createU64Type()),
      new ProductTypeElement("direction", AlgebraicType.createI32Type()),
      new ProductTypeElement("deployableDescriptionId", AlgebraicType.createI32Type()),
      new ProductTypeElement("nickname", AlgebraicType.createStringType()),
      new ProductTypeElement("hidden", AlgebraicType.createBoolType()),
    ]);
  }

  export function serialize(writer: BinaryWriter, value: DeployableState): void {
    DeployableState.getTypeScriptAlgebraicType().serialize(writer, value);
  }

  export function deserialize(reader: BinaryReader): DeployableState {
    return DeployableState.getTypeScriptAlgebraicType().deserialize(reader);
  }

}


