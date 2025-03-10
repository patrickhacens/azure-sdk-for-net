// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure Data Explorer command activity. </summary>
    public partial class AzureDataExplorerCommandActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of AzureDataExplorerCommandActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="command"> A control command, according to the Azure Data Explorer command syntax. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="command"/> is null. </exception>
        public AzureDataExplorerCommandActivity(string name, DataFactoryElement<string> command) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(command, nameof(command));

            Command = command;
            ActivityType = "AzureDataExplorerCommand";
        }

        /// <summary> Initializes a new instance of AzureDataExplorerCommandActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="command"> A control command, according to the Azure Data Explorer command syntax. Type: string (or Expression with resultType string). </param>
        /// <param name="commandTimeout"> Control command timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..). </param>
        internal AzureDataExplorerCommandActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, DataFactoryElement<string> command, DataFactoryElement<string> commandTimeout) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Command = command;
            CommandTimeout = commandTimeout;
            ActivityType = activityType ?? "AzureDataExplorerCommand";
        }

        /// <summary> A control command, according to the Azure Data Explorer command syntax. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Command { get; set; }
        /// <summary> Control command timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..). </summary>
        public DataFactoryElement<string> CommandTimeout { get; set; }
    }
}
