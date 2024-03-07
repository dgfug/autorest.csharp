// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace ModelsTypeSpec.Models
{
    /// <summary> Second derived model as an output. </summary>
    public partial class SecondDerivedOutputModel : OutputBaseModelWithDiscriminator
    {
        /// <summary> Initializes a new instance of <see cref="SecondDerivedOutputModel"/>. </summary>
        /// <param name="second"></param>
        internal SecondDerivedOutputModel(bool second)
        {
            Kind = "second";
            Second = second;
        }

        /// <summary> Initializes a new instance of <see cref="SecondDerivedOutputModel"/>. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="second"></param>
        internal SecondDerivedOutputModel(string kind, IDictionary<string, BinaryData> serializedAdditionalRawData, bool second) : base(kind, serializedAdditionalRawData)
        {
            Second = second;
        }

        /// <summary> Initializes a new instance of <see cref="SecondDerivedOutputModel"/> for deserialization. </summary>
        internal SecondDerivedOutputModel()
        {
        }

        /// <summary> Gets the second. </summary>
        public bool Second { get; }
    }
}
