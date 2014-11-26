/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the AddInstanceGroups operation.
    /// AddInstanceGroups adds an instance group to a running cluster.
    /// </summary>
    public partial class AddInstanceGroupsRequest : AmazonWebServiceRequest
    {
        private List<InstanceGroupConfig> _instanceGroups = new List<InstanceGroupConfig>();
        private string _jobFlowId;


        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// Instance Groups to add.
        /// </para>
        /// </summary>
        public List<InstanceGroupConfig> InstanceGroups
        {
            get { return this._instanceGroups; }
            set { this._instanceGroups = value; }
        }

        /// <summary>
        /// Sets the InstanceGroups property
        /// </summary>
        /// <param name="instanceGroups">The values to add to the InstanceGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddInstanceGroupsRequest WithInstanceGroups(params InstanceGroupConfig[] instanceGroups)
        {
            foreach (var element in instanceGroups)
            {
                this._instanceGroups.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the InstanceGroups property
        /// </summary>
        /// <param name="instanceGroups">The values to add to the InstanceGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddInstanceGroupsRequest WithInstanceGroups(IEnumerable<InstanceGroupConfig> instanceGroups)
        {
            foreach (var element in instanceGroups)
            {
                this._instanceGroups.Add(element);
            }
            return this;
        }
        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this._instanceGroups != null && this._instanceGroups.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property JobFlowId. 
        /// <para>
        /// Job flow in which to add the instance groups.
        /// </para>
        /// </summary>
        public string JobFlowId
        {
            get { return this._jobFlowId; }
            set { this._jobFlowId = value; }
        }


        /// <summary>
        /// Sets the JobFlowId property
        /// </summary>
        /// <param name="jobFlowId">The value to set for the JobFlowId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddInstanceGroupsRequest WithJobFlowId(string jobFlowId)
        {
            this._jobFlowId = jobFlowId;
            return this;
        }

        // Check to see if JobFlowId property is set
        internal bool IsSetJobFlowId()
        {
            return this._jobFlowId != null;
        }

    }
}