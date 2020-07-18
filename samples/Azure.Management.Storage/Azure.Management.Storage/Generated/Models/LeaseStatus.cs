// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Storage.Models
{
    /// <summary> The lease status of the container. </summary>
    public readonly partial struct LeaseStatus : IEquatable<LeaseStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="LeaseStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> This occurs when <paramref name="value"/> is null. </exception>
        public LeaseStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LockedValue = "Locked";
        private const string UnlockedValue = "Unlocked";

        /// <summary> Locked. </summary>
        public static LeaseStatus Locked { get; } = new LeaseStatus(LockedValue);
        /// <summary> Unlocked. </summary>
        public static LeaseStatus Unlocked { get; } = new LeaseStatus(UnlockedValue);
        /// <summary> Determines if two <see cref="LeaseStatus"/> values are the same. </summary>
        public static bool operator ==(LeaseStatus left, LeaseStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LeaseStatus"/> values are not the same. </summary>
        public static bool operator !=(LeaseStatus left, LeaseStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LeaseStatus"/>. </summary>
        public static implicit operator LeaseStatus(string value) => new LeaseStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LeaseStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LeaseStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
