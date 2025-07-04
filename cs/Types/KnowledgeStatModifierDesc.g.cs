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
    public sealed partial class KnowledgeStatModifierDesc
    {
        [DataMember(Name = "secondary_knowledge_id")]
        public int SecondaryKnowledgeId;
        [DataMember(Name = "stats")]
        public System.Collections.Generic.List<CsvStatEntry> Stats;

        public KnowledgeStatModifierDesc(
            int SecondaryKnowledgeId,
            System.Collections.Generic.List<CsvStatEntry> Stats
        )
        {
            this.SecondaryKnowledgeId = SecondaryKnowledgeId;
            this.Stats = Stats;
        }

        public KnowledgeStatModifierDesc()
        {
            this.Stats = new();
        }
    }
}
