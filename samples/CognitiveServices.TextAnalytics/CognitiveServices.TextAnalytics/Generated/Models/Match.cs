// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The Match. </summary>
    public partial class Match
    {
        /// <summary> Initializes a new instance of Match. </summary>
        /// <param name="score"> If a well-known item is recognized, a decimal number denoting the confidence level between 0 and 1 will be returned. </param>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="offset"> Start position (in Unicode characters) for the entity match text. </param>
        /// <param name="length"> Length (in Unicode characters) for the entity match text. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        internal Match(double score, string text, int offset, int length)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            Score = score;
            Text = text;
            Offset = offset;
            Length = length;
        }

        /// <summary> If a well-known item is recognized, a decimal number denoting the confidence level between 0 and 1 will be returned. </summary>
        public double Score { get; }
        /// <summary> Entity text as appears in the request. </summary>
        public string Text { get; }
        /// <summary> Start position (in Unicode characters) for the entity match text. </summary>
        public int Offset { get; }
        /// <summary> Length (in Unicode characters) for the entity match text. </summary>
        public int Length { get; }
    }
}
