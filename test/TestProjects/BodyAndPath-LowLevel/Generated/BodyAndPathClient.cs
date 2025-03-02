// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace BodyAndPath_LowLevel
{
    /// <summary> The BodyAndPath service client. </summary>
    public partial class BodyAndPathClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }
        private HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly BodyAndPathRestClient _restClient;
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;

        /// <summary> Initializes a new instance of BodyAndPathClient for mocking. </summary>
        protected BodyAndPathClient()
        {
        }

        /// <summary> Initializes a new instance of BodyAndPathClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public BodyAndPathClient(AzureKeyCredential credential, Uri endpoint = null, BodyAndPathClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("http://localhost:3000");

            options ??= new BodyAndPathClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            var authPolicy = new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader);
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            _restClient = new BodyAndPathRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemName"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateAsync(string itemName, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.Create");
            scope.Start();
            try
            {
                return await _restClient.CreateAsync(itemName, content, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemName"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response Create(string itemName, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.Create");
            scope.Start();
            try
            {
                return _restClient.Create(itemName, content, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemNameStream"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot;. </param>
        /// <param name="excluded"> Excluded connection Ids. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateStreamAsync(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.CreateStream");
            scope.Start();
            try
            {
                return await _restClient.CreateStreamAsync(itemNameStream, content, contentType, excluded, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemNameStream"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot;. </param>
        /// <param name="excluded"> Excluded connection Ids. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CreateStream(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.CreateStream");
            scope.Start();
            try
            {
                return _restClient.CreateStream(itemNameStream, content, contentType, excluded, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="enumName1"> The first name. Allowed values: &quot;current&quot; | &quot;default&quot;. </param>
        /// <param name="enumName2"> The second name. Allowed values: &quot;latest&quot;. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateEnumAsync(string enumName1, string enumName2, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.CreateEnum");
            scope.Start();
            try
            {
                return await _restClient.CreateEnumAsync(enumName1, enumName2, content, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="enumName1"> The first name. Allowed values: &quot;current&quot; | &quot;default&quot;. </param>
        /// <param name="enumName2"> The second name. Allowed values: &quot;latest&quot;. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response CreateEnum(string enumName1, string enumName2, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.CreateEnum");
            scope.Start();
            try
            {
                return _restClient.CreateEnum(enumName1, enumName2, content, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
