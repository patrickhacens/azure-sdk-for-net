// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DesktopVirtualization;
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_VirtualApplicationCollection
    {
        // Application_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApplicationGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/Application_Get.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualApplicationGroupResource created on azure
            // for more information of creating VirtualApplicationGroupResource, please refer to the document of VirtualApplicationGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string applicationGroupName = "applicationGroup1";
            ResourceIdentifier virtualApplicationGroupResourceId = VirtualApplicationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGroupName);
            VirtualApplicationGroupResource virtualApplicationGroup = client.GetVirtualApplicationGroupResource(virtualApplicationGroupResourceId);

            // get the collection of this VirtualApplicationResource
            VirtualApplicationCollection collection = virtualApplicationGroup.GetVirtualApplications();

            // invoke the operation
            string applicationName = "application1";
            VirtualApplicationResource result = await collection.GetAsync(applicationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Application_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApplicationGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/Application_Get.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualApplicationGroupResource created on azure
            // for more information of creating VirtualApplicationGroupResource, please refer to the document of VirtualApplicationGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string applicationGroupName = "applicationGroup1";
            ResourceIdentifier virtualApplicationGroupResourceId = VirtualApplicationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGroupName);
            VirtualApplicationGroupResource virtualApplicationGroup = client.GetVirtualApplicationGroupResource(virtualApplicationGroupResourceId);

            // get the collection of this VirtualApplicationResource
            VirtualApplicationCollection collection = virtualApplicationGroup.GetVirtualApplications();

            // invoke the operation
            string applicationName = "application1";
            bool result = await collection.ExistsAsync(applicationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Application_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApplicationGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/Application_Get.json
            // this example is just showing the usage of "Applications_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualApplicationGroupResource created on azure
            // for more information of creating VirtualApplicationGroupResource, please refer to the document of VirtualApplicationGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string applicationGroupName = "applicationGroup1";
            ResourceIdentifier virtualApplicationGroupResourceId = VirtualApplicationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGroupName);
            VirtualApplicationGroupResource virtualApplicationGroup = client.GetVirtualApplicationGroupResource(virtualApplicationGroupResourceId);

            // get the collection of this VirtualApplicationResource
            VirtualApplicationCollection collection = virtualApplicationGroup.GetVirtualApplications();

            // invoke the operation
            string applicationName = "application1";
            NullableResponse<VirtualApplicationResource> response = await collection.GetIfExistsAsync(applicationName);
            VirtualApplicationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualApplicationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Application_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApplicationCreate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/Application_Create.json
            // this example is just showing the usage of "Applications_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualApplicationGroupResource created on azure
            // for more information of creating VirtualApplicationGroupResource, please refer to the document of VirtualApplicationGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string applicationGroupName = "applicationGroup1";
            ResourceIdentifier virtualApplicationGroupResourceId = VirtualApplicationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGroupName);
            VirtualApplicationGroupResource virtualApplicationGroup = client.GetVirtualApplicationGroupResource(virtualApplicationGroupResourceId);

            // get the collection of this VirtualApplicationResource
            VirtualApplicationCollection collection = virtualApplicationGroup.GetVirtualApplications();

            // invoke the operation
            string applicationName = "application1";
            VirtualApplicationData data = new VirtualApplicationData(VirtualApplicationCommandLineSetting.Allow)
            {
                Description = "des1",
                FriendlyName = "friendly",
                FilePath = "path",
                CommandLineArguments = "arguments",
                ShowInPortal = true,
                IconPath = "icon",
                IconIndex = 1,
            };
            ArmOperation<VirtualApplicationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, applicationName, data);
            VirtualApplicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualApplicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Applications_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApplicationsList()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/Application_List.json
            // this example is just showing the usage of "Applications_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualApplicationGroupResource created on azure
            // for more information of creating VirtualApplicationGroupResource, please refer to the document of VirtualApplicationGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string applicationGroupName = "applicationGroup1";
            ResourceIdentifier virtualApplicationGroupResourceId = VirtualApplicationGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, applicationGroupName);
            VirtualApplicationGroupResource virtualApplicationGroup = client.GetVirtualApplicationGroupResource(virtualApplicationGroupResourceId);

            // get the collection of this VirtualApplicationResource
            VirtualApplicationCollection collection = virtualApplicationGroup.GetVirtualApplications();

            // invoke the operation and iterate over the result
            int? pageSize = 10;
            bool? isDescending = true;
            int? initialSkip = 0;
            await foreach (VirtualApplicationResource item in collection.GetAllAsync(pageSize: pageSize, isDescending: isDescending, initialSkip: initialSkip))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualApplicationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
