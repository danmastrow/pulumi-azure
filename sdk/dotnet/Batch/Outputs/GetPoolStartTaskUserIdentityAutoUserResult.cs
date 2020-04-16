// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Batch.Outputs
{

    [OutputType]
    public sealed class GetPoolStartTaskUserIdentityAutoUserResult
    {
        /// <summary>
        /// The elevation level of the user identity under which the start task runs.
        /// </summary>
        public readonly string ElevationLevel;
        /// <summary>
        /// The scope of the user identity under which the start task runs.
        /// </summary>
        public readonly string Scope;

        [OutputConstructor]
        private GetPoolStartTaskUserIdentityAutoUserResult(
            string elevationLevel,

            string scope)
        {
            ElevationLevel = elevationLevel;
            Scope = scope;
        }
    }
}