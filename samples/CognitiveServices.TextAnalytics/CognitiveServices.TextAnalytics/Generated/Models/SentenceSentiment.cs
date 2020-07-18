// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace CognitiveServices.TextAnalytics.Models
{
    /// <summary> The SentenceSentiment. </summary>
    public partial class SentenceSentiment
    {
        /// <summary> Initializes a new instance of SentenceSentiment. </summary>
        /// <param name="sentiment"> The predicted Sentiment for the sentence. </param>
        /// <param name="sentenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence by Unicode standard. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        internal SentenceSentiment(SentenceSentimentValue sentiment, SentimentConfidenceScorePerLabel sentenceScores, int offset, int length)
        {
            if (sentenceScores == null)
            {
                throw new ArgumentNullException(nameof(sentenceScores));
            }

            Sentiment = sentiment;
            SentenceScores = sentenceScores;
            Offset = offset;
            Length = length;
            Warnings = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SentenceSentiment. </summary>
        /// <param name="sentiment"> The predicted Sentiment for the sentence. </param>
        /// <param name="sentenceScores"> The sentiment confidence score between 0 and 1 for the sentence for all classes. </param>
        /// <param name="offset"> The sentence offset from the start of the document. </param>
        /// <param name="length"> The length of the sentence by Unicode standard. </param>
        /// <param name="warnings"> The warnings generated for the sentence. </param>
        internal SentenceSentiment(SentenceSentimentValue sentiment, SentimentConfidenceScorePerLabel sentenceScores, int offset, int length, IReadOnlyList<string> warnings)
        {
            Sentiment = sentiment;
            SentenceScores = sentenceScores;
            Offset = offset;
            Length = length;
            Warnings = warnings;
        }

        /// <summary> The predicted Sentiment for the sentence. </summary>
        public SentenceSentimentValue Sentiment { get; }
        /// <summary> The sentiment confidence score between 0 and 1 for the sentence for all classes. </summary>
        public SentimentConfidenceScorePerLabel SentenceScores { get; }
        /// <summary> The sentence offset from the start of the document. </summary>
        public int Offset { get; }
        /// <summary> The length of the sentence by Unicode standard. </summary>
        public int Length { get; }
        /// <summary> The warnings generated for the sentence. </summary>
        public IReadOnlyList<string> Warnings { get; }
    }
}
