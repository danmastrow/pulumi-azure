// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Network Security Group.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/network_security_group.html.markdown.
        /// </summary>
        public static Task<GetNetworkSecurityGroupResult> GetNetworkSecurityGroup(GetNetworkSecurityGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetNetworkSecurityGroupResult>("azure:network/getNetworkSecurityGroup:getNetworkSecurityGroup", args, options.WithVersion());
    }

    public sealed class GetNetworkSecurityGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the Name of the Network Security Group.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Specifies the Name of the Resource Group within which the Network Security Group exists
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetNetworkSecurityGroupArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetNetworkSecurityGroupResult
    {
        /// <summary>
        /// The supported Azure location where the resource exists.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the security rule.
        /// </summary>
        public readonly string Name;
        public readonly string ResourceGroupName;
        /// <summary>
        /// One or more `security_rule` blocks as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNetworkSecurityGroupSecurityRulesResult> SecurityRules;
        /// <summary>
        /// A mapping of tags assigned to the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetNetworkSecurityGroupResult(
            string location,
            string name,
            string resourceGroupName,
            ImmutableArray<Outputs.GetNetworkSecurityGroupSecurityRulesResult> securityRules,
            ImmutableDictionary<string, string> tags,
            string id)
        {
            Location = location;
            Name = name;
            ResourceGroupName = resourceGroupName;
            SecurityRules = securityRules;
            Tags = tags;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetNetworkSecurityGroupSecurityRulesResult
    {
        /// <summary>
        /// Is network traffic is allowed or denied?
        /// </summary>
        public readonly string Access;
        /// <summary>
        /// The description for this rule.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// CIDR or destination IP range or * to match any IP.
        /// </summary>
        public readonly string DestinationAddressPrefix;
        /// <summary>
        /// A list of CIDRs or destination IP ranges.
        /// </summary>
        public readonly ImmutableArray<string> DestinationAddressPrefixes;
        /// <summary>
        /// A List of destination Application Security Group ID's
        /// </summary>
        public readonly ImmutableArray<string> DestinationApplicationSecurityGroupIds;
        /// <summary>
        /// The Destination Port or Range.
        /// </summary>
        public readonly string DestinationPortRange;
        public readonly ImmutableArray<string> DestinationPortRanges;
        /// <summary>
        /// The direction specifies if rule will be evaluated on incoming or outgoing traffic.
        /// </summary>
        public readonly string Direction;
        /// <summary>
        /// Specifies the Name of the Network Security Group.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The priority of the rule
        /// </summary>
        public readonly int Priority;
        /// <summary>
        /// The network protocol this rule applies to.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// CIDR or source IP range or * to match any IP.
        /// </summary>
        public readonly string SourceAddressPrefix;
        /// <summary>
        /// A list of CIDRs or source IP ranges.
        /// </summary>
        public readonly ImmutableArray<string> SourceAddressPrefixes;
        /// <summary>
        /// A List of source Application Security Group ID's
        /// </summary>
        public readonly ImmutableArray<string> SourceApplicationSecurityGroupIds;
        /// <summary>
        /// The Source Port or Range.
        /// </summary>
        public readonly string SourcePortRange;
        public readonly ImmutableArray<string> SourcePortRanges;

        [OutputConstructor]
        private GetNetworkSecurityGroupSecurityRulesResult(
            string access,
            string description,
            string destinationAddressPrefix,
            ImmutableArray<string> destinationAddressPrefixes,
            ImmutableArray<string> destinationApplicationSecurityGroupIds,
            string destinationPortRange,
            ImmutableArray<string> destinationPortRanges,
            string direction,
            string name,
            int priority,
            string protocol,
            string sourceAddressPrefix,
            ImmutableArray<string> sourceAddressPrefixes,
            ImmutableArray<string> sourceApplicationSecurityGroupIds,
            string sourcePortRange,
            ImmutableArray<string> sourcePortRanges)
        {
            Access = access;
            Description = description;
            DestinationAddressPrefix = destinationAddressPrefix;
            DestinationAddressPrefixes = destinationAddressPrefixes;
            DestinationApplicationSecurityGroupIds = destinationApplicationSecurityGroupIds;
            DestinationPortRange = destinationPortRange;
            DestinationPortRanges = destinationPortRanges;
            Direction = direction;
            Name = name;
            Priority = priority;
            Protocol = protocol;
            SourceAddressPrefix = sourceAddressPrefix;
            SourceAddressPrefixes = sourceAddressPrefixes;
            SourceApplicationSecurityGroupIds = sourceApplicationSecurityGroupIds;
            SourcePortRange = sourcePortRange;
            SourcePortRanges = sourcePortRanges;
        }
    }
    }
}