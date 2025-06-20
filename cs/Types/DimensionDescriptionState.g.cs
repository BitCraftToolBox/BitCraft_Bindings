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
    public sealed partial class DimensionDescriptionState
    {
        [DataMember(Name = "entity_id")]
        public ulong EntityId;
        [DataMember(Name = "dimension_network_entity_id")]
        public ulong DimensionNetworkEntityId;
        [DataMember(Name = "collapse_timestamp")]
        public ulong CollapseTimestamp;
        [DataMember(Name = "interior_instance_id")]
        public int InteriorInstanceId;
        [DataMember(Name = "dimension_position_large_x")]
        public uint DimensionPositionLargeX;
        [DataMember(Name = "dimension_position_large_z")]
        public uint DimensionPositionLargeZ;
        [DataMember(Name = "dimension_size_large_x")]
        public uint DimensionSizeLargeX;
        [DataMember(Name = "dimension_size_large_z")]
        public uint DimensionSizeLargeZ;
        [DataMember(Name = "dimension_id")]
        public uint DimensionId;
        [DataMember(Name = "dimension_type")]
        public DimensionType DimensionType;

        public DimensionDescriptionState(
            ulong EntityId,
            ulong DimensionNetworkEntityId,
            ulong CollapseTimestamp,
            int InteriorInstanceId,
            uint DimensionPositionLargeX,
            uint DimensionPositionLargeZ,
            uint DimensionSizeLargeX,
            uint DimensionSizeLargeZ,
            uint DimensionId,
            DimensionType DimensionType
        )
        {
            this.EntityId = EntityId;
            this.DimensionNetworkEntityId = DimensionNetworkEntityId;
            this.CollapseTimestamp = CollapseTimestamp;
            this.InteriorInstanceId = InteriorInstanceId;
            this.DimensionPositionLargeX = DimensionPositionLargeX;
            this.DimensionPositionLargeZ = DimensionPositionLargeZ;
            this.DimensionSizeLargeX = DimensionSizeLargeX;
            this.DimensionSizeLargeZ = DimensionSizeLargeZ;
            this.DimensionId = DimensionId;
            this.DimensionType = DimensionType;
        }

        public DimensionDescriptionState()
        {
        }
    }
}
