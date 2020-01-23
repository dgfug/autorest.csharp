// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace CognitiveSearch.Models
{
    /// <summary> The result of testing an analyzer on text. </summary>
    public partial class AnalyzeResult
    {
        /// <summary> The list of tokens returned by the analyzer specified in the request. </summary>
        public ICollection<TokenInfo>? Tokens { get; set; }
    }
}
