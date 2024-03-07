// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using MgmtReferenceTypes;

namespace Azure.ResourceManager.Fake.Models
{
    /// <summary> The resource model definition representing SKU. </summary>
    [PropertyReferenceType]
    public partial class MgmtReferenceTypesSku
    {
        /// <summary> Initializes a new instance of <see cref="MgmtReferenceTypesSku"/>. </summary>
        /// <param name="name"> The name of the SKU. Ex - P3. It is typically a letter+number code. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        [InitializationConstructor]
        public MgmtReferenceTypesSku(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="MgmtReferenceTypesSku"/>. </summary>
        /// <param name="name"> The name of the SKU. Ex - P3. It is typically a letter+number code. </param>
        /// <param name="tier"> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </param>
        /// <param name="size"> The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code. </param>
        /// <param name="family"> If the service has different generations of hardware, for the same SKU, then that can be captured here. </param>
        /// <param name="capacity"> If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted. </param>
        [SerializationConstructor]
        internal MgmtReferenceTypesSku(string name, MgmtReferenceTypesSkuTier? tier, string size, string family, int? capacity)
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
        }

        /// <summary> The name of the SKU. Ex - P3. It is typically a letter+number code. </summary>
        public string Name { get; set; }
        /// <summary> This field is required to be implemented by the Resource Provider if the service has more than one tier, but is not required on a PUT. </summary>
        public MgmtReferenceTypesSkuTier? Tier { get; set; }
        /// <summary> The SKU size. When the name field is the combination of tier and some other value, this would be the standalone code. </summary>
        public string Size { get; set; }
        /// <summary> If the service has different generations of hardware, for the same SKU, then that can be captured here. </summary>
        public string Family { get; set; }
        /// <summary> If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted. </summary>
        public int? Capacity { get; set; }
    }
}
