// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class StemmerOverrideTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("rules");
            writer.WriteStartArray();
            foreach (var item in Rules)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
        internal static StemmerOverrideTokenFilter DeserializeStemmerOverrideTokenFilter(JsonElement element)
        {
            StemmerOverrideTokenFilter result = new StemmerOverrideTokenFilter();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rules"))
                {
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Rules.Add(item.GetString());
                    }
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
