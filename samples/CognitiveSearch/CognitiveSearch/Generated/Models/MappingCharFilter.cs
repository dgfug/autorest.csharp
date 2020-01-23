// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace CognitiveSearch.Models
{
    /// <summary> A character filter that applies mappings defined with the mappings option. Matching is greedy (longest pattern matching at a given point wins). Replacement is allowed to be the empty string. This character filter is implemented using Apache Lucene. </summary>
    public partial class MappingCharFilter : CharFilter
    {
        /// <summary> Initializes a new instance of MappingCharFilter. </summary>
        public MappingCharFilter()
        {
            OdataType = "#Microsoft.Azure.Search.MappingCharFilter";
        }
        /// <summary> A list of mappings of the following format: &quot;a=&gt;b&quot; (all occurrences of the character &quot;a&quot; will be replaced with character &quot;b&quot;). </summary>
        public ICollection<string> Mappings { get; set; } = new List<string>();
    }
}
