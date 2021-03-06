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

/*
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterInstancesWithLoadBalancer operation.
    /// Adds the specified instances to the specified load balancer.
    /// 
    ///  
    /// <para>
    /// The instance must be a running instance in the same network as the load balancer (EC2-Classic
    /// or the same VPC). If you have EC2-Classic instances and a load balancer in a VPC with
    /// ClassicLink enabled, you can link the EC2-Classic instances to that VPC and then register
    /// the linked EC2-Classic instances with the load balancer in the VPC.
    /// </para>
    ///  
    /// <para>
    /// Note that <code>RegisterInstanceWithLoadBalancer</code> completes when the request
    /// has been registered. Instance registration happens shortly afterwards. To check the
    /// state of the registered instances, use <a>DescribeLoadBalancers</a> or <a>DescribeInstanceHealth</a>.
    /// </para>
    ///  
    /// <para>
    /// After the instance is registered, it starts receiving traffic and requests from the
    /// load balancer. Any instance that is not in one of the Availability Zones registered
    /// for the load balancer is moved to the <code>OutOfService</code> state. If an Availability
    /// Zone is added to the load balancer later, any instances registered with the load balancer
    /// move to the <code>InService</code> state.
    /// </para>
    ///  
    /// <para>
    /// If you stop an instance registered with a load balancer and then start it, the IP
    /// addresses associated with the instance changes. Elastic Load Balancing cannot recognize
    /// the new IP address, which prevents it from routing traffic to the instances. We recommend
    /// that you use the following sequence: stop the instance, deregister the instance, start
    /// the instance, and then register the instance. To deregister instances from a load
    /// balancer, use <a>DeregisterInstancesFromLoadBalancer</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_DeReg_Reg_Instances.html">Deregister
    /// and Register EC2 Instances</a> in the <i>Elastic Load Balancing Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class RegisterInstancesWithLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        private List<Instance> _instances = new List<Instance>();
        private string _loadBalancerName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RegisterInstancesWithLoadBalancerRequest() { }

        /// <summary>
        /// Instantiates RegisterInstancesWithLoadBalancerRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName">The name of the load balancer.</param>
        /// <param name="instances">The IDs of the instances.</param>
        public RegisterInstancesWithLoadBalancerRequest(string loadBalancerName, List<Instance> instances)
        {
            _loadBalancerName = loadBalancerName;
            _instances = instances;
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The IDs of the instances.
        /// </para>
        /// </summary>
        public List<Instance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

    }
}