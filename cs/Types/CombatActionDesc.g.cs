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
    public sealed partial class CombatActionDesc
    {
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "learned_by_player")]
        public bool LearnedByPlayer;
        [DataMember(Name = "range")]
        public uint Range;
        [DataMember(Name = "max_range")]
        public uint MaxRange;
        [DataMember(Name = "auto_cast")]
        public bool AutoCast;
        [DataMember(Name = "weapon_type_requirements")]
        public System.Collections.Generic.List<int> WeaponTypeRequirements;
        [DataMember(Name = "lead_in_time")]
        public float LeadInTime;
        [DataMember(Name = "can_move_during_lead_in")]
        public bool CanMoveDuringLeadIn;
        [DataMember(Name = "cooldown")]
        public float Cooldown;
        [DataMember(Name = "global_cooldown")]
        public float GlobalCooldown;
        [DataMember(Name = "ignore_global_cooldown")]
        public bool IgnoreGlobalCooldown;
        [DataMember(Name = "strength_multiplier")]
        public float StrengthMultiplier;
        [DataMember(Name = "accuracy_multiplier")]
        public float AccuracyMultiplier;
        [DataMember(Name = "stamina_use")]
        public float StaminaUse;
        [DataMember(Name = "weapon_durability_lost")]
        public int WeaponDurabilityLost;
        [DataMember(Name = "self_buffs")]
        public System.Collections.Generic.List<BuffEffect> SelfBuffs;
        [DataMember(Name = "target_buffs")]
        public System.Collections.Generic.List<BuffEffect> TargetBuffs;
        [DataMember(Name = "level_requirement")]
        public LevelRequirement? LevelRequirement;
        [DataMember(Name = "icon_asset_name")]
        public string IconAssetName;
        [DataMember(Name = "player_animation_id")]
        public int PlayerAnimationId;
        [DataMember(Name = "npc_animation_name")]
        public string NpcAnimationName;
        [DataMember(Name = "hit_vfx")]
        public string HitVfx;
        [DataMember(Name = "projectile_speed")]
        public float ProjectileSpeed;
        [DataMember(Name = "projectile_vfx")]
        public string ProjectileVfx;
        [DataMember(Name = "description")]
        public string Description;
        [DataMember(Name = "self_threat_against_buildings")]
        public float SelfThreatAgainstBuildings;
        [DataMember(Name = "self_threat_against_enemies")]
        public float SelfThreatAgainstEnemies;
        [DataMember(Name = "base_threat")]
        public float BaseThreat;
        [DataMember(Name = "threat_per_damage")]
        public float ThreatPerDamage;

        public CombatActionDesc(
            string Name,
            int Id,
            bool LearnedByPlayer,
            uint Range,
            uint MaxRange,
            bool AutoCast,
            System.Collections.Generic.List<int> WeaponTypeRequirements,
            float LeadInTime,
            bool CanMoveDuringLeadIn,
            float Cooldown,
            float GlobalCooldown,
            bool IgnoreGlobalCooldown,
            float StrengthMultiplier,
            float AccuracyMultiplier,
            float StaminaUse,
            int WeaponDurabilityLost,
            System.Collections.Generic.List<BuffEffect> SelfBuffs,
            System.Collections.Generic.List<BuffEffect> TargetBuffs,
            LevelRequirement? LevelRequirement,
            string IconAssetName,
            int PlayerAnimationId,
            string NpcAnimationName,
            string HitVfx,
            float ProjectileSpeed,
            string ProjectileVfx,
            string Description,
            float SelfThreatAgainstBuildings,
            float SelfThreatAgainstEnemies,
            float BaseThreat,
            float ThreatPerDamage
        )
        {
            this.Name = Name;
            this.Id = Id;
            this.LearnedByPlayer = LearnedByPlayer;
            this.Range = Range;
            this.MaxRange = MaxRange;
            this.AutoCast = AutoCast;
            this.WeaponTypeRequirements = WeaponTypeRequirements;
            this.LeadInTime = LeadInTime;
            this.CanMoveDuringLeadIn = CanMoveDuringLeadIn;
            this.Cooldown = Cooldown;
            this.GlobalCooldown = GlobalCooldown;
            this.IgnoreGlobalCooldown = IgnoreGlobalCooldown;
            this.StrengthMultiplier = StrengthMultiplier;
            this.AccuracyMultiplier = AccuracyMultiplier;
            this.StaminaUse = StaminaUse;
            this.WeaponDurabilityLost = WeaponDurabilityLost;
            this.SelfBuffs = SelfBuffs;
            this.TargetBuffs = TargetBuffs;
            this.LevelRequirement = LevelRequirement;
            this.IconAssetName = IconAssetName;
            this.PlayerAnimationId = PlayerAnimationId;
            this.NpcAnimationName = NpcAnimationName;
            this.HitVfx = HitVfx;
            this.ProjectileSpeed = ProjectileSpeed;
            this.ProjectileVfx = ProjectileVfx;
            this.Description = Description;
            this.SelfThreatAgainstBuildings = SelfThreatAgainstBuildings;
            this.SelfThreatAgainstEnemies = SelfThreatAgainstEnemies;
            this.BaseThreat = BaseThreat;
            this.ThreatPerDamage = ThreatPerDamage;
        }

        public CombatActionDesc()
        {
            this.Name = "";
            this.WeaponTypeRequirements = new();
            this.SelfBuffs = new();
            this.TargetBuffs = new();
            this.IconAssetName = "";
            this.NpcAnimationName = "";
            this.HitVfx = "";
            this.ProjectileVfx = "";
            this.Description = "";
        }
    }
}
