// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace MgmtDiscriminator
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DeliveryRules in the ResourceGroup. </summary>
        /// <returns> An object representing collection of DeliveryRules and their operations over a DeliveryRule. </returns>
        public virtual DeliveryRuleCollection GetDeliveryRules()
        {
            return GetCachedClient(Client => new DeliveryRuleCollection(Client, Id));
        }
    }
}
