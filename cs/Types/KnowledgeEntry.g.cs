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
    public sealed partial class KnowledgeEntry
    {
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "state")]
        public KnowledgeState State;

        public KnowledgeEntry(
            int Id,
            KnowledgeState State
        )
        {
            this.Id = Id;
            this.State = State;
        }

        public KnowledgeEntry()
        {
        }
    }
}
