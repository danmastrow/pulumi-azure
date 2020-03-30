// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Storage
{
    /// <summary>
    /// Manages a File Share within Azure Storage.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/storage_share.html.markdown.
    /// </summary>
    public partial class Share : Pulumi.CustomResource
    {
        /// <summary>
        /// One or more `acl` blocks as defined below.
        /// </summary>
        [Output("acls")]
        public Output<ImmutableArray<Outputs.ShareAcls>> Acls { get; private set; } = null!;

        /// <summary>
        /// A mapping of MetaData for this File Share.
        /// </summary>
        [Output("metadata")]
        public Output<ImmutableDictionary<string, string>?> Metadata { get; private set; } = null!;

        /// <summary>
        /// The name of the share. Must be unique within the storage account where the share is located.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The maximum size of the share, in gigabytes. For Standard storage accounts, this must be greater than 0 and less than 5120 GB (5 TB). For Premium FileStorage storage accounts, this must be greater than 100 GB and less than 102400 GB (100 TB). Default is 5120.
        /// </summary>
        [Output("quota")]
        public Output<int?> Quota { get; private set; } = null!;

        /// <summary>
        /// The Resource Manager ID of this File Share.
        /// </summary>
        [Output("resourceManagerId")]
        public Output<string> ResourceManagerId { get; private set; } = null!;

        /// <summary>
        /// Specifies the storage account in which to create the share.
        /// Changing this forces a new resource to be created.
        /// </summary>
        [Output("storageAccountName")]
        public Output<string> StorageAccountName { get; private set; } = null!;

        /// <summary>
        /// The URL of the File Share
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a Share resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Share(string name, ShareArgs args, CustomResourceOptions? options = null)
            : base("azure:storage/share:Share", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Share(string name, Input<string> id, ShareState? state = null, CustomResourceOptions? options = null)
            : base("azure:storage/share:Share", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Share resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Share Get(string name, Input<string> id, ShareState? state = null, CustomResourceOptions? options = null)
        {
            return new Share(name, id, state, options);
        }
    }

    public sealed class ShareArgs : Pulumi.ResourceArgs
    {
        [Input("acls")]
        private InputList<Inputs.ShareAclsArgs>? _acls;

        /// <summary>
        /// One or more `acl` blocks as defined below.
        /// </summary>
        public InputList<Inputs.ShareAclsArgs> Acls
        {
            get => _acls ?? (_acls = new InputList<Inputs.ShareAclsArgs>());
            set => _acls = value;
        }

        [Input("metadata")]
        private InputMap<string>? _metadata;

        /// <summary>
        /// A mapping of MetaData for this File Share.
        /// </summary>
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        /// <summary>
        /// The name of the share. Must be unique within the storage account where the share is located.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The maximum size of the share, in gigabytes. For Standard storage accounts, this must be greater than 0 and less than 5120 GB (5 TB). For Premium FileStorage storage accounts, this must be greater than 100 GB and less than 102400 GB (100 TB). Default is 5120.
        /// </summary>
        [Input("quota")]
        public Input<int>? Quota { get; set; }

        /// <summary>
        /// Specifies the storage account in which to create the share.
        /// Changing this forces a new resource to be created.
        /// </summary>
        [Input("storageAccountName", required: true)]
        public Input<string> StorageAccountName { get; set; } = null!;

        public ShareArgs()
        {
        }
    }

    public sealed class ShareState : Pulumi.ResourceArgs
    {
        [Input("acls")]
        private InputList<Inputs.ShareAclsGetArgs>? _acls;

        /// <summary>
        /// One or more `acl` blocks as defined below.
        /// </summary>
        public InputList<Inputs.ShareAclsGetArgs> Acls
        {
            get => _acls ?? (_acls = new InputList<Inputs.ShareAclsGetArgs>());
            set => _acls = value;
        }

        [Input("metadata")]
        private InputMap<string>? _metadata;

        /// <summary>
        /// A mapping of MetaData for this File Share.
        /// </summary>
        public InputMap<string> Metadata
        {
            get => _metadata ?? (_metadata = new InputMap<string>());
            set => _metadata = value;
        }

        /// <summary>
        /// The name of the share. Must be unique within the storage account where the share is located.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The maximum size of the share, in gigabytes. For Standard storage accounts, this must be greater than 0 and less than 5120 GB (5 TB). For Premium FileStorage storage accounts, this must be greater than 100 GB and less than 102400 GB (100 TB). Default is 5120.
        /// </summary>
        [Input("quota")]
        public Input<int>? Quota { get; set; }

        /// <summary>
        /// The Resource Manager ID of this File Share.
        /// </summary>
        [Input("resourceManagerId")]
        public Input<string>? ResourceManagerId { get; set; }

        /// <summary>
        /// Specifies the storage account in which to create the share.
        /// Changing this forces a new resource to be created.
        /// </summary>
        [Input("storageAccountName")]
        public Input<string>? StorageAccountName { get; set; }

        /// <summary>
        /// The URL of the File Share
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public ShareState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class ShareAclsAccessPoliciesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ISO8061 UTC time at which this Access Policy should be valid until.
        /// </summary>
        [Input("expiry", required: true)]
        public Input<string> Expiry { get; set; } = null!;

        /// <summary>
        /// The permissions which should associated with this Shared Identifier.
        /// </summary>
        [Input("permissions", required: true)]
        public Input<string> Permissions { get; set; } = null!;

        /// <summary>
        /// The ISO8061 UTC time at which this Access Policy should be valid from.
        /// </summary>
        [Input("start", required: true)]
        public Input<string> Start { get; set; } = null!;

        public ShareAclsAccessPoliciesArgs()
        {
        }
    }

    public sealed class ShareAclsAccessPoliciesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ISO8061 UTC time at which this Access Policy should be valid until.
        /// </summary>
        [Input("expiry", required: true)]
        public Input<string> Expiry { get; set; } = null!;

        /// <summary>
        /// The permissions which should associated with this Shared Identifier.
        /// </summary>
        [Input("permissions", required: true)]
        public Input<string> Permissions { get; set; } = null!;

        /// <summary>
        /// The ISO8061 UTC time at which this Access Policy should be valid from.
        /// </summary>
        [Input("start", required: true)]
        public Input<string> Start { get; set; } = null!;

        public ShareAclsAccessPoliciesGetArgs()
        {
        }
    }

    public sealed class ShareAclsArgs : Pulumi.ResourceArgs
    {
        [Input("accessPolicies")]
        private InputList<ShareAclsAccessPoliciesArgs>? _accessPolicies;

        /// <summary>
        /// An `access_policy` block as defined below.
        /// </summary>
        public InputList<ShareAclsAccessPoliciesArgs> AccessPolicies
        {
            get => _accessPolicies ?? (_accessPolicies = new InputList<ShareAclsAccessPoliciesArgs>());
            set => _accessPolicies = value;
        }

        /// <summary>
        /// The ID which should be used for this Shared Identifier.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        public ShareAclsArgs()
        {
        }
    }

    public sealed class ShareAclsGetArgs : Pulumi.ResourceArgs
    {
        [Input("accessPolicies")]
        private InputList<ShareAclsAccessPoliciesGetArgs>? _accessPolicies;

        /// <summary>
        /// An `access_policy` block as defined below.
        /// </summary>
        public InputList<ShareAclsAccessPoliciesGetArgs> AccessPolicies
        {
            get => _accessPolicies ?? (_accessPolicies = new InputList<ShareAclsAccessPoliciesGetArgs>());
            set => _accessPolicies = value;
        }

        /// <summary>
        /// The ID which should be used for this Shared Identifier.
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        public ShareAclsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class ShareAcls
    {
        /// <summary>
        /// An `access_policy` block as defined below.
        /// </summary>
        public readonly ImmutableArray<ShareAclsAccessPolicies> AccessPolicies;
        /// <summary>
        /// The ID which should be used for this Shared Identifier.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private ShareAcls(
            ImmutableArray<ShareAclsAccessPolicies> accessPolicies,
            string id)
        {
            AccessPolicies = accessPolicies;
            Id = id;
        }
    }

    [OutputType]
    public sealed class ShareAclsAccessPolicies
    {
        /// <summary>
        /// The ISO8061 UTC time at which this Access Policy should be valid until.
        /// </summary>
        public readonly string Expiry;
        /// <summary>
        /// The permissions which should associated with this Shared Identifier.
        /// </summary>
        public readonly string Permissions;
        /// <summary>
        /// The ISO8061 UTC time at which this Access Policy should be valid from.
        /// </summary>
        public readonly string Start;

        [OutputConstructor]
        private ShareAclsAccessPolicies(
            string expiry,
            string permissions,
            string start)
        {
            Expiry = expiry;
            Permissions = permissions;
            Start = start;
        }
    }
    }
}
