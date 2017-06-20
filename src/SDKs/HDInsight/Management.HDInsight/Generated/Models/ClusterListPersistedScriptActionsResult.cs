// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.HDInsight.Models
{
    using Microsoft.HDInsight;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The ListPersistedScriptActions operation response.
    /// </summary>
    public partial class ClusterListPersistedScriptActionsResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ClusterListPersistedScriptActionsResult class.
        /// </summary>
        public ClusterListPersistedScriptActionsResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ClusterListPersistedScriptActionsResult class.
        /// </summary>
        /// <param name="value">The list of Persisted Script Actions.</param>
        /// <param name="nextLink">The link (url) to the next page of
        /// results.</param>
        public ClusterListPersistedScriptActionsResult(IList<RuntimeScriptAction> value = default(IList<RuntimeScriptAction>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of Persisted Script Actions.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<RuntimeScriptAction> Value { get; set; }

        /// <summary>
        /// Gets the link (url) to the next page of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}