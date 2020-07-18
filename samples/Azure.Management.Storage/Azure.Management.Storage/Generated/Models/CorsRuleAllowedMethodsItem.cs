// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Storage.Models
{
    /// <summary> The CorsRuleAllowedMethodsItem. </summary>
    public readonly partial struct CorsRuleAllowedMethodsItem : IEquatable<CorsRuleAllowedMethodsItem>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CorsRuleAllowedMethodsItem"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> This occurs when <paramref name="value"/> is null. </exception>
        public CorsRuleAllowedMethodsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeleteValue = "DELETE";
        private const string GETValue = "GET";
        private const string HeadValue = "HEAD";
        private const string MergeValue = "MERGE";
        private const string PostValue = "POST";
        private const string OptionsValue = "OPTIONS";
        private const string PUTValue = "PUT";

        /// <summary> DELETE. </summary>
        public static CorsRuleAllowedMethodsItem Delete { get; } = new CorsRuleAllowedMethodsItem(DeleteValue);
        /// <summary> GET. </summary>
        public static CorsRuleAllowedMethodsItem GET { get; } = new CorsRuleAllowedMethodsItem(GETValue);
        /// <summary> HEAD. </summary>
        public static CorsRuleAllowedMethodsItem Head { get; } = new CorsRuleAllowedMethodsItem(HeadValue);
        /// <summary> MERGE. </summary>
        public static CorsRuleAllowedMethodsItem Merge { get; } = new CorsRuleAllowedMethodsItem(MergeValue);
        /// <summary> POST. </summary>
        public static CorsRuleAllowedMethodsItem Post { get; } = new CorsRuleAllowedMethodsItem(PostValue);
        /// <summary> OPTIONS. </summary>
        public static CorsRuleAllowedMethodsItem Options { get; } = new CorsRuleAllowedMethodsItem(OptionsValue);
        /// <summary> PUT. </summary>
        public static CorsRuleAllowedMethodsItem PUT { get; } = new CorsRuleAllowedMethodsItem(PUTValue);
        /// <summary> Determines if two <see cref="CorsRuleAllowedMethodsItem"/> values are the same. </summary>
        public static bool operator ==(CorsRuleAllowedMethodsItem left, CorsRuleAllowedMethodsItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CorsRuleAllowedMethodsItem"/> values are not the same. </summary>
        public static bool operator !=(CorsRuleAllowedMethodsItem left, CorsRuleAllowedMethodsItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CorsRuleAllowedMethodsItem"/>. </summary>
        public static implicit operator CorsRuleAllowedMethodsItem(string value) => new CorsRuleAllowedMethodsItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CorsRuleAllowedMethodsItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CorsRuleAllowedMethodsItem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
