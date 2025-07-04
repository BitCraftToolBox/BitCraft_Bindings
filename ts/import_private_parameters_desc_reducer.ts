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

import { PrivateParametersDesc as __PrivateParametersDesc } from "./private_parameters_desc_type";

export type ImportPrivateParametersDesc = {
  records: __PrivateParametersDesc[],
};

/**
 * A namespace for generated helper functions.
 */
export namespace ImportPrivateParametersDesc {
  /**
  * A function which returns this type represented as an AlgebraicType.
  * This function is derived from the AlgebraicType used to generate this type.
  */
  export function getTypeScriptAlgebraicType(): AlgebraicType {
    return AlgebraicType.createProductType([
      new ProductTypeElement("records", AlgebraicType.createArrayType(__PrivateParametersDesc.getTypeScriptAlgebraicType())),
    ]);
  }

  export function serialize(writer: BinaryWriter, value: ImportPrivateParametersDesc): void {
    ImportPrivateParametersDesc.getTypeScriptAlgebraicType().serialize(writer, value);
  }

  export function deserialize(reader: BinaryReader): ImportPrivateParametersDesc {
    return ImportPrivateParametersDesc.getTypeScriptAlgebraicType().deserialize(reader);
  }

}

