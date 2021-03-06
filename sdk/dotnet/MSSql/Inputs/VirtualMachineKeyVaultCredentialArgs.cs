// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.MSSql.Inputs
{

    public sealed class VirtualMachineKeyVaultCredentialArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The azure Key Vault url. Changing this forces a new resource to be created.
        /// </summary>
        [Input("keyVaultUrl", required: true)]
        public Input<string> KeyVaultUrl { get; set; } = null!;

        /// <summary>
        /// The credential name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The service principal name to access key vault. Changing this forces a new resource to be created.
        /// </summary>
        [Input("servicePrincipalName", required: true)]
        public Input<string> ServicePrincipalName { get; set; } = null!;

        /// <summary>
        /// The service principal name secret to access key vault. Changing this forces a new resource to be created.
        /// </summary>
        [Input("servicePrincipalSecret", required: true)]
        public Input<string> ServicePrincipalSecret { get; set; } = null!;

        public VirtualMachineKeyVaultCredentialArgs()
        {
        }
    }
}
