﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Relay
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>Provides runtime information about a HybridConnection.</summary>
    [DataContract(Name = "HybridConnectionDescription", Namespace = RelayConstants.ManagementNamespace)]
    public class HybridConnectionRuntimeInformation
        : IExtensibleDataObject
    {
#pragma warning disable 0649 // Field 'xxx' is never assigned to - assigned through serialization
        [DataMember(Name = "CreatedAt", IsRequired = false, EmitDefaultValue = false, Order = 2)]
        DateTime? createdAt;

        [DataMember(Name = "UpdatedAt", IsRequired = false, EmitDefaultValue = false, Order = 3)]
        DateTime? updatedAt;

        [DataMember(Name = "RequiresClientAuthorization", IsRequired = false, EmitDefaultValue = false, Order = 4)]
        bool? requiresClientAuthorization;

        [DataMember(Name = "UserMetadata", IsRequired = false, EmitDefaultValue = false, Order = 8)]
        string userMetadata;

        [DataMember(Name = "ListenerCount", IsRequired = false, EmitDefaultValue = false, Order = 9)]
        int? listenerCount;
#pragma warning restore 0649 // Field 'xxx' is never assigned to

        internal HybridConnectionRuntimeInformation()
        {
        }

        /// <summary>Gets the time the HybridConnection was created.</summary>
        public DateTime CreatedAt
        {
            get { return this.createdAt ?? DateTime.MinValue; }
        }

        /// <summary>Gets the time when the HybridConnection was updated.</summary>
        public DateTime UpdatedAt
        {
            get { return this.updatedAt ?? DateTime.MinValue; }
        }

        /// <summary>Gets the number of listeners for this HybridConnection.</summary>
        /// <value>The number of listeners for this HybridConnection.</value>
        public int ListenerCount
        {
            get { return this.listenerCount ?? 0; }
        }

        /// <summary>Gets a value indicating whether client authorization is needed for this HybridConnection.</summary>
        /// <value>true if client authorization is needed for this HybridConnection; otherwise, false.</value>
        public bool RequiresClientAuthorization
        {
            get { return this.requiresClientAuthorization ?? true; }
        }

        /// <summary>Gets the user metadata associated with this instance.</summary>
        /// <value>The user metadata associated with this instance.</value>
        public string UserMetadata
        {
            get { return this.userMetadata; }
        }

        ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }
    }
}
