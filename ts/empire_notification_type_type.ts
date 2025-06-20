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
// A namespace for generated variants and helper functions.
export namespace EmpireNotificationType {
  // These are the generated variant types for each variant of the tagged union.
  // One type is generated per variant and will be used in the `value` field of
  // the tagged union.
  export type None = { tag: "None" };
  export type NewMember = { tag: "NewMember" };
  export type MarkedForSiege = { tag: "MarkedForSiege" };
  export type StartedSiege = { tag: "StartedSiege" };
  export type StartedDefense = { tag: "StartedDefense" };
  export type SuccessfulSiege = { tag: "SuccessfulSiege" };
  export type SuccessfulDefense = { tag: "SuccessfulDefense" };
  export type FailedSiege = { tag: "FailedSiege" };
  export type FailedDefense = { tag: "FailedDefense" };
  export type MemberLeft = { tag: "MemberLeft" };
  export type WatchtowerBuilt = { tag: "WatchtowerBuilt" };
  export type ClaimJoined = { tag: "ClaimJoined" };
  export type ClaimLeft = { tag: "ClaimLeft" };
  export type Donation = { tag: "Donation" };
  export type DonationByProxy = { tag: "DonationByProxy" };

  // Helper functions for constructing each variant of the tagged union.
  // ```
  // const foo = Foo.A(42);
  // assert!(foo.tag === "A");
  // assert!(foo.value === 42);
  // ```
  export const None = { tag: "None" };
  export const NewMember = { tag: "NewMember" };
  export const MarkedForSiege = { tag: "MarkedForSiege" };
  export const StartedSiege = { tag: "StartedSiege" };
  export const StartedDefense = { tag: "StartedDefense" };
  export const SuccessfulSiege = { tag: "SuccessfulSiege" };
  export const SuccessfulDefense = { tag: "SuccessfulDefense" };
  export const FailedSiege = { tag: "FailedSiege" };
  export const FailedDefense = { tag: "FailedDefense" };
  export const MemberLeft = { tag: "MemberLeft" };
  export const WatchtowerBuilt = { tag: "WatchtowerBuilt" };
  export const ClaimJoined = { tag: "ClaimJoined" };
  export const ClaimLeft = { tag: "ClaimLeft" };
  export const Donation = { tag: "Donation" };
  export const DonationByProxy = { tag: "DonationByProxy" };

  export function getTypeScriptAlgebraicType(): AlgebraicType {
    return AlgebraicType.createSumType([
      new SumTypeVariant("None", AlgebraicType.createProductType([])),
      new SumTypeVariant("NewMember", AlgebraicType.createProductType([])),
      new SumTypeVariant("MarkedForSiege", AlgebraicType.createProductType([])),
      new SumTypeVariant("StartedSiege", AlgebraicType.createProductType([])),
      new SumTypeVariant("StartedDefense", AlgebraicType.createProductType([])),
      new SumTypeVariant("SuccessfulSiege", AlgebraicType.createProductType([])),
      new SumTypeVariant("SuccessfulDefense", AlgebraicType.createProductType([])),
      new SumTypeVariant("FailedSiege", AlgebraicType.createProductType([])),
      new SumTypeVariant("FailedDefense", AlgebraicType.createProductType([])),
      new SumTypeVariant("MemberLeft", AlgebraicType.createProductType([])),
      new SumTypeVariant("WatchtowerBuilt", AlgebraicType.createProductType([])),
      new SumTypeVariant("ClaimJoined", AlgebraicType.createProductType([])),
      new SumTypeVariant("ClaimLeft", AlgebraicType.createProductType([])),
      new SumTypeVariant("Donation", AlgebraicType.createProductType([])),
      new SumTypeVariant("DonationByProxy", AlgebraicType.createProductType([])),
    ]);
  }

  export function serialize(writer: BinaryWriter, value: EmpireNotificationType): void {
      EmpireNotificationType.getTypeScriptAlgebraicType().serialize(writer, value);
  }

  export function deserialize(reader: BinaryReader): EmpireNotificationType {
      return EmpireNotificationType.getTypeScriptAlgebraicType().deserialize(reader);
  }

}

// The tagged union or sum type for the algebraic type `EmpireNotificationType`.
export type EmpireNotificationType = EmpireNotificationType.None | EmpireNotificationType.NewMember | EmpireNotificationType.MarkedForSiege | EmpireNotificationType.StartedSiege | EmpireNotificationType.StartedDefense | EmpireNotificationType.SuccessfulSiege | EmpireNotificationType.SuccessfulDefense | EmpireNotificationType.FailedSiege | EmpireNotificationType.FailedDefense | EmpireNotificationType.MemberLeft | EmpireNotificationType.WatchtowerBuilt | EmpireNotificationType.ClaimJoined | EmpireNotificationType.ClaimLeft | EmpireNotificationType.Donation | EmpireNotificationType.DonationByProxy;

export default EmpireNotificationType;

