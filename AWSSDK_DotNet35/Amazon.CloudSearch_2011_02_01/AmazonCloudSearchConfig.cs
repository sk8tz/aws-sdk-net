/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;

namespace Amazon.CloudSearch_2011_02_01
{

    /// <summary>
    /// Configuration for accessing Amazon CloudSearch Configuration Service service
    /// </summary>
    public class AmazonCloudSearchConfig : ClientConfig
    {
        private string userAgent = Amazon.Util.AWSSDKUtils.SDKUserAgent + " v2011_02_01";

        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonCloudSearchConfig()
        {
            this.AuthenticationServiceName = "cloudsearch";
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        internal override string RegionEndpointServiceName
        {
            get
            {
                
                return "cloudsearch";
                    
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2011-02-01";
            }
        }

        /// <summary>
        /// Gets and sets of the UserAgent property.
        /// </summary>
        public new string UserAgent
        {
            get
            {
                return this.userAgent;
            }
            set
            {
                this.userAgent = value;
            }
        }
    }
}

    