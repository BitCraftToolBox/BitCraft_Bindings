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
    public sealed partial class PlayerConvertCollectibleToDeedRequest
    {
        [DataMember(Name = "vault_index")]
        public int VaultIndex;

        public PlayerConvertCollectibleToDeedRequest(int VaultIndex)
        {
            this.VaultIndex = VaultIndex;
        }

        public PlayerConvertCollectibleToDeedRequest()
        {
        }
    }
}
