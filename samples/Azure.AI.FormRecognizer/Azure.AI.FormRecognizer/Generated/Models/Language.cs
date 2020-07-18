// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Language code. </summary>
    public readonly partial struct Language : IEquatable<Language>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Language"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> This occurs when <paramref name="value"/> is null. </exception>
        public Language(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnValue = "en";
        private const string EsValue = "es";

        /// <summary> en. </summary>
        public static Language En { get; } = new Language(EnValue);
        /// <summary> es. </summary>
        public static Language Es { get; } = new Language(EsValue);
        /// <summary> Determines if two <see cref="Language"/> values are the same. </summary>
        public static bool operator ==(Language left, Language right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Language"/> values are not the same. </summary>
        public static bool operator !=(Language left, Language right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Language"/>. </summary>
        public static implicit operator Language(string value) => new Language(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Language other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Language other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
