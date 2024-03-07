// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtMockAndSample.Models;

namespace MgmtMockAndSample
{
    /// <summary> A class representing the DeletedManagedHsm data model. </summary>
    public partial class DeletedManagedHsmData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DeletedManagedHsmData"/>. </summary>
        internal DeletedManagedHsmData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeletedManagedHsmData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the deleted managed HSM. </param>
        internal DeletedManagedHsmData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DeletedManagedHsmProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the deleted managed HSM. </summary>
        public DeletedManagedHsmProperties Properties { get; }
    }
}
