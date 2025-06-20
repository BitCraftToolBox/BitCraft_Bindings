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
    public sealed partial class ForceGenerateTypes
    {
        [DataMember(Name = "hex_direction")]
        public HexDirection HexDirection;
        [DataMember(Name = "float_hex_tile")]
        public FloatHexTileMessage FloatHexTile;
        [DataMember(Name = "chunk_coordinates_message")]
        public ChunkCoordinatesMessage ChunkCoordinatesMessage;
        [DataMember(Name = "claim_permission")]
        public ClaimPermission ClaimPermission;
        [DataMember(Name = "large_hex_tile_message")]
        public LargeHexTileMessage LargeHexTileMessage;
        [DataMember(Name = "terrain_cell")]
        public TerrainCell TerrainCell;
        [DataMember(Name = "item_conversion_locatin_context")]
        public ItemConversionLocationContext ItemConversionLocatinContext;

        public ForceGenerateTypes(
            HexDirection HexDirection,
            FloatHexTileMessage FloatHexTile,
            ChunkCoordinatesMessage ChunkCoordinatesMessage,
            ClaimPermission ClaimPermission,
            LargeHexTileMessage LargeHexTileMessage,
            TerrainCell TerrainCell,
            ItemConversionLocationContext ItemConversionLocatinContext
        )
        {
            this.HexDirection = HexDirection;
            this.FloatHexTile = FloatHexTile;
            this.ChunkCoordinatesMessage = ChunkCoordinatesMessage;
            this.ClaimPermission = ClaimPermission;
            this.LargeHexTileMessage = LargeHexTileMessage;
            this.TerrainCell = TerrainCell;
            this.ItemConversionLocatinContext = ItemConversionLocatinContext;
        }

        public ForceGenerateTypes()
        {
            this.FloatHexTile = new();
            this.ChunkCoordinatesMessage = new();
            this.LargeHexTileMessage = new();
            this.TerrainCell = new();
        }
    }
}
