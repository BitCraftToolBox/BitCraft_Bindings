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
    public sealed partial class ChestRarityDesc
    {
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "loot_rarities")]
        public System.Collections.Generic.List<ChestLootRarity> LootRarities;

        public ChestRarityDesc(
            int Id,
            string Name,
            System.Collections.Generic.List<ChestLootRarity> LootRarities
        )
        {
            this.Id = Id;
            this.Name = Name;
            this.LootRarities = LootRarities;
        }

        public ChestRarityDesc()
        {
            this.Name = "";
            this.LootRarities = new();
        }
    }
}
