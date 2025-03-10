// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> SKU of the namespace. </summary>
    public partial class RelaySku
    {
        /// <summary> Initializes a new instance of RelaySku. </summary>
        /// <param name="name"> Name of this SKU. </param>
        public RelaySku(RelaySkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of RelaySku. </summary>
        /// <param name="name"> Name of this SKU. </param>
        /// <param name="tier"> The tier of this SKU. </param>
        internal RelaySku(RelaySkuName name, RelaySkuTier? tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> Name of this SKU. </summary>
        public RelaySkuName Name { get; set; }
        /// <summary> The tier of this SKU. </summary>
        public RelaySkuTier? Tier { get; set; }
    }
}
