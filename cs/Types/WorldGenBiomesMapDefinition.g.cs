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
    public sealed partial class WorldGenBiomesMapDefinition
    {
        [DataMember(Name = "biomes")]
        public System.Collections.Generic.List<WorldGenBiomeDefinition> Biomes;
        [DataMember(Name = "values")]
        public System.Collections.Generic.List<byte> Values;

        public WorldGenBiomesMapDefinition(
            System.Collections.Generic.List<WorldGenBiomeDefinition> Biomes,
            System.Collections.Generic.List<byte> Values
        )
        {
            this.Biomes = Biomes;
            this.Values = Values;
        }

        public WorldGenBiomesMapDefinition()
        {
            this.Biomes = new();
            this.Values = new();
        }
    }
}
