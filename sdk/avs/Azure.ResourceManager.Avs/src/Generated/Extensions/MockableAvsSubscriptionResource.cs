// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Avs;
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableAvsSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _locationsClientDiagnostics;
        private LocationsRestOperations _locationsRestClient;
        private ClientDiagnostics _avsPrivateCloudPrivateCloudsClientDiagnostics;
        private PrivateCloudsRestOperations _avsPrivateCloudPrivateCloudsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableAvsSubscriptionResource"/> class for mocking. </summary>
        protected MockableAvsSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAvsSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAvsSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics LocationsClientDiagnostics => _locationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Avs", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationsRestOperations LocationsRestClient => _locationsRestClient ??= new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics AvsPrivateCloudPrivateCloudsClientDiagnostics => _avsPrivateCloudPrivateCloudsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Avs", AvsPrivateCloudResource.ResourceType.Namespace, Diagnostics);
        private PrivateCloudsRestOperations AvsPrivateCloudPrivateCloudsRestClient => _avsPrivateCloudPrivateCloudsRestClient ??= new PrivateCloudsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AvsPrivateCloudResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Return trial status for subscription by region
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AVS/locations/{location}/checkTrialAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckTrialAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Azure region. </param>
        /// <param name="sku"> The sku to check for trial availability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AvsSubscriptionTrialAvailabilityResult>> CheckAvsTrialAvailabilityAsync(AzureLocation location, AvsSku sku = null, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("MockableAvsSubscriptionResource.CheckAvsTrialAvailability");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.CheckTrialAvailabilityAsync(Id.SubscriptionId, location, sku, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Return trial status for subscription by region
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AVS/locations/{location}/checkTrialAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckTrialAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Azure region. </param>
        /// <param name="sku"> The sku to check for trial availability. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AvsSubscriptionTrialAvailabilityResult> CheckAvsTrialAvailability(AzureLocation location, AvsSku sku = null, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("MockableAvsSubscriptionResource.CheckAvsTrialAvailability");
            scope.Start();
            try
            {
                var response = LocationsRestClient.CheckTrialAvailability(Id.SubscriptionId, location, sku, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Return quota for subscription by region
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AVS/locations/{location}/checkQuotaAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckQuotaAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AvsSubscriptionQuotaAvailabilityResult>> CheckAvsQuotaAvailabilityAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("MockableAvsSubscriptionResource.CheckAvsQuotaAvailability");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.CheckQuotaAvailabilityAsync(Id.SubscriptionId, location, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Return quota for subscription by region
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AVS/locations/{location}/checkQuotaAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckQuotaAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AvsSubscriptionQuotaAvailabilityResult> CheckAvsQuotaAvailability(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("MockableAvsSubscriptionResource.CheckAvsQuotaAvailability");
            scope.Start();
            try
            {
                var response = LocationsRestClient.CheckQuotaAvailability(Id.SubscriptionId, location, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List private clouds in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AVS/privateClouds</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateClouds_ListInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvsPrivateCloudResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvsPrivateCloudResource> GetAvsPrivateCloudsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvsPrivateCloudPrivateCloudsRestClient.CreateListInSubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvsPrivateCloudPrivateCloudsRestClient.CreateListInSubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AvsPrivateCloudResource(Client, AvsPrivateCloudData.DeserializeAvsPrivateCloudData(e)), AvsPrivateCloudPrivateCloudsClientDiagnostics, Pipeline, "MockableAvsSubscriptionResource.GetAvsPrivateClouds", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List private clouds in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AVS/privateClouds</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateClouds_ListInSubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvsPrivateCloudResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvsPrivateCloudResource> GetAvsPrivateClouds(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AvsPrivateCloudPrivateCloudsRestClient.CreateListInSubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AvsPrivateCloudPrivateCloudsRestClient.CreateListInSubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AvsPrivateCloudResource(Client, AvsPrivateCloudData.DeserializeAvsPrivateCloudData(e)), AvsPrivateCloudPrivateCloudsClientDiagnostics, Pipeline, "MockableAvsSubscriptionResource.GetAvsPrivateClouds", "value", "nextLink", cancellationToken);
        }
    }
}
