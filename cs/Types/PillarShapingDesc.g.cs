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
    public sealed partial class PillarShapingDesc
    {
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "consumed_item_stacks")]
        public System.Collections.Generic.List<InputItemStack> ConsumedItemStacks;
        [DataMember(Name = "input_cargo_id")]
        public int InputCargoId;
        [DataMember(Name = "input_cargo_discovery_score")]
        public int InputCargoDiscoveryScore;
        [DataMember(Name = "experience_per_progress")]
        public System.Collections.Generic.List<ExperienceStackF32> ExperiencePerProgress;
        [DataMember(Name = "discovery_triggers")]
        public System.Collections.Generic.List<int> DiscoveryTriggers;
        [DataMember(Name = "required_knowledges")]
        public System.Collections.Generic.List<int> RequiredKnowledges;
        [DataMember(Name = "full_discovery_score")]
        public int FullDiscoveryScore;
        [DataMember(Name = "duration")]
        public float Duration;
        [DataMember(Name = "prefab_address")]
        public string PrefabAddress;
        [DataMember(Name = "tier")]
        public int Tier;
        [DataMember(Name = "icon_address")]
        public string IconAddress;
        [DataMember(Name = "description")]
        public string Description;

        public PillarShapingDesc(
            int Id,
            string Name,
            System.Collections.Generic.List<InputItemStack> ConsumedItemStacks,
            int InputCargoId,
            int InputCargoDiscoveryScore,
            System.Collections.Generic.List<ExperienceStackF32> ExperiencePerProgress,
            System.Collections.Generic.List<int> DiscoveryTriggers,
            System.Collections.Generic.List<int> RequiredKnowledges,
            int FullDiscoveryScore,
            float Duration,
            string PrefabAddress,
            int Tier,
            string IconAddress,
            string Description
        )
        {
            this.Id = Id;
            this.Name = Name;
            this.ConsumedItemStacks = ConsumedItemStacks;
            this.InputCargoId = InputCargoId;
            this.InputCargoDiscoveryScore = InputCargoDiscoveryScore;
            this.ExperiencePerProgress = ExperiencePerProgress;
            this.DiscoveryTriggers = DiscoveryTriggers;
            this.RequiredKnowledges = RequiredKnowledges;
            this.FullDiscoveryScore = FullDiscoveryScore;
            this.Duration = Duration;
            this.PrefabAddress = PrefabAddress;
            this.Tier = Tier;
            this.IconAddress = IconAddress;
            this.Description = Description;
        }

        public PillarShapingDesc()
        {
            this.Name = "";
            this.ConsumedItemStacks = new();
            this.ExperiencePerProgress = new();
            this.DiscoveryTriggers = new();
            this.RequiredKnowledges = new();
            this.PrefabAddress = "";
            this.IconAddress = "";
            this.Description = "";
        }
    }
}
