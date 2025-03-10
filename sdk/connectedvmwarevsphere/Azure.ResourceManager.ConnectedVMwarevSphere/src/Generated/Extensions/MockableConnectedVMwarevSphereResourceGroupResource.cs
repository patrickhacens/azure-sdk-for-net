// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ConnectedVMwarevSphere;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableConnectedVMwarevSphereResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableConnectedVMwarevSphereResourceGroupResource"/> class for mocking. </summary>
        protected MockableConnectedVMwarevSphereResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableConnectedVMwarevSphereResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableConnectedVMwarevSphereResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ResourcePoolResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ResourcePoolResources and their operations over a ResourcePoolResource. </returns>
        public virtual ResourcePoolCollection GetResourcePools()
        {
            return GetCachedClient(client => new ResourcePoolCollection(client, Id));
        }

        /// <summary>
        /// Implements resourcePool GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ResourcePoolResource>> GetResourcePoolAsync(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            return await GetResourcePools().GetAsync(resourcePoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements resourcePool GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ResourcePoolResource> GetResourcePool(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            return GetResourcePools().Get(resourcePoolName, cancellationToken);
        }

        /// <summary> Gets a collection of VMwareClusterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VMwareClusterResources and their operations over a VMwareClusterResource. </returns>
        public virtual VMwareClusterCollection GetVMwareClusters()
        {
            return GetCachedClient(client => new VMwareClusterCollection(client, Id));
        }

        /// <summary>
        /// Implements cluster GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VMwareClusterResource>> GetVMwareClusterAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            return await GetVMwareClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements cluster GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> Name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<VMwareClusterResource> GetVMwareCluster(string clusterName, CancellationToken cancellationToken = default)
        {
            return GetVMwareClusters().Get(clusterName, cancellationToken);
        }

        /// <summary> Gets a collection of VMwareHostResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VMwareHostResources and their operations over a VMwareHostResource. </returns>
        public virtual VMwareHostCollection GetVMwareHosts()
        {
            return GetCachedClient(client => new VMwareHostCollection(client, Id));
        }

        /// <summary>
        /// Implements host GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/hosts/{hostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Hosts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hostName"> Name of the host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VMwareHostResource>> GetVMwareHostAsync(string hostName, CancellationToken cancellationToken = default)
        {
            return await GetVMwareHosts().GetAsync(hostName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements host GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/hosts/{hostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Hosts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hostName"> Name of the host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<VMwareHostResource> GetVMwareHost(string hostName, CancellationToken cancellationToken = default)
        {
            return GetVMwareHosts().Get(hostName, cancellationToken);
        }

        /// <summary> Gets a collection of VMwareDatastoreResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VMwareDatastoreResources and their operations over a VMwareDatastoreResource. </returns>
        public virtual VMwareDatastoreCollection GetVMwareDatastores()
        {
            return GetCachedClient(client => new VMwareDatastoreCollection(client, Id));
        }

        /// <summary>
        /// Implements datastore GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VMwareDatastoreResource>> GetVMwareDatastoreAsync(string datastoreName, CancellationToken cancellationToken = default)
        {
            return await GetVMwareDatastores().GetAsync(datastoreName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements datastore GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/datastores/{datastoreName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Datastores_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="datastoreName"> Name of the datastore. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="datastoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="datastoreName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<VMwareDatastoreResource> GetVMwareDatastore(string datastoreName, CancellationToken cancellationToken = default)
        {
            return GetVMwareDatastores().Get(datastoreName, cancellationToken);
        }

        /// <summary> Gets a collection of VCenterResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VCenterResources and their operations over a VCenterResource. </returns>
        public virtual VCenterCollection GetVCenters()
        {
            return GetCachedClient(client => new VCenterCollection(client, Id));
        }

        /// <summary>
        /// Implements vCenter GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VCenters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VCenterResource>> GetVCenterAsync(string vcenterName, CancellationToken cancellationToken = default)
        {
            return await GetVCenters().GetAsync(vcenterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements vCenter GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/vcenters/{vcenterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VCenters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vcenterName"> Name of the vCenter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vcenterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vcenterName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<VCenterResource> GetVCenter(string vcenterName, CancellationToken cancellationToken = default)
        {
            return GetVCenters().Get(vcenterName, cancellationToken);
        }

        /// <summary> Gets a collection of VirtualMachineResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VirtualMachineResources and their operations over a VirtualMachineResource. </returns>
        public virtual VirtualMachineCollection GetVirtualMachines()
        {
            return GetCachedClient(client => new VirtualMachineCollection(client, Id));
        }

        /// <summary>
        /// Implements virtual machine GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineName"> Name of the virtual machine resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VirtualMachineResource>> GetVirtualMachineAsync(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            return await GetVirtualMachines().GetAsync(virtualMachineName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements virtual machine GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachines/{virtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineName"> Name of the virtual machine resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<VirtualMachineResource> GetVirtualMachine(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            return GetVirtualMachines().Get(virtualMachineName, cancellationToken);
        }

        /// <summary> Gets a collection of VirtualMachineTemplateResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VirtualMachineTemplateResources and their operations over a VirtualMachineTemplateResource. </returns>
        public virtual VirtualMachineTemplateCollection GetVirtualMachineTemplates()
        {
            return GetCachedClient(client => new VirtualMachineTemplateCollection(client, Id));
        }

        /// <summary>
        /// Implements virtual machine template GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VirtualMachineTemplateResource>> GetVirtualMachineTemplateAsync(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            return await GetVirtualMachineTemplates().GetAsync(virtualMachineTemplateName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements virtual machine template GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the virtual machine template resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<VirtualMachineTemplateResource> GetVirtualMachineTemplate(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            return GetVirtualMachineTemplates().Get(virtualMachineTemplateName, cancellationToken);
        }

        /// <summary> Gets a collection of VirtualNetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VirtualNetworkResources and their operations over a VirtualNetworkResource. </returns>
        public virtual VirtualNetworkCollection GetVirtualNetworks()
        {
            return GetCachedClient(client => new VirtualNetworkCollection(client, Id));
        }

        /// <summary>
        /// Implements virtual network GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the virtual network resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VirtualNetworkResource>> GetVirtualNetworkAsync(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            return await GetVirtualNetworks().GetAsync(virtualNetworkName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements virtual network GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the virtual network resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<VirtualNetworkResource> GetVirtualNetwork(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            return GetVirtualNetworks().Get(virtualNetworkName, cancellationToken);
        }
    }
}
