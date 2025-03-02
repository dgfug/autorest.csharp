// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class VirtualMachineCaptureParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("vhdPrefix");
            writer.WriteStringValue(VhdPrefix);
            writer.WritePropertyName("destinationContainerName");
            writer.WriteStringValue(DestinationContainerName);
            writer.WritePropertyName("overwriteVhds");
            writer.WriteBooleanValue(OverwriteVhds);
            writer.WriteEndObject();
        }
    }
}
