// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Batch.Inputs
{

    public sealed class PoolContainerConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("containerRegistries")]
        private InputList<Inputs.PoolContainerConfigurationContainerRegistryArgs>? _containerRegistries;

        /// <summary>
        /// Additional container registries from which container images can be pulled by the pool's VMs.
        /// </summary>
        public InputList<Inputs.PoolContainerConfigurationContainerRegistryArgs> ContainerRegistries
        {
            get => _containerRegistries ?? (_containerRegistries = new InputList<Inputs.PoolContainerConfigurationContainerRegistryArgs>());
            set => _containerRegistries = value;
        }

        /// <summary>
        /// The type of container configuration. Possible value is `DockerCompatible`.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public PoolContainerConfigurationArgs()
        {
        }
    }
}
