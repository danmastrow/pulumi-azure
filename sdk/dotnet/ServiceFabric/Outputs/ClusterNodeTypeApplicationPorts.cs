// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ServiceFabric.Outputs
{

    [OutputType]
    public sealed class ClusterNodeTypeApplicationPorts
    {
        /// <summary>
        /// The end of the Application Port Range on this Node Type.
        /// </summary>
        public readonly int EndPort;
        /// <summary>
        /// The start of the Application Port Range on this Node Type.
        /// </summary>
        public readonly int StartPort;

        [OutputConstructor]
        private ClusterNodeTypeApplicationPorts(
            int endPort,

            int startPort)
        {
            EndPort = endPort;
            StartPort = startPort;
        }
    }
}