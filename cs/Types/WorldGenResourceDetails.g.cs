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
    public sealed partial class WorldGenResourceDetails
    {
        [DataMember(Name = "clump_id")]
        public int ClumpId;
        [DataMember(Name = "spawns_on_land")]
        public bool SpawnsOnLand;
        [DataMember(Name = "land_elevation_range")]
        public WorldGenVector2Int LandElevationRange;
        [DataMember(Name = "spawns_in_water")]
        public bool SpawnsInWater;
        [DataMember(Name = "water_depth_range")]
        public WorldGenVector2Int WaterDepthRange;
        [DataMember(Name = "spawns_on_uneven_terrain")]
        public bool SpawnsOnUnevenTerrain;

        public WorldGenResourceDetails(
            int ClumpId,
            bool SpawnsOnLand,
            WorldGenVector2Int LandElevationRange,
            bool SpawnsInWater,
            WorldGenVector2Int WaterDepthRange,
            bool SpawnsOnUnevenTerrain
        )
        {
            this.ClumpId = ClumpId;
            this.SpawnsOnLand = SpawnsOnLand;
            this.LandElevationRange = LandElevationRange;
            this.SpawnsInWater = SpawnsInWater;
            this.WaterDepthRange = WaterDepthRange;
            this.SpawnsOnUnevenTerrain = SpawnsOnUnevenTerrain;
        }

        public WorldGenResourceDetails()
        {
            this.LandElevationRange = new();
            this.WaterDepthRange = new();
        }
    }
}
