// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace azure_special_properties
{
    internal partial class SubscriptionInMethodRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of SubscriptionInMethodRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public SubscriptionInMethodRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("http://localhost:3000");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreatePostMethodLocalValidRequest(string subscriptionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/azurespecials/subscriptionId/method/string/none/path/local/1234-5678-9012-3456/", false);
            uri.AppendPath(subscriptionId, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="subscriptionId"> This should appear as a method parameter, use value &apos;1234-5678-9012-3456&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public async Task<Response> PostMethodLocalValidAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreatePostMethodLocalValidRequest(subscriptionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="subscriptionId"> This should appear as a method parameter, use value &apos;1234-5678-9012-3456&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public Response PostMethodLocalValid(string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreatePostMethodLocalValidRequest(subscriptionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostMethodLocalNullRequest(string subscriptionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/azurespecials/subscriptionId/method/string/none/path/local/null/", false);
            uri.AppendPath(subscriptionId, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = null, client-side validation should prevent you from making this call. </summary>
        /// <param name="subscriptionId"> This should appear as a method parameter, use value null, client-side validation should prvenet the call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public async Task<Response> PostMethodLocalNullAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreatePostMethodLocalNullRequest(subscriptionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = null, client-side validation should prevent you from making this call. </summary>
        /// <param name="subscriptionId"> This should appear as a method parameter, use value null, client-side validation should prvenet the call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public Response PostMethodLocalNull(string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreatePostMethodLocalNullRequest(subscriptionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostPathLocalValidRequest(string subscriptionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/azurespecials/subscriptionId/path/string/none/path/local/1234-5678-9012-3456/", false);
            uri.AppendPath(subscriptionId, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="subscriptionId"> Should appear as a method parameter -use value &apos;1234-5678-9012-3456&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public async Task<Response> PostPathLocalValidAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreatePostPathLocalValidRequest(subscriptionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="subscriptionId"> Should appear as a method parameter -use value &apos;1234-5678-9012-3456&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public Response PostPathLocalValid(string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreatePostPathLocalValidRequest(subscriptionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePostSwaggerLocalValidRequest(string subscriptionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/azurespecials/subscriptionId/swagger/string/none/path/local/1234-5678-9012-3456/", false);
            uri.AppendPath(subscriptionId, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="subscriptionId"> The subscriptionId, which appears in the path, the value is always &apos;1234-5678-9012-3456&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public async Task<Response> PostSwaggerLocalValidAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreatePostSwaggerLocalValidRequest(subscriptionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> POST method with subscriptionId modeled in the method.  pass in subscription id = &apos;1234-5678-9012-3456&apos; to succeed. </summary>
        /// <param name="subscriptionId"> The subscriptionId, which appears in the path, the value is always &apos;1234-5678-9012-3456&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public Response PostSwaggerLocalValid(string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreatePostSwaggerLocalValidRequest(subscriptionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
