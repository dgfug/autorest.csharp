// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.Management.Storage
{
    /// <summary> A class representing collection of BlobContainer and their operations over a StorageAccount. </summary>
    public partial class BlobContainerContainer : ResourceContainerBase<BlobContainer, BlobContainerData>
    {
        /// <summary> Initializes a new instance of the <see cref="BlobContainerContainer"/> class for mocking. </summary>
        protected BlobContainerContainer()
        {
        }

        /// <summary> Initializes a new instance of BlobContainerContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BlobContainerContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private BlobContainersRestOperations _restClient => new BlobContainersRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => StorageAccountOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates a new container under the specified account as described by request body. The container resource includes metadata and properties for that container. It does not include a list of the blobs contained by the container. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="blobContainer"> Properties of the blob container to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="blobContainer"/> is null. </exception>
        public virtual Response<BlobContainer> CreateOrUpdate(string containerName, BlobContainerData blobContainer, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (blobContainer == null)
            {
                throw new ArgumentNullException(nameof(blobContainer));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(containerName, blobContainer, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new container under the specified account as described by request body. The container resource includes metadata and properties for that container. It does not include a list of the blobs contained by the container. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="blobContainer"> Properties of the blob container to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="blobContainer"/> is null. </exception>
        public async virtual Task<Response<BlobContainer>> CreateOrUpdateAsync(string containerName, BlobContainerData blobContainer, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (blobContainer == null)
            {
                throw new ArgumentNullException(nameof(blobContainer));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(containerName, blobContainer, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new container under the specified account as described by request body. The container resource includes metadata and properties for that container. It does not include a list of the blobs contained by the container. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="blobContainer"> Properties of the blob container to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="blobContainer"/> is null. </exception>
        public virtual BlobContainersCreateOperation StartCreateOrUpdate(string containerName, BlobContainerData blobContainer, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (blobContainer == null)
            {
                throw new ArgumentNullException(nameof(blobContainer));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Create(Id.ResourceGroupName, Id.Name, containerName, blobContainer, cancellationToken);
                return new BlobContainersCreateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new container under the specified account as described by request body. The container resource includes metadata and properties for that container. It does not include a list of the blobs contained by the container. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="blobContainer"> Properties of the blob container to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="blobContainer"/> is null. </exception>
        public async virtual Task<BlobContainersCreateOperation> StartCreateOrUpdateAsync(string containerName, BlobContainerData blobContainer, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (blobContainer == null)
            {
                throw new ArgumentNullException(nameof(blobContainer));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateAsync(Id.ResourceGroupName, Id.Name, containerName, blobContainer, cancellationToken).ConfigureAwait(false);
                return new BlobContainersCreateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<BlobContainer> Get(string containerName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.Get");
            scope.Start();
            try
            {
                if (containerName == null)
                {
                    throw new ArgumentNullException(nameof(containerName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, containerName, cancellationToken: cancellationToken);
                return Response.FromValue(new BlobContainer(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<BlobContainer>> GetAsync(string containerName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.Get");
            scope.Start();
            try
            {
                if (containerName == null)
                {
                    throw new ArgumentNullException(nameof(containerName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new BlobContainer(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual BlobContainer TryGet(string containerName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.TryGet");
            scope.Start();
            try
            {
                if (containerName == null)
                {
                    throw new ArgumentNullException(nameof(containerName));
                }

                return Get(containerName, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<BlobContainer> TryGetAsync(string containerName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.TryGet");
            scope.Start();
            try
            {
                if (containerName == null)
                {
                    throw new ArgumentNullException(nameof(containerName));
                }

                return await GetAsync(containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool CheckIfExists(string containerName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (containerName == null)
                {
                    throw new ArgumentNullException(nameof(containerName));
                }

                return TryGet(containerName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> CheckIfExistsAsync(string containerName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (containerName == null)
                {
                    throw new ArgumentNullException(nameof(containerName));
                }

                return await TryGetAsync(containerName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all containers and does not support a prefix like data plane. Also SRP today does not return continuation token. </summary>
        /// <param name="filter"> Optional. When specified, only container names starting with the filter will be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BlobContainer" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<BlobContainer> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<BlobContainer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, pageSizeHint, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobContainer(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BlobContainer> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, pageSizeHint, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobContainer(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all containers and does not support a prefix like data plane. Also SRP today does not return continuation token. </summary>
        /// <param name="filter"> Optional. When specified, only container names starting with the filter will be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BlobContainer" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<BlobContainer> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<BlobContainer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, pageSizeHint, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobContainer(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BlobContainer>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, pageSizeHint, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobContainer(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="BlobContainer" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BlobContainerOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="BlobContainer" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobContainerContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BlobContainerOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, BlobContainer, BlobContainerData> Construct() { }
    }
}
