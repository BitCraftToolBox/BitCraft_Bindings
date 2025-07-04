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
    public sealed partial class WorldGenWorldDefinition
    {
        [DataMember(Name = "size")]
        public WorldGenVector2Int Size;
        [DataMember(Name = "land_curve")]
        public WorldGenAnimationCurve LandCurve;
        [DataMember(Name = "noise_influence")]
        public float NoiseInfluence;
        [DataMember(Name = "sea_level")]
        public int SeaLevel;
        [DataMember(Name = "world_map")]
        public WorldGenWorldMapDefinition WorldMap;
        [DataMember(Name = "biomes_map")]
        public WorldGenBiomesMapDefinition BiomesMap;
        [DataMember(Name = "mountains_map")]
        public WorldGenMountainsMapDefinition MountainsMap;
        [DataMember(Name = "buildings_map")]
        public WorldGenBuildingsMapDefinition BuildingsMap;
        [DataMember(Name = "resources_map")]
        public WorldGenResourcesMapDefinition ResourcesMap;

        public WorldGenWorldDefinition(
            WorldGenVector2Int Size,
            WorldGenAnimationCurve LandCurve,
            float NoiseInfluence,
            int SeaLevel,
            WorldGenWorldMapDefinition WorldMap,
            WorldGenBiomesMapDefinition BiomesMap,
            WorldGenMountainsMapDefinition MountainsMap,
            WorldGenBuildingsMapDefinition BuildingsMap,
            WorldGenResourcesMapDefinition ResourcesMap
        )
        {
            this.Size = Size;
            this.LandCurve = LandCurve;
            this.NoiseInfluence = NoiseInfluence;
            this.SeaLevel = SeaLevel;
            this.WorldMap = WorldMap;
            this.BiomesMap = BiomesMap;
            this.MountainsMap = MountainsMap;
            this.BuildingsMap = BuildingsMap;
            this.ResourcesMap = ResourcesMap;
        }

        public WorldGenWorldDefinition()
        {
            this.Size = new();
            this.LandCurve = new();
            this.WorldMap = new();
            this.BiomesMap = new();
            this.MountainsMap = new();
            this.BuildingsMap = new();
            this.ResourcesMap = new();
        }
    }
}
