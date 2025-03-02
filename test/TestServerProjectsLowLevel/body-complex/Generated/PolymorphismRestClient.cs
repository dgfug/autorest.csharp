// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace body_complex_LowLevel
{
    /// <summary> The PolymorphismRest service client. </summary>
    internal partial class PolymorphismRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of PolymorphismRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public PolymorphismRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("http://localhost:3000");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetValidRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/polymorphism/valid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get complex types that are polymorphic. </summary>
        /// <param name="options"> The request options. </param>
        public async Task<Response> GetValidAsync(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetValidRequest();
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Get complex types that are polymorphic. </summary>
        /// <param name="options"> The request options. </param>
        public Response GetValid(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetValidRequest();
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreatePutValidRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/polymorphism/valid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Put complex types that are polymorphic. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public async Task<Response> PutValidAsync(RequestContent content, RequestOptions options = null)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreatePutValidRequest(content);
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Put complex types that are polymorphic. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public Response PutValid(RequestContent content, RequestOptions options = null)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreatePutValidRequest(content);
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreateGetDotSyntaxRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/polymorphism/dotsyntax", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get complex types that are polymorphic, JSON key contains a dot. </summary>
        /// <param name="options"> The request options. </param>
        public async Task<Response> GetDotSyntaxAsync(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetDotSyntaxRequest();
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Get complex types that are polymorphic, JSON key contains a dot. </summary>
        /// <param name="options"> The request options. </param>
        public Response GetDotSyntax(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetDotSyntaxRequest();
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreateGetComposedWithDiscriminatorRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/polymorphism/composedWithDiscriminator", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, with discriminator specified. Deserialization must NOT fail and use the discriminator type specified on the wire. </summary>
        /// <param name="options"> The request options. </param>
        public async Task<Response> GetComposedWithDiscriminatorAsync(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetComposedWithDiscriminatorRequest();
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, with discriminator specified. Deserialization must NOT fail and use the discriminator type specified on the wire. </summary>
        /// <param name="options"> The request options. </param>
        public Response GetComposedWithDiscriminator(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetComposedWithDiscriminatorRequest();
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreateGetComposedWithoutDiscriminatorRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/polymorphism/composedWithoutDiscriminator", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, without discriminator specified on wire. Deserialization must NOT fail and use the explicit type of the property. </summary>
        /// <param name="options"> The request options. </param>
        public async Task<Response> GetComposedWithoutDiscriminatorAsync(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetComposedWithoutDiscriminatorRequest();
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, without discriminator specified on wire. Deserialization must NOT fail and use the explicit type of the property. </summary>
        /// <param name="options"> The request options. </param>
        public Response GetComposedWithoutDiscriminator(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetComposedWithoutDiscriminatorRequest();
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreateGetComplicatedRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/polymorphism/complicated", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="options"> The request options. </param>
        public async Task<Response> GetComplicatedAsync(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetComplicatedRequest();
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Get complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="options"> The request options. </param>
        public Response GetComplicated(RequestOptions options = null)
        {
            options ??= new RequestOptions();
            using HttpMessage message = CreateGetComplicatedRequest();
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreatePutComplicatedRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/polymorphism/complicated", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Put complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public async Task<Response> PutComplicatedAsync(RequestContent content, RequestOptions options = null)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreatePutComplicatedRequest(content);
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Put complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public Response PutComplicated(RequestContent content, RequestOptions options = null)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreatePutComplicatedRequest(content);
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreatePutMissingDiscriminatorRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/polymorphism/missingdiscriminator", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Put complex types that are polymorphic, omitting the discriminator. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public async Task<Response> PutMissingDiscriminatorAsync(RequestContent content, RequestOptions options = null)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreatePutMissingDiscriminatorRequest(content);
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Put complex types that are polymorphic, omitting the discriminator. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public Response PutMissingDiscriminator(RequestContent content, RequestOptions options = null)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreatePutMissingDiscriminatorRequest(content);
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }

        internal HttpMessage CreatePutValidMissingRequiredRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/complex/polymorphism/missingrequired/invalid", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        /// <summary> Put complex types that are polymorphic, attempting to omit required &apos;birthday&apos; field - the request should not be allowed from the client. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public async Task<Response> PutValidMissingRequiredAsync(RequestContent content, RequestOptions options = null)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreatePutValidMissingRequiredRequest(content);
            RequestOptions.Apply(options, message);
            await _pipeline.SendAsync(message, options.CancellationToken).ConfigureAwait(false);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            else
            {
                return message.Response;
            }
        }

        /// <summary> Put complex types that are polymorphic, attempting to omit required &apos;birthday&apos; field - the request should not be allowed from the client. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public Response PutValidMissingRequired(RequestContent content, RequestOptions options = null)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            options ??= new RequestOptions();
            using HttpMessage message = CreatePutValidMissingRequiredRequest(content);
            RequestOptions.Apply(options, message);
            _pipeline.Send(message, options.CancellationToken);
            if (options.StatusOption == ResponseStatusOption.Default)
            {
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            else
            {
                return message.Response;
            }
        }
    }
}
