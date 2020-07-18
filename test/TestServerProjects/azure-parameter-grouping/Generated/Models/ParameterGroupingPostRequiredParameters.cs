// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace azure_parameter_grouping.Models
{
    /// <summary> Parameter group. </summary>
    public partial class ParameterGroupingPostRequiredParameters
    {
        /// <summary> Initializes a new instance of ParameterGroupingPostRequiredParameters. </summary>
        /// <param name="path"> Path parameter. </param>
        /// <param name="body"> . </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public ParameterGroupingPostRequiredParameters(string path, int body)
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }

            Path = path;
            Body = body;
        }

        public string CustomHeader { get; set; }
        /// <summary> Query parameter with default. </summary>
        public int? Query { get; set; }
        /// <summary> Path parameter. </summary>
        public string Path { get; }
        public int Body { get; }
    }
}
