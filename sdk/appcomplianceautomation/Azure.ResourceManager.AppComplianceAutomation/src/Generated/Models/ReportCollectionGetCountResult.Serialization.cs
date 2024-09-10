// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class ReportCollectionGetCountResult : IUtf8JsonSerializable, IJsonModel<ReportCollectionGetCountResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReportCollectionGetCountResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ReportCollectionGetCountResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportCollectionGetCountResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportCollectionGetCountResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
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
        }

        ReportCollectionGetCountResult IJsonModel<ReportCollectionGetCountResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportCollectionGetCountResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReportCollectionGetCountResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReportCollectionGetCountResult(document.RootElement, options);
        }

        internal static ReportCollectionGetCountResult DeserializeReportCollectionGetCountResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? count = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ReportCollectionGetCountResult(count, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReportCollectionGetCountResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportCollectionGetCountResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReportCollectionGetCountResult)} does not support writing '{options.Format}' format.");
            }
        }

        ReportCollectionGetCountResult IPersistableModel<ReportCollectionGetCountResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReportCollectionGetCountResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReportCollectionGetCountResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReportCollectionGetCountResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReportCollectionGetCountResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
