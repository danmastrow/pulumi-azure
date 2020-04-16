// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network.Outputs
{

    [OutputType]
    public sealed class ApplicationGatewayFrontendIpConfiguration
    {
        /// <summary>
        /// The ID of the Rewrite Rule Set
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The name of the Frontend IP Configuration.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The Private IP Address to use for the Application Gateway.
        /// </summary>
        public readonly string? PrivateIpAddress;
        /// <summary>
        /// The Allocation Method for the Private IP Address. Possible values are `Dynamic` and `Static`.
        /// </summary>
        public readonly string? PrivateIpAddressAllocation;
        /// <summary>
        /// The ID of a Public IP Address which the Application Gateway should use.
        /// </summary>
        public readonly string? PublicIpAddressId;
        /// <summary>
        /// The ID of the Subnet which the Application Gateway should be connected to.
        /// </summary>
        public readonly string? SubnetId;

        [OutputConstructor]
        private ApplicationGatewayFrontendIpConfiguration(
            string? id,

            string name,

            string? privateIpAddress,

            string? privateIpAddressAllocation,

            string? publicIpAddressId,

            string? subnetId)
        {
            Id = id;
            Name = name;
            PrivateIpAddress = privateIpAddress;
            PrivateIpAddressAllocation = privateIpAddressAllocation;
            PublicIpAddressId = publicIpAddressId;
            SubnetId = subnetId;
        }
    }
}