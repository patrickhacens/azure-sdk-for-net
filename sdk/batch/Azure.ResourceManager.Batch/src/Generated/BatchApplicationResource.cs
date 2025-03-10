// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Batch
{
    /// <summary>
    /// A Class representing a BatchApplication along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="BatchApplicationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetBatchApplicationResource method.
    /// Otherwise you can get one from its parent resource <see cref="BatchAccountResource" /> using the GetBatchApplication method.
    /// </summary>
    public partial class BatchApplicationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BatchApplicationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="applicationName"> The applicationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string applicationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _batchApplicationApplicationClientDiagnostics;
        private readonly ApplicationRestOperations _batchApplicationApplicationRestClient;
        private readonly BatchApplicationData _data;

        /// <summary> Initializes a new instance of the <see cref="BatchApplicationResource"/> class for mocking. </summary>
        protected BatchApplicationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BatchApplicationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BatchApplicationResource(ArmClient client, BatchApplicationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BatchApplicationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BatchApplicationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _batchApplicationApplicationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Batch", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string batchApplicationApplicationApiVersion);
            _batchApplicationApplicationRestClient = new ApplicationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, batchApplicationApplicationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Batch/batchAccounts/applications";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BatchApplicationData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of BatchApplicationPackageResources in the BatchApplication. </summary>
        /// <returns> An object representing collection of BatchApplicationPackageResources and their operations over a BatchApplicationPackageResource. </returns>
        public virtual BatchApplicationPackageCollection GetBatchApplicationPackages()
        {
            return GetCachedClient(client => new BatchApplicationPackageCollection(client, Id));
        }

        /// <summary>
        /// Gets information about the specified application package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationPackage_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BatchApplicationPackageResource>> GetBatchApplicationPackageAsync(string versionName, CancellationToken cancellationToken = default)
        {
            return await GetBatchApplicationPackages().GetAsync(versionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified application package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}/versions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ApplicationPackage_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The version of the application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<BatchApplicationPackageResource> GetBatchApplicationPackage(string versionName, CancellationToken cancellationToken = default)
        {
            return GetBatchApplicationPackages().Get(versionName, cancellationToken);
        }

        /// <summary>
        /// Gets information about the specified application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BatchApplicationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationResource.Get");
            scope.Start();
            try
            {
                var response = await _batchApplicationApplicationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BatchApplicationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationResource.Get");
            scope.Start();
            try
            {
                var response = _batchApplicationApplicationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationResource.Delete");
            scope.Start();
            try
            {
                var response = await _batchApplicationApplicationRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new BatchArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationResource.Delete");
            scope.Start();
            try
            {
                var response = _batchApplicationApplicationRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new BatchArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates settings for the specified application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The parameters for the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<BatchApplicationResource>> UpdateAsync(BatchApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationResource.Update");
            scope.Start();
            try
            {
                var response = await _batchApplicationApplicationRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new BatchApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates settings for the specified application.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Batch/batchAccounts/{accountName}/applications/{applicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Application_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> The parameters for the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<BatchApplicationResource> Update(BatchApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _batchApplicationApplicationClientDiagnostics.CreateScope("BatchApplicationResource.Update");
            scope.Start();
            try
            {
                var response = _batchApplicationApplicationRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new BatchApplicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
