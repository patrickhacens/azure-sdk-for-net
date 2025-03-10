// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A WebLinkedService that uses anonymous authentication to communicate with an HTTP endpoint. </summary>
    public partial class WebAnonymousAuthentication : WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of WebAnonymousAuthentication. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. https://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public WebAnonymousAuthentication(DataFactoryElement<string> uri) : base(uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            AuthenticationType = WebAuthenticationType.Anonymous;
        }

        /// <summary> Initializes a new instance of WebAnonymousAuthentication. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. https://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        internal WebAnonymousAuthentication(DataFactoryElement<string> uri, WebAuthenticationType authenticationType) : base(uri, authenticationType)
        {
            AuthenticationType = authenticationType;
        }
    }
}
