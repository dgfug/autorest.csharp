// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;

namespace AdditionalPropertiesEx.Models
{
    /// <summary> The OutputAdditionalPropertiesModelStruct. </summary>
    public readonly partial struct OutputAdditionalPropertiesModelStruct : IReadOnlyDictionary<string, string>
    {
        /// <summary> Initializes a new instance of OutputAdditionalPropertiesModelStruct. </summary>
        /// <param name="id"> . </param>
        /// <param name="additionalProperties"> . </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        internal OutputAdditionalPropertiesModelStruct(int id, IReadOnlyDictionary<string, string> additionalProperties)
        {
            if (additionalProperties == null)
            {
                throw new ArgumentNullException(nameof(additionalProperties));
            }

            Id = id;
            AdditionalProperties = additionalProperties;
        }

        public int Id { get; }
        internal IReadOnlyDictionary<string, string> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out string value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public IEnumerable<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public IEnumerable<string> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int IReadOnlyCollection<KeyValuePair<string, string>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public string this[string key]
        {
            get => AdditionalProperties[key];
        }
    }
}
