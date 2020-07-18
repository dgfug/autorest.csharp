// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Storage.Models;

namespace Azure.Management.Storage
{
    internal partial class FileServicesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of FileServicesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public FileServicesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2019-06-01")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateListRequest(string resourceGroupName, string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/fileServices", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> List all file services in storage accounts. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public async Task<Response<FileServiceItems>> ListAsync(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateListRequest(resourceGroupName, accountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileServiceItems value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FileServiceItems.DeserializeFileServiceItems(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> List all file services in storage accounts. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public Response<FileServiceItems> List(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateListRequest(resourceGroupName, accountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileServiceItems value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FileServiceItems.DeserializeFileServiceItems(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateSetServicePropertiesRequest(string resourceGroupName, string accountName, CorsRules cors, DeleteRetentionPolicy shareDeleteRetentionPolicy)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/fileServices/", false);
            uri.AppendPath("default", true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var model = new FileServiceProperties()
            {
                Cors = cors,
                ShareDeleteRetentionPolicy = shareDeleteRetentionPolicy
            };
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Sets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cors"> Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service. </param>
        /// <param name="shareDeleteRetentionPolicy"> The file service properties for share soft delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public async Task<Response<FileServiceProperties>> SetServicePropertiesAsync(string resourceGroupName, string accountName, CorsRules cors = null, DeleteRetentionPolicy shareDeleteRetentionPolicy = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateSetServicePropertiesRequest(resourceGroupName, accountName, cors, shareDeleteRetentionPolicy);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileServiceProperties value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FileServiceProperties.DeserializeFileServiceProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Sets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cors"> Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service. </param>
        /// <param name="shareDeleteRetentionPolicy"> The file service properties for share soft delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public Response<FileServiceProperties> SetServiceProperties(string resourceGroupName, string accountName, CorsRules cors = null, DeleteRetentionPolicy shareDeleteRetentionPolicy = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateSetServicePropertiesRequest(resourceGroupName, accountName, cors, shareDeleteRetentionPolicy);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileServiceProperties value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FileServiceProperties.DeserializeFileServiceProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetServicePropertiesRequest(string resourceGroupName, string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/fileServices/", false);
            uri.AppendPath("default", true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Gets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public async Task<Response<FileServiceProperties>> GetServicePropertiesAsync(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateGetServicePropertiesRequest(resourceGroupName, accountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileServiceProperties value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FileServiceProperties.DeserializeFileServiceProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="resourceGroupName"> The name of the resource group within the user&apos;s subscription. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public Response<FileServiceProperties> GetServiceProperties(string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateGetServicePropertiesRequest(resourceGroupName, accountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FileServiceProperties value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FileServiceProperties.DeserializeFileServiceProperties(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
