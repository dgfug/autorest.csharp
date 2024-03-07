// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Models
{
    /// <summary> The CreateModerationRequest. </summary>
    public partial class CreateModerationRequest
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

        /// <summary> Initializes a new instance of <see cref="CreateModerationRequest"/>. </summary>
        /// <param name="input"> The input text to classify. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public CreateModerationRequest(BinaryData input)
        {
            Argument.AssertNotNull(input, nameof(input));

            Input = input;
        }

        /// <summary> Initializes a new instance of <see cref="CreateModerationRequest"/>. </summary>
        /// <param name="input"> The input text to classify. </param>
        /// <param name="model">
        /// Two content moderations models are available: `text-moderation-stable` and
        /// `text-moderation-latest`. The default is `text-moderation-latest` which will be automatically
        /// upgraded over time. This ensures you are always using our most accurate model. If you use
        /// `text-moderation-stable`, we will provide advanced notice before updating the model. Accuracy
        /// of `text-moderation-stable` may be slightly lower than for `text-moderation-latest`.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateModerationRequest(BinaryData input, CreateModerationRequestModel? model, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Input = input;
            Model = model;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateModerationRequest"/> for deserialization. </summary>
        internal CreateModerationRequest()
        {
        }

        /// <summary>
        /// The input text to classify
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="string"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="IList{T}"/> where <c>T</c> is of type <see cref="string"/></description>
        /// </item>
        /// </list>
        /// </remarks>
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
        public BinaryData Input { get; }
        /// <summary>
        /// Two content moderations models are available: `text-moderation-stable` and
        /// `text-moderation-latest`. The default is `text-moderation-latest` which will be automatically
        /// upgraded over time. This ensures you are always using our most accurate model. If you use
        /// `text-moderation-stable`, we will provide advanced notice before updating the model. Accuracy
        /// of `text-moderation-stable` may be slightly lower than for `text-moderation-latest`.
        /// </summary>
        public CreateModerationRequestModel? Model { get; set; }
    }
}
