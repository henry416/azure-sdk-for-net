// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The integration account certificate.
    /// </summary>
    [JsonTransformation]
    public partial class IntegrationAccountCertificate : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountCertificate
        /// class.
        /// </summary>
        public IntegrationAccountCertificate() { }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountCertificate
        /// class.
        /// </summary>
        /// <param name="id">The resource id.</param>
        /// <param name="name">Gets the resource name.</param>
        /// <param name="type">Gets the resource type.</param>
        /// <param name="location">The resource location.</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="createdTime">The created time.</param>
        /// <param name="changedTime">The changed time.</param>
        /// <param name="metadata">The metadata.</param>
        /// <param name="key">The key details in the key vault.</param>
        /// <param name="publicCertificate">The public certificate.</param>
        public IntegrationAccountCertificate(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? createdTime = default(System.DateTime?), System.DateTime? changedTime = default(System.DateTime?), object metadata = default(object), KeyVaultKeyReference key = default(KeyVaultKeyReference), string publicCertificate = default(string))
            : base(id, name, type, location, tags)
        {
            CreatedTime = createdTime;
            ChangedTime = changedTime;
            Metadata = metadata;
            Key = key;
            PublicCertificate = publicCertificate;
        }

        /// <summary>
        /// Gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public System.DateTime? CreatedTime { get; protected set; }

        /// <summary>
        /// Gets the changed time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.changedTime")]
        public System.DateTime? ChangedTime { get; protected set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// Gets or sets the key details in the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "properties.key")]
        public KeyVaultKeyReference Key { get; set; }

        /// <summary>
        /// Gets or sets the public certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicCertificate")]
        public string PublicCertificate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Key != null)
            {
                Key.Validate();
            }
        }
    }
}

