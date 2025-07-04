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
    public sealed partial class EnemyAiParamsDesc
    {
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "enemy_type")]
        public EnemyType EnemyType;
        [DataMember(Name = "biome")]
        public Biome Biome;
        [DataMember(Name = "avg_herd_size")]
        public int AvgHerdSize;
        [DataMember(Name = "var_herd_size")]
        public float VarHerdSize;
        [DataMember(Name = "herds_per_chunk")]
        public float HerdsPerChunk;
        [DataMember(Name = "roaming_distance")]
        public int RoamingDistance;
        [DataMember(Name = "spawn_eagerness")]
        public float SpawnEagerness;
        [DataMember(Name = "time_of_day_start")]
        public float TimeOfDayStart;
        [DataMember(Name = "time_of_day_end")]
        public float TimeOfDayEnd;
        [DataMember(Name = "spawn_frequency_minutes")]
        public float SpawnFrequencyMinutes;

        public EnemyAiParamsDesc(
            int Id,
            EnemyType EnemyType,
            Biome Biome,
            int AvgHerdSize,
            float VarHerdSize,
            float HerdsPerChunk,
            int RoamingDistance,
            float SpawnEagerness,
            float TimeOfDayStart,
            float TimeOfDayEnd,
            float SpawnFrequencyMinutes
        )
        {
            this.Id = Id;
            this.EnemyType = EnemyType;
            this.Biome = Biome;
            this.AvgHerdSize = AvgHerdSize;
            this.VarHerdSize = VarHerdSize;
            this.HerdsPerChunk = HerdsPerChunk;
            this.RoamingDistance = RoamingDistance;
            this.SpawnEagerness = SpawnEagerness;
            this.TimeOfDayStart = TimeOfDayStart;
            this.TimeOfDayEnd = TimeOfDayEnd;
            this.SpawnFrequencyMinutes = SpawnFrequencyMinutes;
        }

        public EnemyAiParamsDesc()
        {
        }
    }
}
