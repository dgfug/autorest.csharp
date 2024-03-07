// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace SpecialWords
{
    /// <summary> The SameAsModel. </summary>
    public partial class SameAsModel
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SameAsModel"/>. </summary>
        /// <param name="sameAsModelProperty"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="sameAsModelProperty"/> is null. </exception>
        public SameAsModel(string sameAsModelProperty)
        {
            Argument.AssertNotNull(sameAsModelProperty, nameof(sameAsModelProperty));

            SameAsModelProperty = sameAsModelProperty;
        }

        /// <summary> Initializes a new instance of <see cref="SameAsModel"/>. </summary>
        /// <param name="sameAsModelProperty"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SameAsModel(string sameAsModelProperty, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SameAsModelProperty = sameAsModelProperty;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SameAsModel"/> for deserialization. </summary>
        internal SameAsModel()
        {
        }

        /// <summary> Gets the same as model property. </summary>
        public string SameAsModelProperty { get; }
    }
}
