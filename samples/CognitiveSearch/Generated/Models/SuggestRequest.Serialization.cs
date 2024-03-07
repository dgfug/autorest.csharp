// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using CognitiveSearch;

namespace CognitiveSearch.Models
{
    public partial class SuggestRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStringValue(Filter);
            }
            if (Optional.IsDefined(UseFuzzyMatching))
            {
                writer.WritePropertyName("fuzzy"u8);
                writer.WriteBooleanValue(UseFuzzyMatching.Value);
            }
            if (Optional.IsDefined(HighlightPostTag))
            {
                writer.WritePropertyName("highlightPostTag"u8);
                writer.WriteStringValue(HighlightPostTag);
            }
            if (Optional.IsDefined(HighlightPreTag))
            {
                writer.WritePropertyName("highlightPreTag"u8);
                writer.WriteStringValue(HighlightPreTag);
            }
            if (Optional.IsDefined(MinimumCoverage))
            {
                writer.WritePropertyName("minimumCoverage"u8);
                writer.WriteNumberValue(MinimumCoverage.Value);
            }
            if (Optional.IsDefined(OrderBy))
            {
                writer.WritePropertyName("orderby"u8);
                writer.WriteStringValue(OrderBy);
            }
            writer.WritePropertyName("search"u8);
            writer.WriteStringValue(SearchText);
            if (Optional.IsDefined(SearchFields))
            {
                writer.WritePropertyName("searchFields"u8);
                writer.WriteStringValue(SearchFields);
            }
            if (Optional.IsDefined(Select))
            {
                writer.WritePropertyName("select"u8);
                writer.WriteStringValue(Select);
            }
            writer.WritePropertyName("suggesterName"u8);
            writer.WriteStringValue(SuggesterName);
            if (Optional.IsDefined(Top))
            {
                writer.WritePropertyName("top"u8);
                writer.WriteNumberValue(Top.Value);
            }
            writer.WriteEndObject();
        }
    }
}
