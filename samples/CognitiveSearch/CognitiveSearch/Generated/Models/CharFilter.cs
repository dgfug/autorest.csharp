// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    /// <summary> Base type for character filters. </summary>
    public partial class CharFilter
    {
        /// <summary> Initializes a new instance of CharFilter. </summary>
        /// <param name="name"> The name of the char filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public CharFilter(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of CharFilter. </summary>
        /// <param name="odataType"> Identifies the concrete type of the char filter. </param>
        /// <param name="name"> The name of the char filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal CharFilter(string odataType, string name)
        {
            OdataType = odataType;
            Name = name;
        }

        /// <summary> Identifies the concrete type of the char filter. </summary>
        internal string OdataType { get; set; }
        /// <summary> The name of the char filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </summary>
        public string Name { get; set; }
    }
}
