// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> The source user image virtual hard disk. Only tags may be updated. </summary>
    public partial class ImageUpdate : UpdateResource
    {
        /// <summary> Initializes a new instance of ImageUpdate. </summary>
        public ImageUpdate()
        {
        }

        /// <summary> The source virtual machine from which Image is created. </summary>
        public WritableSubResource SourceVirtualMachine { get; set; }
        /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
        public ImageStorageProfile StorageProfile { get; set; }
        /// <summary> The provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Gets the HyperVGenerationType of the VirtualMachine created from the image. </summary>
        public HyperVGenerationTypes? HyperVGeneration { get; set; }
    }
}
