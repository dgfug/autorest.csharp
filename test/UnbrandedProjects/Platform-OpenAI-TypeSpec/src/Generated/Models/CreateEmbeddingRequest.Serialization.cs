// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Models
{
    public partial class CreateEmbeddingRequest : IUtf8JsonWriteable, IJsonModel<CreateEmbeddingRequest>
    {
        void IUtf8JsonWriteable.Write(Utf8JsonWriter writer) => ((IJsonModel<CreateEmbeddingRequest>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CreateEmbeddingRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEmbeddingRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateEmbeddingRequest)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("model"u8);
            writer.WriteStringValue(Model.ToString());
            writer.WritePropertyName("input"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Input);
#else
            using (JsonDocument document = JsonDocument.Parse(Input))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            if (Optional.IsDefined(User))
            {
                writer.WritePropertyName("user"u8);
                writer.WriteStringValue(User);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        CreateEmbeddingRequest IJsonModel<CreateEmbeddingRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEmbeddingRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateEmbeddingRequest)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateEmbeddingRequest(document.RootElement, options);
        }

        internal static CreateEmbeddingRequest DeserializeCreateEmbeddingRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CreateEmbeddingRequestModel model = default;
            BinaryData input = default;
            string user = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("model"u8))
                {
                    model = new CreateEmbeddingRequestModel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("input"u8))
                {
                    input = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("user"u8))
                {
                    user = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CreateEmbeddingRequest(model, input, user, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreateEmbeddingRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEmbeddingRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateEmbeddingRequest)} does not support '{options.Format}' format.");
            }
        }

        CreateEmbeddingRequest IPersistableModel<CreateEmbeddingRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEmbeddingRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateEmbeddingRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateEmbeddingRequest)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateEmbeddingRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateEmbeddingRequest FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateEmbeddingRequest(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestBody. </summary>
        internal virtual RequestBody ToRequestBody()
        {
            var content = new Utf8JsonRequestBody();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
