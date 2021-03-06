// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService
{
    /// <summary>
    /// Manages an App Service Environment.
    /// </summary>
    public partial class Environment : Pulumi.CustomResource
    {
        /// <summary>
        /// Scale factor for front end instances. Possible values are between `5` and `15`. Defaults to `15`.
        /// </summary>
        [Output("frontEndScaleFactor")]
        public Output<int?> FrontEndScaleFactor { get; private set; } = null!;

        [Output("internalLoadBalancingMode")]
        public Output<string?> InternalLoadBalancingMode { get; private set; } = null!;

        /// <summary>
        /// The location where the App Service Environment exists.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the App Service Environment. Changing this forces a new resource to be created. 
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Pricing tier for the front end instances. Possible values are `I1`, `I2` and `I3`. Defaults to `I1`.
        /// </summary>
        [Output("pricingTier")]
        public Output<string?> PricingTier { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the App Service Environment exists.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The ID of the Subnet which the App Service Environment should be connected to. Changing this forces a new resource to be created.
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Environment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Environment(string name, EnvironmentArgs args, CustomResourceOptions? options = null)
            : base("azure:appservice/environment:Environment", name, args ?? new EnvironmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Environment(string name, Input<string> id, EnvironmentState? state = null, CustomResourceOptions? options = null)
            : base("azure:appservice/environment:Environment", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Environment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Environment Get(string name, Input<string> id, EnvironmentState? state = null, CustomResourceOptions? options = null)
        {
            return new Environment(name, id, state, options);
        }
    }

    public sealed class EnvironmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Scale factor for front end instances. Possible values are between `5` and `15`. Defaults to `15`.
        /// </summary>
        [Input("frontEndScaleFactor")]
        public Input<int>? FrontEndScaleFactor { get; set; }

        [Input("internalLoadBalancingMode")]
        public Input<string>? InternalLoadBalancingMode { get; set; }

        /// <summary>
        /// The name of the App Service Environment. Changing this forces a new resource to be created. 
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Pricing tier for the front end instances. Possible values are `I1`, `I2` and `I3`. Defaults to `I1`.
        /// </summary>
        [Input("pricingTier")]
        public Input<string>? PricingTier { get; set; }

        /// <summary>
        /// The ID of the Subnet which the App Service Environment should be connected to. Changing this forces a new resource to be created.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public EnvironmentArgs()
        {
        }
    }

    public sealed class EnvironmentState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Scale factor for front end instances. Possible values are between `5` and `15`. Defaults to `15`.
        /// </summary>
        [Input("frontEndScaleFactor")]
        public Input<int>? FrontEndScaleFactor { get; set; }

        [Input("internalLoadBalancingMode")]
        public Input<string>? InternalLoadBalancingMode { get; set; }

        /// <summary>
        /// The location where the App Service Environment exists.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the App Service Environment. Changing this forces a new resource to be created. 
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Pricing tier for the front end instances. Possible values are `I1`, `I2` and `I3`. Defaults to `I1`.
        /// </summary>
        [Input("pricingTier")]
        public Input<string>? PricingTier { get; set; }

        /// <summary>
        /// The name of the Resource Group where the App Service Environment exists.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The ID of the Subnet which the App Service Environment should be connected to. Changing this forces a new resource to be created.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public EnvironmentState()
        {
        }
    }
}
