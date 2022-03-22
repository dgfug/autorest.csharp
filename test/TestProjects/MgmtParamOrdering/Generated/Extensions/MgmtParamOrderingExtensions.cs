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
using Azure.ResourceManager.Resources;
using MgmtParamOrdering.Models;

namespace MgmtParamOrdering
{
    /// <summary> A class to add extension methods to MgmtParamOrdering. </summary>
    public static partial class MgmtParamOrderingExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary> Gets a collection of VirtualMachineExtensionImages in the Subscription. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="publisherName"/> is null. </exception>
        /// <returns> An object representing collection of VirtualMachineExtensionImages and their operations over a VirtualMachineExtensionImage. </returns>
        public static VirtualMachineExtensionImageCollection GetVirtualMachineExtensionImages(this Subscription subscription, string location, string publisherName)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(publisherName, nameof(publisherName));

            return GetExtensionClient(subscription).GetVirtualMachineExtensionImages(location, publisherName);
        }

        /// <summary>
        /// Gets a virtual machine extension image.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions/{version}
        /// Operation Id: VirtualMachineExtensionImages_Get
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/>, <paramref name="publisherName"/>, <paramref name="type"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="publisherName"/>, <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public static async Task<Response<VirtualMachineExtensionImage>> GetVirtualMachineExtensionImageAsync(this Subscription subscription, string location, string publisherName, string type, string version, CancellationToken cancellationToken = default)
        {
            return await subscription.GetVirtualMachineExtensionImages(location, publisherName).GetAsync(type, version, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a virtual machine extension image.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/publishers/{publisherName}/artifacttypes/vmextension/types/{type}/versions/{version}
        /// Operation Id: VirtualMachineExtensionImages_Get
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/>, <paramref name="publisherName"/>, <paramref name="type"/> or <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="publisherName"/>, <paramref name="type"/> or <paramref name="version"/> is null. </exception>
        public static Response<VirtualMachineExtensionImage> GetVirtualMachineExtensionImage(this Subscription subscription, string location, string publisherName, string type, string version, CancellationToken cancellationToken = default)
        {
            return subscription.GetVirtualMachineExtensionImages(location, publisherName).Get(type, version, cancellationToken);
        }

        /// <summary>
        /// Lists all availability sets in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/availabilitySets
        /// Operation Id: AvailabilitySets_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="expand"> The expand expression to apply to the operation. Allowed values are &apos;instanceView&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailabilitySet" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AvailabilitySet> GetAvailabilitySetsAsync(this Subscription subscription, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetAvailabilitySetsAsync(expand, cancellationToken);
        }

        /// <summary>
        /// Lists all availability sets in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/availabilitySets
        /// Operation Id: AvailabilitySets_ListBySubscription
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="expand"> The expand expression to apply to the operation. Allowed values are &apos;instanceView&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailabilitySet" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AvailabilitySet> GetAvailabilitySets(this Subscription subscription, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscription).GetAvailabilitySets(expand, cancellationToken);
        }

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of AvailabilitySets in the ResourceGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AvailabilitySets and their operations over a AvailabilitySet. </returns>
        public static AvailabilitySetCollection GetAvailabilitySets(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetAvailabilitySets();
        }

        /// <summary>
        /// Retrieves information about an availability set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}
        /// Operation Id: AvailabilitySets_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public static async Task<Response<AvailabilitySet>> GetAvailabilitySetAsync(this ResourceGroup resourceGroup, string availabilitySetName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetAvailabilitySets().GetAsync(availabilitySetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information about an availability set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}
        /// Operation Id: AvailabilitySets_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        public static Response<AvailabilitySet> GetAvailabilitySet(this ResourceGroup resourceGroup, string availabilitySetName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetAvailabilitySets().Get(availabilitySetName, cancellationToken);
        }

        /// <summary> Gets a collection of DedicatedHostGroups in the ResourceGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DedicatedHostGroups and their operations over a DedicatedHostGroup. </returns>
        public static DedicatedHostGroupCollection GetDedicatedHostGroups(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetDedicatedHostGroups();
        }

        /// <summary>
        /// Retrieves information about a dedicated host group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}
        /// Operation Id: DedicatedHostGroups_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public static async Task<Response<DedicatedHostGroup>> GetDedicatedHostGroupAsync(this ResourceGroup resourceGroup, string hostGroupName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetDedicatedHostGroups().GetAsync(hostGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information about a dedicated host group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}
        /// Operation Id: DedicatedHostGroups_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="hostGroupName"> The name of the dedicated host group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostGroupName"/> is null. </exception>
        public static Response<DedicatedHostGroup> GetDedicatedHostGroup(this ResourceGroup resourceGroup, string hostGroupName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetDedicatedHostGroups().Get(hostGroupName, cancellationToken);
        }

        /// <summary> Gets a collection of Workspaces in the ResourceGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of Workspaces and their operations over a Workspace. </returns>
        public static WorkspaceCollection GetWorkspaces(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetWorkspaces();
        }

        /// <summary>
        /// Gets the properties of the specified machine learning workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
        /// Operation Id: Workspaces_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public static async Task<Response<Workspace>> GetWorkspaceAsync(this ResourceGroup resourceGroup, string workspaceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetWorkspaces().GetAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified machine learning workspace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}
        /// Operation Id: Workspaces_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        public static Response<Workspace> GetWorkspace(this ResourceGroup resourceGroup, string workspaceName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetWorkspaces().Get(workspaceName, cancellationToken);
        }

        /// <summary> Gets a collection of VirtualMachineScaleSets in the ResourceGroup. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VirtualMachineScaleSets and their operations over a VirtualMachineScaleSet. </returns>
        public static VirtualMachineScaleSetCollection GetVirtualMachineScaleSets(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetVirtualMachineScaleSets();
        }

        /// <summary>
        /// Display information about a virtual machine scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;UserData&apos; retrieves the UserData property of the VM scale set that was provided by the user during the VM scale set Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public static async Task<Response<VirtualMachineScaleSet>> GetVirtualMachineScaleSetAsync(this ResourceGroup resourceGroup, string vmScaleSetName, ExpandTypesForGetVMScaleSets? expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetVirtualMachineScaleSets().GetAsync(vmScaleSetName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Display information about a virtual machine scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;UserData&apos; retrieves the UserData property of the VM scale set that was provided by the user during the VM scale set Create/Update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public static Response<VirtualMachineScaleSet> GetVirtualMachineScaleSet(this ResourceGroup resourceGroup, string vmScaleSetName, ExpandTypesForGetVMScaleSets? expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetVirtualMachineScaleSets().Get(vmScaleSetName, expand, cancellationToken);
        }

        #region AvailabilitySet
        /// <summary>
        /// Gets an object representing an <see cref="AvailabilitySet" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AvailabilitySet.CreateResourceIdentifier" /> to create an <see cref="AvailabilitySet" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AvailabilitySet" /> object. </returns>
        public static AvailabilitySet GetAvailabilitySet(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AvailabilitySet.ValidateResourceId(id);
                return new AvailabilitySet(client, id);
            }
            );
        }
        #endregion

        #region DedicatedHostGroup
        /// <summary>
        /// Gets an object representing a <see cref="DedicatedHostGroup" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DedicatedHostGroup.CreateResourceIdentifier" /> to create a <see cref="DedicatedHostGroup" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DedicatedHostGroup" /> object. </returns>
        public static DedicatedHostGroup GetDedicatedHostGroup(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DedicatedHostGroup.ValidateResourceId(id);
                return new DedicatedHostGroup(client, id);
            }
            );
        }
        #endregion

        #region DedicatedHost
        /// <summary>
        /// Gets an object representing a <see cref="DedicatedHost" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DedicatedHost.CreateResourceIdentifier" /> to create a <see cref="DedicatedHost" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DedicatedHost" /> object. </returns>
        public static DedicatedHost GetDedicatedHost(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DedicatedHost.ValidateResourceId(id);
                return new DedicatedHost(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineExtensionImage
        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineExtensionImage" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineExtensionImage.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineExtensionImage" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineExtensionImage" /> object. </returns>
        public static VirtualMachineExtensionImage GetVirtualMachineExtensionImage(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VirtualMachineExtensionImage.ValidateResourceId(id);
                return new VirtualMachineExtensionImage(client, id);
            }
            );
        }
        #endregion

        #region EnvironmentContainerResource
        /// <summary>
        /// Gets an object representing an <see cref="EnvironmentContainerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="EnvironmentContainerResource.CreateResourceIdentifier" /> to create an <see cref="EnvironmentContainerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EnvironmentContainerResource" /> object. </returns>
        public static EnvironmentContainerResource GetEnvironmentContainerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                EnvironmentContainerResource.ValidateResourceId(id);
                return new EnvironmentContainerResource(client, id);
            }
            );
        }
        #endregion

        #region Workspace
        /// <summary>
        /// Gets an object representing a <see cref="Workspace" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="Workspace.CreateResourceIdentifier" /> to create a <see cref="Workspace" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Workspace" /> object. </returns>
        public static Workspace GetWorkspace(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                Workspace.ValidateResourceId(id);
                return new Workspace(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineScaleSet
        /// <summary>
        /// Gets an object representing a <see cref="VirtualMachineScaleSet" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="VirtualMachineScaleSet.CreateResourceIdentifier" /> to create a <see cref="VirtualMachineScaleSet" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSet" /> object. </returns>
        public static VirtualMachineScaleSet GetVirtualMachineScaleSet(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VirtualMachineScaleSet.ValidateResourceId(id);
                return new VirtualMachineScaleSet(client, id);
            }
            );
        }
        #endregion
    }
}
