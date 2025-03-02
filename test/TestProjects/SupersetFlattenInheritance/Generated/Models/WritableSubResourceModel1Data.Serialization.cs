// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace SupersetFlattenInheritance
{
    public partial class WritableSubResourceModel1Data : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Foo))
            {
                writer.WritePropertyName("foo");
                writer.WriteStringValue(Foo);
            }
            writer.WriteEndObject();
        }

        internal static WritableSubResourceModel1Data DeserializeWritableSubResourceModel1Data(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> foo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("foo"))
                {
                    foo = property.Value.GetString();
                    continue;
                }
            }
            return new WritableSubResourceModel1Data(id.Value, foo.Value);
        }
    }
}
