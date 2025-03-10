// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Stop packet capture parameters. </summary>
    public partial class VpnPacketCaptureStopContent
    {
        /// <summary> Initializes a new instance of VpnPacketCaptureStopContent. </summary>
        public VpnPacketCaptureStopContent()
        {
        }

        /// <summary> SAS url for packet capture on virtual network gateway. </summary>
        public Uri SasUri { get; set; }
    }
}
