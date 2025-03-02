// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Sample.Models;

namespace Azure.ResourceManager.Sample
{
    public partial class ProximityPlacementGroupData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ProximityPlacementGroupType))
            {
                writer.WritePropertyName("proximityPlacementGroupType");
                writer.WriteStringValue(ProximityPlacementGroupType.Value.ToString());
            }
            if (Optional.IsDefined(ColocationStatus))
            {
                writer.WritePropertyName("colocationStatus");
                writer.WriteObjectValue(ColocationStatus);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ProximityPlacementGroupData DeserializeProximityPlacementGroupData(JsonElement element)
        {
            IDictionary<string, string> tags = default;
            Location location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<ProximityPlacementGroupType> proximityPlacementGroupType = default;
            Optional<IReadOnlyList<SubResourceWithColocationStatus>> virtualMachines = default;
            Optional<IReadOnlyList<SubResourceWithColocationStatus>> virtualMachineScaleSets = default;
            Optional<IReadOnlyList<SubResourceWithColocationStatus>> availabilitySets = default;
            Optional<InstanceViewStatus> colocationStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("proximityPlacementGroupType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            proximityPlacementGroupType = new ProximityPlacementGroupType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualMachines"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResourceWithColocationStatus> array = new List<SubResourceWithColocationStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResourceWithColocationStatus.DeserializeSubResourceWithColocationStatus(item));
                            }
                            virtualMachines = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineScaleSets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResourceWithColocationStatus> array = new List<SubResourceWithColocationStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResourceWithColocationStatus.DeserializeSubResourceWithColocationStatus(item));
                            }
                            virtualMachineScaleSets = array;
                            continue;
                        }
                        if (property0.NameEquals("availabilitySets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResourceWithColocationStatus> array = new List<SubResourceWithColocationStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResourceWithColocationStatus.DeserializeSubResourceWithColocationStatus(item));
                            }
                            availabilitySets = array;
                            continue;
                        }
                        if (property0.NameEquals("colocationStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            colocationStatus = InstanceViewStatus.DeserializeInstanceViewStatus(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ProximityPlacementGroupData(id, name, type, tags, location, Optional.ToNullable(proximityPlacementGroupType), Optional.ToList(virtualMachines), Optional.ToList(virtualMachineScaleSets), Optional.ToList(availabilitySets), colocationStatus.Value);
        }
    }
}
