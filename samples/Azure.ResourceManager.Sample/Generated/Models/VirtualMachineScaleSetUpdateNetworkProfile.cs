// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Describes a virtual machine scale set network profile. </summary>
    public partial class VirtualMachineScaleSetUpdateNetworkProfile
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetUpdateNetworkProfile. </summary>
        public VirtualMachineScaleSetUpdateNetworkProfile()
        {
            NetworkInterfaceConfigurations = new ChangeTrackingList<VirtualMachineScaleSetUpdateNetworkConfiguration>();
        }

        /// <summary> A reference to a load balancer probe used to determine the health of an instance in the virtual machine scale set. The reference will be in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}&apos;. </summary>
        public WritableSubResource HealthProbe { get; set; }
        /// <summary> The list of network configurations. </summary>
        public IList<VirtualMachineScaleSetUpdateNetworkConfiguration> NetworkInterfaceConfigurations { get; }
    }
}
