// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core.Extensions;
using lrotsp;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="LroClient"/> to client builder. </summary>
    public static partial class LrotspClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="LroClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        public static IAzureClientBuilder<LroClient, LroClientOptions> AddLroClient<TBuilder>(this TBuilder builder, Uri endpoint, AzureKeyCredential credential)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<LroClient, LroClientOptions>((options) => new LroClient(endpoint, credential, options));
        }

        /// <summary> Registers a <see cref="LroClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        public static IAzureClientBuilder<LroClient, LroClientOptions> AddLroClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<LroClient, LroClientOptions>((options, cred) => new LroClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="LroClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<LroClient, LroClientOptions> AddLroClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<LroClient, LroClientOptions>(configuration);
        }
    }
}
