// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace CognitiveSearch.Models
{
    /// <summary> Defines a function that boosts scores based on distance from a geographic location. </summary>
    public partial class DistanceScoringFunction : ScoringFunction
    {
        /// <summary> Initializes a new instance of DistanceScoringFunction. </summary>
        public DistanceScoringFunction()
        {
            Type = "distance";
        }
        /// <summary> Provides parameter values to a distance scoring function. </summary>
        public DistanceScoringParameters Parameters { get; set; } = new DistanceScoringParameters();
    }
}
