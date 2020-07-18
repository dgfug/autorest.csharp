// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Tables.Models
{
    /// <summary> Azure Analytics Logging settings. </summary>
    public partial class Logging
    {
        /// <summary> Initializes a new instance of Logging. </summary>
        /// <param name="version"> The version of Storage Analytics to configure. </param>
        /// <param name="delete"> Indicates whether all delete requests should be logged. </param>
        /// <param name="read"> Indicates whether all read requests should be logged. </param>
        /// <param name="write"> Indicates whether all write requests should be logged. </param>
        /// <param name="retentionPolicy"> the retention policy. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public Logging(string version, bool delete, bool read, bool write, RetentionPolicy retentionPolicy)
        {
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }
            if (retentionPolicy == null)
            {
                throw new ArgumentNullException(nameof(retentionPolicy));
            }

            Version = version;
            Delete = delete;
            Read = read;
            Write = write;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary> The version of Storage Analytics to configure. </summary>
        public string Version { get; set; }
        /// <summary> Indicates whether all delete requests should be logged. </summary>
        public bool Delete { get; set; }
        /// <summary> Indicates whether all read requests should be logged. </summary>
        public bool Read { get; set; }
        /// <summary> Indicates whether all write requests should be logged. </summary>
        public bool Write { get; set; }
        /// <summary> the retention policy. </summary>
        public RetentionPolicy RetentionPolicy { get; set; }
    }
}
