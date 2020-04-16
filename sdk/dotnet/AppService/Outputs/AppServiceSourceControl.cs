// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService.Outputs
{

    [OutputType]
    public sealed class AppServiceSourceControl
    {
        /// <summary>
        /// Branch name of the Git repository for this App Service.
        /// </summary>
        public readonly string? Branch;
        /// <summary>
        /// URL of the Git repository for this App Service.
        /// </summary>
        public readonly string? RepoUrl;

        [OutputConstructor]
        private AppServiceSourceControl(
            string? branch,

            string? repoUrl)
        {
            Branch = branch;
            RepoUrl = repoUrl;
        }
    }
}