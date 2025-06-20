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
import { WorldGenVector2Int as __WorldGenVector2Int } from "./world_gen_vector_2_int_type";

export type WorldGenResourceDetails = {
  clumpId: number,
  spawnsOnLand: boolean,
  landElevationRange: __WorldGenVector2Int,
  spawnsInWater: boolean,
  waterDepthRange: __WorldGenVector2Int,
  spawnsOnUnevenTerrain: boolean,
};

/**
 * A namespace for generated helper functions.
 */
export namespace WorldGenResourceDetails {
  /**
  * A function which returns this type represented as an AlgebraicType.
  * This function is derived from the AlgebraicType used to generate this type.
  */
  export function getTypeScriptAlgebraicType(): AlgebraicType {
    return AlgebraicType.createProductType([
      new ProductTypeElement("clumpId", AlgebraicType.createI32Type()),
      new ProductTypeElement("spawnsOnLand", AlgebraicType.createBoolType()),
      new ProductTypeElement("landElevationRange", __WorldGenVector2Int.getTypeScriptAlgebraicType()),
      new ProductTypeElement("spawnsInWater", AlgebraicType.createBoolType()),
      new ProductTypeElement("waterDepthRange", __WorldGenVector2Int.getTypeScriptAlgebraicType()),
      new ProductTypeElement("spawnsOnUnevenTerrain", AlgebraicType.createBoolType()),
    ]);
  }

  export function serialize(writer: BinaryWriter, value: WorldGenResourceDetails): void {
    WorldGenResourceDetails.getTypeScriptAlgebraicType().serialize(writer, value);
  }

  export function deserialize(reader: BinaryReader): WorldGenResourceDetails {
    return WorldGenResourceDetails.getTypeScriptAlgebraicType().deserialize(reader);
  }

}


