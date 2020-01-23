// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class SynonymTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("synonyms");
            writer.WriteStartArray();
            foreach (var item in Synonyms)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (IgnoreCase != null)
            {
                writer.WritePropertyName("ignoreCase");
                writer.WriteBooleanValue(IgnoreCase.Value);
            }
            if (Expand != null)
            {
                writer.WritePropertyName("expand");
                writer.WriteBooleanValue(Expand.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
        internal static SynonymTokenFilter DeserializeSynonymTokenFilter(JsonElement element)
        {
            SynonymTokenFilter result = new SynonymTokenFilter();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("synonyms"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Synonyms.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("ignoreCase"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IgnoreCase = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("expand"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Expand = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    result.OdataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
