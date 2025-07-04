// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

// This was generated using spacetimedb cli version 1.2.0 (commit dev).

#nullable enable

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
    [SpacetimeDB.Type]
    [DataContract]
    public sealed partial class InterModuleTableUpdates
    {
        [DataMember(Name = "blocked_identity")]
        public System.Collections.Generic.List<BlockedIdentityOp>? BlockedIdentity;
        [DataMember(Name = "building_nickname_state")]
        public System.Collections.Generic.List<BuildingNicknameStateOp>? BuildingNicknameState;
        [DataMember(Name = "building_state")]
        public System.Collections.Generic.List<BuildingStateOp>? BuildingState;
        [DataMember(Name = "claim_member_state")]
        public System.Collections.Generic.List<ClaimMemberStateOp>? ClaimMemberState;
        [DataMember(Name = "claim_state")]
        public System.Collections.Generic.List<ClaimStateOp>? ClaimState;
        [DataMember(Name = "empire_chunk_state")]
        public System.Collections.Generic.List<EmpireChunkStateOp>? EmpireChunkState;
        [DataMember(Name = "empire_expansion_state")]
        public System.Collections.Generic.List<EmpireExpansionStateOp>? EmpireExpansionState;
        [DataMember(Name = "empire_node_siege_state")]
        public System.Collections.Generic.List<EmpireNodeSiegeStateOp>? EmpireNodeSiegeState;
        [DataMember(Name = "empire_node_state")]
        public System.Collections.Generic.List<EmpireNodeStateOp>? EmpireNodeState;
        [DataMember(Name = "empire_player_data_state")]
        public System.Collections.Generic.List<EmpirePlayerDataStateOp>? EmpirePlayerDataState;
        [DataMember(Name = "empire_rank_state")]
        public System.Collections.Generic.List<EmpireRankStateOp>? EmpireRankState;
        [DataMember(Name = "empire_settlement_state")]
        public System.Collections.Generic.List<EmpireSettlementStateOp>? EmpireSettlementState;
        [DataMember(Name = "empire_state")]
        public System.Collections.Generic.List<EmpireStateOp>? EmpireState;
        [DataMember(Name = "identity_role")]
        public System.Collections.Generic.List<IdentityRoleOp>? IdentityRole;
        [DataMember(Name = "location_state")]
        public System.Collections.Generic.List<LocationStateOp>? LocationState;
        [DataMember(Name = "player_housing_state")]
        public System.Collections.Generic.List<PlayerHousingStateOp>? PlayerHousingState;
        [DataMember(Name = "player_report_state")]
        public System.Collections.Generic.List<PlayerReportStateOp>? PlayerReportState;
        [DataMember(Name = "region_connection_info")]
        public System.Collections.Generic.List<RegionConnectionInfoOp>? RegionConnectionInfo;
        [DataMember(Name = "region_population_info")]
        public System.Collections.Generic.List<RegionPopulationInfoOp>? RegionPopulationInfo;
        [DataMember(Name = "region_sign_in_parameters")]
        public System.Collections.Generic.List<RegionSignInParametersOp>? RegionSignInParameters;
        [DataMember(Name = "user_authentication_state")]
        public System.Collections.Generic.List<UserAuthenticationStateOp>? UserAuthenticationState;
        [DataMember(Name = "user_moderation_state")]
        public System.Collections.Generic.List<UserModerationStateOp>? UserModerationState;
        [DataMember(Name = "user_state")]
        public System.Collections.Generic.List<UserStateOp>? UserState;

        public InterModuleTableUpdates(
            System.Collections.Generic.List<BlockedIdentityOp>? BlockedIdentity,
            System.Collections.Generic.List<BuildingNicknameStateOp>? BuildingNicknameState,
            System.Collections.Generic.List<BuildingStateOp>? BuildingState,
            System.Collections.Generic.List<ClaimMemberStateOp>? ClaimMemberState,
            System.Collections.Generic.List<ClaimStateOp>? ClaimState,
            System.Collections.Generic.List<EmpireChunkStateOp>? EmpireChunkState,
            System.Collections.Generic.List<EmpireExpansionStateOp>? EmpireExpansionState,
            System.Collections.Generic.List<EmpireNodeSiegeStateOp>? EmpireNodeSiegeState,
            System.Collections.Generic.List<EmpireNodeStateOp>? EmpireNodeState,
            System.Collections.Generic.List<EmpirePlayerDataStateOp>? EmpirePlayerDataState,
            System.Collections.Generic.List<EmpireRankStateOp>? EmpireRankState,
            System.Collections.Generic.List<EmpireSettlementStateOp>? EmpireSettlementState,
            System.Collections.Generic.List<EmpireStateOp>? EmpireState,
            System.Collections.Generic.List<IdentityRoleOp>? IdentityRole,
            System.Collections.Generic.List<LocationStateOp>? LocationState,
            System.Collections.Generic.List<PlayerHousingStateOp>? PlayerHousingState,
            System.Collections.Generic.List<PlayerReportStateOp>? PlayerReportState,
            System.Collections.Generic.List<RegionConnectionInfoOp>? RegionConnectionInfo,
            System.Collections.Generic.List<RegionPopulationInfoOp>? RegionPopulationInfo,
            System.Collections.Generic.List<RegionSignInParametersOp>? RegionSignInParameters,
            System.Collections.Generic.List<UserAuthenticationStateOp>? UserAuthenticationState,
            System.Collections.Generic.List<UserModerationStateOp>? UserModerationState,
            System.Collections.Generic.List<UserStateOp>? UserState
        )
        {
            this.BlockedIdentity = BlockedIdentity;
            this.BuildingNicknameState = BuildingNicknameState;
            this.BuildingState = BuildingState;
            this.ClaimMemberState = ClaimMemberState;
            this.ClaimState = ClaimState;
            this.EmpireChunkState = EmpireChunkState;
            this.EmpireExpansionState = EmpireExpansionState;
            this.EmpireNodeSiegeState = EmpireNodeSiegeState;
            this.EmpireNodeState = EmpireNodeState;
            this.EmpirePlayerDataState = EmpirePlayerDataState;
            this.EmpireRankState = EmpireRankState;
            this.EmpireSettlementState = EmpireSettlementState;
            this.EmpireState = EmpireState;
            this.IdentityRole = IdentityRole;
            this.LocationState = LocationState;
            this.PlayerHousingState = PlayerHousingState;
            this.PlayerReportState = PlayerReportState;
            this.RegionConnectionInfo = RegionConnectionInfo;
            this.RegionPopulationInfo = RegionPopulationInfo;
            this.RegionSignInParameters = RegionSignInParameters;
            this.UserAuthenticationState = UserAuthenticationState;
            this.UserModerationState = UserModerationState;
            this.UserState = UserState;
        }

        public InterModuleTableUpdates()
        {
        }
    }
}
