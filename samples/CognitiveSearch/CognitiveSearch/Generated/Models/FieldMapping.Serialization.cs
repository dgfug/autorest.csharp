// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class FieldMapping : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceFieldName");
            writer.WriteStringValue(SourceFieldName);
            if (TargetFieldName != null)
            {
                writer.WritePropertyName("targetFieldName");
                writer.WriteStringValue(TargetFieldName);
            }
            if (MappingFunction != null)
            {
                writer.WritePropertyName("mappingFunction");
                writer.WriteObjectValue(MappingFunction);
            }
            writer.WriteEndObject();
        }
        internal static FieldMapping DeserializeFieldMapping(JsonElement element)
        {
            FieldMapping result = new FieldMapping();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceFieldName"))
                {
                    result.SourceFieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetFieldName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.TargetFieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mappingFunction"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MappingFunction = FieldMappingFunction.DeserializeFieldMappingFunction(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}
