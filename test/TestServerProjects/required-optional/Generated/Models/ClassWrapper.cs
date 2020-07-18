// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace required_optional.Models
{
    /// <summary> The ClassWrapper. </summary>
    public partial class ClassWrapper
    {
        /// <summary> Initializes a new instance of ClassWrapper. </summary>
        /// <param name="value"> . </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public ClassWrapper(Product value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        public Product Value { get; }
    }
}
