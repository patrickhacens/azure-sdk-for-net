// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing the LogicWorkflow data model.
    /// The workflow type.
    /// </summary>
    public partial class LogicWorkflowData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of LogicWorkflowData. </summary>
        /// <param name="location"> The location. </param>
        public LogicWorkflowData(AzureLocation location) : base(location)
        {
            Parameters = new ChangeTrackingDictionary<string, LogicWorkflowParameterInfo>();
        }

        /// <summary> Initializes a new instance of LogicWorkflowData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed service identity properties. Current supported identity types: SystemAssigned, UserAssigned, None. </param>
        /// <param name="provisioningState"> Gets the provisioning state. </param>
        /// <param name="createdOn"> Gets the created time. </param>
        /// <param name="changedOn"> Gets the changed time. </param>
        /// <param name="state"> The state. </param>
        /// <param name="version"> Gets the version. </param>
        /// <param name="accessEndpoint"> Gets the access endpoint. </param>
        /// <param name="endpointsConfiguration"> The endpoints configuration. </param>
        /// <param name="accessControl"> The access control configuration. </param>
        /// <param name="sku"> The sku. </param>
        /// <param name="integrationAccount"> The integration account. </param>
        /// <param name="integrationServiceEnvironment"> The integration service environment. </param>
        /// <param name="definition"> The definition. </param>
        /// <param name="parameters"> The parameters. </param>
        internal LogicWorkflowData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, LogicWorkflowProvisioningState? provisioningState, DateTimeOffset? createdOn, DateTimeOffset? changedOn, LogicWorkflowState? state, string version, string accessEndpoint, FlowEndpointsConfiguration endpointsConfiguration, FlowAccessControlConfiguration accessControl, LogicSku sku, LogicResourceReference integrationAccount, LogicResourceReference integrationServiceEnvironment, BinaryData definition, IDictionary<string, LogicWorkflowParameterInfo> parameters) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            CreatedOn = createdOn;
            ChangedOn = changedOn;
            State = state;
            Version = version;
            AccessEndpoint = accessEndpoint;
            EndpointsConfiguration = endpointsConfiguration;
            AccessControl = accessControl;
            Sku = sku;
            IntegrationAccount = integrationAccount;
            IntegrationServiceEnvironment = integrationServiceEnvironment;
            Definition = definition;
            Parameters = parameters;
        }

        /// <summary> Managed service identity properties. Current supported identity types: SystemAssigned, UserAssigned, None. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Gets the provisioning state. </summary>
        public LogicWorkflowProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the created time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets the changed time. </summary>
        public DateTimeOffset? ChangedOn { get; }
        /// <summary> The state. </summary>
        public LogicWorkflowState? State { get; set; }
        /// <summary> Gets the version. </summary>
        public string Version { get; }
        /// <summary> Gets the access endpoint. </summary>
        public string AccessEndpoint { get; }
        /// <summary> The endpoints configuration. </summary>
        public FlowEndpointsConfiguration EndpointsConfiguration { get; set; }
        /// <summary> The access control configuration. </summary>
        public FlowAccessControlConfiguration AccessControl { get; set; }
        /// <summary> The sku. </summary>
        public LogicSku Sku { get; }
        /// <summary> The integration account. </summary>
        public LogicResourceReference IntegrationAccount { get; set; }
        /// <summary> The integration service environment. </summary>
        public LogicResourceReference IntegrationServiceEnvironment { get; set; }
        /// <summary>
        /// The definition.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Definition { get; set; }
        /// <summary> The parameters. </summary>
        public IDictionary<string, LogicWorkflowParameterInfo> Parameters { get; }
    }
}
