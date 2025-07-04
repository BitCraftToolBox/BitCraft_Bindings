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
    public sealed partial class LocationState
    {
        [DataMember(Name = "entity_id")]
        public ulong EntityId;
        [DataMember(Name = "chunk_index")]
        public ulong ChunkIndex;
        [DataMember(Name = "x")]
        public int X;
        [DataMember(Name = "z")]
        public int Z;
        [DataMember(Name = "dimension")]
        public uint Dimension;

        public LocationState(
            ulong EntityId,
            ulong ChunkIndex,
            int X,
            int Z,
            uint Dimension
        )
        {
            this.EntityId = EntityId;
            this.ChunkIndex = ChunkIndex;
            this.X = X;
            this.Z = Z;
            this.Dimension = Dimension;
        }

        public LocationState()
        {
        }
    }
}
