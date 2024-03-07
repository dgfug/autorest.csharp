// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.Models
{
    /// <summary> The ImagesResponse. </summary>
    public partial class ImagesResponse
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

        /// <summary> Initializes a new instance of <see cref="ImagesResponse"/>. </summary>
        /// <param name="created"></param>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        internal ImagesResponse(DateTimeOffset created, IEnumerable<Image> data)
        {
            Argument.AssertNotNull(data, nameof(data));

            Created = created;
            Data = data.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ImagesResponse"/>. </summary>
        /// <param name="created"></param>
        /// <param name="data"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImagesResponse(DateTimeOffset created, IReadOnlyList<Image> data, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Created = created;
            Data = data;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ImagesResponse"/> for deserialization. </summary>
        internal ImagesResponse()
        {
        }

        /// <summary> Gets the created. </summary>
        public DateTimeOffset Created { get; }
        /// <summary> Gets the data. </summary>
        public IReadOnlyList<Image> Data { get; }
    }
}
