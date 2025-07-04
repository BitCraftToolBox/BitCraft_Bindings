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
import { ItemStack as __ItemStack } from "./item_stack_type";
import { LevelRequirement as __LevelRequirement } from "./level_requirement_type";
import { ToolRequirement as __ToolRequirement } from "./tool_requirement_type";
import { InputItemStack as __InputItemStack } from "./input_item_stack_type";
import { ExperienceStackF32 as __ExperienceStackF32 } from "./experience_stack_f_32_type";
import { BuildingRequirement as __BuildingRequirement } from "./building_requirement_type";

export type CraftingRecipeDesc = {
  id: number,
  name: string,
  timeRequirement: number,
  staminaRequirement: number,
  toolDurabilityLost: number,
  buildingRequirement: __BuildingRequirement | undefined,
  levelRequirements: __LevelRequirement[],
  toolRequirements: __ToolRequirement[],
  consumedItemStacks: __InputItemStack[],
  discoveryTriggers: number[],
  requiredClaimTechId: number,
  fullDiscoveryScore: number,
  experiencePerProgress: __ExperienceStackF32[],
  craftedItemStacks: __ItemStack[],
  actionsRequired: number,
  toolMeshIndex: number,
  recipePerformanceId: number,
  requiredKnowledges: number[],
  blockingKnowledges: number[],
  hideWithoutRequiredKnowledge: boolean,
  hideWithBlockingKnowledges: boolean,
  allowUseHands: boolean,
  isPassive: boolean,
};

/**
 * A namespace for generated helper functions.
 */
export namespace CraftingRecipeDesc {
  /**
  * A function which returns this type represented as an AlgebraicType.
  * This function is derived from the AlgebraicType used to generate this type.
  */
  export function getTypeScriptAlgebraicType(): AlgebraicType {
    return AlgebraicType.createProductType([
      new ProductTypeElement("id", AlgebraicType.createI32Type()),
      new ProductTypeElement("name", AlgebraicType.createStringType()),
      new ProductTypeElement("timeRequirement", AlgebraicType.createF32Type()),
      new ProductTypeElement("staminaRequirement", AlgebraicType.createF32Type()),
      new ProductTypeElement("toolDurabilityLost", AlgebraicType.createI32Type()),
      new ProductTypeElement("buildingRequirement", AlgebraicType.createOptionType(__BuildingRequirement.getTypeScriptAlgebraicType())),
      new ProductTypeElement("levelRequirements", AlgebraicType.createArrayType(__LevelRequirement.getTypeScriptAlgebraicType())),
      new ProductTypeElement("toolRequirements", AlgebraicType.createArrayType(__ToolRequirement.getTypeScriptAlgebraicType())),
      new ProductTypeElement("consumedItemStacks", AlgebraicType.createArrayType(__InputItemStack.getTypeScriptAlgebraicType())),
      new ProductTypeElement("discoveryTriggers", AlgebraicType.createArrayType(AlgebraicType.createI32Type())),
      new ProductTypeElement("requiredClaimTechId", AlgebraicType.createI32Type()),
      new ProductTypeElement("fullDiscoveryScore", AlgebraicType.createI32Type()),
      new ProductTypeElement("experiencePerProgress", AlgebraicType.createArrayType(__ExperienceStackF32.getTypeScriptAlgebraicType())),
      new ProductTypeElement("craftedItemStacks", AlgebraicType.createArrayType(__ItemStack.getTypeScriptAlgebraicType())),
      new ProductTypeElement("actionsRequired", AlgebraicType.createI32Type()),
      new ProductTypeElement("toolMeshIndex", AlgebraicType.createI32Type()),
      new ProductTypeElement("recipePerformanceId", AlgebraicType.createI32Type()),
      new ProductTypeElement("requiredKnowledges", AlgebraicType.createArrayType(AlgebraicType.createI32Type())),
      new ProductTypeElement("blockingKnowledges", AlgebraicType.createArrayType(AlgebraicType.createI32Type())),
      new ProductTypeElement("hideWithoutRequiredKnowledge", AlgebraicType.createBoolType()),
      new ProductTypeElement("hideWithBlockingKnowledges", AlgebraicType.createBoolType()),
      new ProductTypeElement("allowUseHands", AlgebraicType.createBoolType()),
      new ProductTypeElement("isPassive", AlgebraicType.createBoolType()),
    ]);
  }

  export function serialize(writer: BinaryWriter, value: CraftingRecipeDesc): void {
    CraftingRecipeDesc.getTypeScriptAlgebraicType().serialize(writer, value);
  }

  export function deserialize(reader: BinaryReader): CraftingRecipeDesc {
    return CraftingRecipeDesc.getTypeScriptAlgebraicType().deserialize(reader);
  }

}


