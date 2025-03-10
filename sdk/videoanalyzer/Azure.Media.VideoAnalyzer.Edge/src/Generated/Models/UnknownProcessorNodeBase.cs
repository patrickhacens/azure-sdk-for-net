// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The UnknownProcessorNodeBase. </summary>
    internal partial class UnknownProcessorNodeBase : ProcessorNodeBase
    {
        /// <summary> Initializes a new instance of UnknownProcessorNodeBase. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="inputs"> An array of upstream node references within the topology to be used as inputs for this node. </param>
        internal UnknownProcessorNodeBase(string type, string name, IList<NodeInput> inputs) : base(type, name, inputs)
        {
            Type = type ?? "Unknown";
        }
    }
}
