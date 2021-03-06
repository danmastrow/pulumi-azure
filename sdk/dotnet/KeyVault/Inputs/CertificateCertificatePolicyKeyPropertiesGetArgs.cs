// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.KeyVault.Inputs
{

    public sealed class CertificateCertificatePolicyKeyPropertiesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Is this Certificate Exportable? Changing this forces a new resource to be created.
        /// </summary>
        [Input("exportable", required: true)]
        public Input<bool> Exportable { get; set; } = null!;

        /// <summary>
        /// The size of the Key used in the Certificate. Possible values include `2048` and `4096`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("keySize", required: true)]
        public Input<int> KeySize { get; set; } = null!;

        /// <summary>
        /// Specifies the Type of Key, such as `RSA`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("keyType", required: true)]
        public Input<string> KeyType { get; set; } = null!;

        /// <summary>
        /// Is the key reusable? Changing this forces a new resource to be created.
        /// </summary>
        [Input("reuseKey", required: true)]
        public Input<bool> ReuseKey { get; set; } = null!;

        public CertificateCertificatePolicyKeyPropertiesGetArgs()
        {
        }
    }
}
