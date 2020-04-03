// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppPlatform
{
    /// <summary>
    /// Manages an Azure Spring Cloud Service.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/spring_cloud_service.html.markdown.
    /// </summary>
    public partial class SpringCloudService : Pulumi.CustomResource
    {
        /// <summary>
        /// A `config_server_git_setting` block as defined below.
        /// </summary>
        [Output("configServerGitSetting")]
        public Output<Outputs.SpringCloudServiceConfigServerGitSetting?> ConfigServerGitSetting { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Spring Cloud Service resource. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Specifies The name of the resource group in which to create the Spring Cloud Service. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a SpringCloudService resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SpringCloudService(string name, SpringCloudServiceArgs args, CustomResourceOptions? options = null)
            : base("azure:appplatform/springCloudService:SpringCloudService", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private SpringCloudService(string name, Input<string> id, SpringCloudServiceState? state = null, CustomResourceOptions? options = null)
            : base("azure:appplatform/springCloudService:SpringCloudService", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SpringCloudService resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SpringCloudService Get(string name, Input<string> id, SpringCloudServiceState? state = null, CustomResourceOptions? options = null)
        {
            return new SpringCloudService(name, id, state, options);
        }
    }

    public sealed class SpringCloudServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `config_server_git_setting` block as defined below.
        /// </summary>
        [Input("configServerGitSetting")]
        public Input<Inputs.SpringCloudServiceConfigServerGitSettingArgs>? ConfigServerGitSetting { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Spring Cloud Service resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies The name of the resource group in which to create the Spring Cloud Service. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public SpringCloudServiceArgs()
        {
        }
    }

    public sealed class SpringCloudServiceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `config_server_git_setting` block as defined below.
        /// </summary>
        [Input("configServerGitSetting")]
        public Input<Inputs.SpringCloudServiceConfigServerGitSettingGetArgs>? ConfigServerGitSetting { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Spring Cloud Service resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies The name of the resource group in which to create the Spring Cloud Service. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public SpringCloudServiceState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class SpringCloudServiceConfigServerGitSettingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `http_basic_auth` block as defined below.
        /// </summary>
        [Input("httpBasicAuth")]
        public Input<SpringCloudServiceConfigServerGitSettingHttpBasicAuthArgs>? HttpBasicAuth { get; set; }

        /// <summary>
        /// The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        [Input("repositories")]
        private InputList<SpringCloudServiceConfigServerGitSettingRepositoriesArgs>? _repositories;

        /// <summary>
        /// One or more `repository` blocks as defined below.
        /// </summary>
        public InputList<SpringCloudServiceConfigServerGitSettingRepositoriesArgs> Repositories
        {
            get => _repositories ?? (_repositories = new InputList<SpringCloudServiceConfigServerGitSettingRepositoriesArgs>());
            set => _repositories = value;
        }

        [Input("searchPaths")]
        private InputList<string>? _searchPaths;

        /// <summary>
        /// An array of strings used to search subdirectories of the Git repository.
        /// </summary>
        public InputList<string> SearchPaths
        {
            get => _searchPaths ?? (_searchPaths = new InputList<string>());
            set => _searchPaths = value;
        }

        /// <summary>
        /// A `ssh_auth` block as defined below.
        /// </summary>
        [Input("sshAuth")]
        public Input<SpringCloudServiceConfigServerGitSettingSshAuthArgs>? SshAuth { get; set; }

        /// <summary>
        /// The URI of the default Git repository used as the Config Server back end, should be started with `http://`, `https://`, `git@`, or `ssh://`.
        /// </summary>
        [Input("uri", required: true)]
        public Input<string> Uri { get; set; } = null!;

        public SpringCloudServiceConfigServerGitSettingArgs()
        {
        }
    }

    public sealed class SpringCloudServiceConfigServerGitSettingGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `http_basic_auth` block as defined below.
        /// </summary>
        [Input("httpBasicAuth")]
        public Input<SpringCloudServiceConfigServerGitSettingHttpBasicAuthGetArgs>? HttpBasicAuth { get; set; }

        /// <summary>
        /// The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        [Input("repositories")]
        private InputList<SpringCloudServiceConfigServerGitSettingRepositoriesGetArgs>? _repositories;

        /// <summary>
        /// One or more `repository` blocks as defined below.
        /// </summary>
        public InputList<SpringCloudServiceConfigServerGitSettingRepositoriesGetArgs> Repositories
        {
            get => _repositories ?? (_repositories = new InputList<SpringCloudServiceConfigServerGitSettingRepositoriesGetArgs>());
            set => _repositories = value;
        }

        [Input("searchPaths")]
        private InputList<string>? _searchPaths;

        /// <summary>
        /// An array of strings used to search subdirectories of the Git repository.
        /// </summary>
        public InputList<string> SearchPaths
        {
            get => _searchPaths ?? (_searchPaths = new InputList<string>());
            set => _searchPaths = value;
        }

        /// <summary>
        /// A `ssh_auth` block as defined below.
        /// </summary>
        [Input("sshAuth")]
        public Input<SpringCloudServiceConfigServerGitSettingSshAuthGetArgs>? SshAuth { get; set; }

        /// <summary>
        /// The URI of the default Git repository used as the Config Server back end, should be started with `http://`, `https://`, `git@`, or `ssh://`.
        /// </summary>
        [Input("uri", required: true)]
        public Input<string> Uri { get; set; } = null!;

        public SpringCloudServiceConfigServerGitSettingGetArgs()
        {
        }
    }

    public sealed class SpringCloudServiceConfigServerGitSettingHttpBasicAuthArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The password used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// The username that's used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public SpringCloudServiceConfigServerGitSettingHttpBasicAuthArgs()
        {
        }
    }

    public sealed class SpringCloudServiceConfigServerGitSettingHttpBasicAuthGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The password used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// The username that's used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public SpringCloudServiceConfigServerGitSettingHttpBasicAuthGetArgs()
        {
        }
    }

    public sealed class SpringCloudServiceConfigServerGitSettingRepositoriesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `http_basic_auth` block as defined below.
        /// </summary>
        [Input("httpBasicAuth")]
        public Input<SpringCloudServiceConfigServerGitSettingRepositoriesHttpBasicAuthArgs>? HttpBasicAuth { get; set; }

        /// <summary>
        /// The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        /// <summary>
        /// A name to identify on the Git repository, required only if repos exists.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("patterns")]
        private InputList<string>? _patterns;

        /// <summary>
        /// An array of strings used to match an application name. For each pattern, use the `{application}/{profile}` format with wildcards.
        /// </summary>
        public InputList<string> Patterns
        {
            get => _patterns ?? (_patterns = new InputList<string>());
            set => _patterns = value;
        }

        [Input("searchPaths")]
        private InputList<string>? _searchPaths;

        /// <summary>
        /// An array of strings used to search subdirectories of the Git repository.
        /// </summary>
        public InputList<string> SearchPaths
        {
            get => _searchPaths ?? (_searchPaths = new InputList<string>());
            set => _searchPaths = value;
        }

        /// <summary>
        /// A `ssh_auth` block as defined below.
        /// </summary>
        [Input("sshAuth")]
        public Input<SpringCloudServiceConfigServerGitSettingRepositoriesSshAuthArgs>? SshAuth { get; set; }

        /// <summary>
        /// The URI of the Git repository that's used as the Config Server back end should be started with `http://`, `https://`, `git@`, or `ssh://`.
        /// </summary>
        [Input("uri", required: true)]
        public Input<string> Uri { get; set; } = null!;

        public SpringCloudServiceConfigServerGitSettingRepositoriesArgs()
        {
        }
    }

    public sealed class SpringCloudServiceConfigServerGitSettingRepositoriesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `http_basic_auth` block as defined below.
        /// </summary>
        [Input("httpBasicAuth")]
        public Input<SpringCloudServiceConfigServerGitSettingRepositoriesHttpBasicAuthGetArgs>? HttpBasicAuth { get; set; }

        /// <summary>
        /// The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        /// <summary>
        /// A name to identify on the Git repository, required only if repos exists.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("patterns")]
        private InputList<string>? _patterns;

        /// <summary>
        /// An array of strings used to match an application name. For each pattern, use the `{application}/{profile}` format with wildcards.
        /// </summary>
        public InputList<string> Patterns
        {
            get => _patterns ?? (_patterns = new InputList<string>());
            set => _patterns = value;
        }

        [Input("searchPaths")]
        private InputList<string>? _searchPaths;

        /// <summary>
        /// An array of strings used to search subdirectories of the Git repository.
        /// </summary>
        public InputList<string> SearchPaths
        {
            get => _searchPaths ?? (_searchPaths = new InputList<string>());
            set => _searchPaths = value;
        }

        /// <summary>
        /// A `ssh_auth` block as defined below.
        /// </summary>
        [Input("sshAuth")]
        public Input<SpringCloudServiceConfigServerGitSettingRepositoriesSshAuthGetArgs>? SshAuth { get; set; }

        /// <summary>
        /// The URI of the Git repository that's used as the Config Server back end should be started with `http://`, `https://`, `git@`, or `ssh://`.
        /// </summary>
        [Input("uri", required: true)]
        public Input<string> Uri { get; set; } = null!;

        public SpringCloudServiceConfigServerGitSettingRepositoriesGetArgs()
        {
        }
    }

    public sealed class SpringCloudServiceConfigServerGitSettingRepositoriesHttpBasicAuthArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The password used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// The username that's used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public SpringCloudServiceConfigServerGitSettingRepositoriesHttpBasicAuthArgs()
        {
        }
    }

    public sealed class SpringCloudServiceConfigServerGitSettingRepositoriesHttpBasicAuthGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The password used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// The username that's used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public SpringCloudServiceConfigServerGitSettingRepositoriesHttpBasicAuthGetArgs()
        {
        }
    }

    public sealed class SpringCloudServiceConfigServerGitSettingRepositoriesSshAuthArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The host key of the Git repository server, should not include the algorithm prefix as covered by `host-key-algorithm`.
        /// </summary>
        [Input("hostKey")]
        public Input<string>? HostKey { get; set; }

        /// <summary>
        /// The host key algorithm, should be `ssh-dss`, `ssh-rsa`, `ecdsa-sha2-nistp256`, `ecdsa-sha2-nistp384`, or `ecdsa-sha2-nistp521`. Required only if `host-key` exists.
        /// </summary>
        [Input("hostKeyAlgorithm")]
        public Input<string>? HostKeyAlgorithm { get; set; }

        /// <summary>
        /// The SSH private key to access the Git repository, required when the URI starts with `git@` or `ssh://`.
        /// </summary>
        [Input("privateKey", required: true)]
        public Input<string> PrivateKey { get; set; } = null!;

        /// <summary>
        /// Indicates whether the Config Server instance will fail to start if the host_key does not match.
        /// </summary>
        [Input("strictHostKeyCheckingEnabled")]
        public Input<bool>? StrictHostKeyCheckingEnabled { get; set; }

        public SpringCloudServiceConfigServerGitSettingRepositoriesSshAuthArgs()
        {
        }
    }

    public sealed class SpringCloudServiceConfigServerGitSettingRepositoriesSshAuthGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The host key of the Git repository server, should not include the algorithm prefix as covered by `host-key-algorithm`.
        /// </summary>
        [Input("hostKey")]
        public Input<string>? HostKey { get; set; }

        /// <summary>
        /// The host key algorithm, should be `ssh-dss`, `ssh-rsa`, `ecdsa-sha2-nistp256`, `ecdsa-sha2-nistp384`, or `ecdsa-sha2-nistp521`. Required only if `host-key` exists.
        /// </summary>
        [Input("hostKeyAlgorithm")]
        public Input<string>? HostKeyAlgorithm { get; set; }

        /// <summary>
        /// The SSH private key to access the Git repository, required when the URI starts with `git@` or `ssh://`.
        /// </summary>
        [Input("privateKey", required: true)]
        public Input<string> PrivateKey { get; set; } = null!;

        /// <summary>
        /// Indicates whether the Config Server instance will fail to start if the host_key does not match.
        /// </summary>
        [Input("strictHostKeyCheckingEnabled")]
        public Input<bool>? StrictHostKeyCheckingEnabled { get; set; }

        public SpringCloudServiceConfigServerGitSettingRepositoriesSshAuthGetArgs()
        {
        }
    }

    public sealed class SpringCloudServiceConfigServerGitSettingSshAuthArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The host key of the Git repository server, should not include the algorithm prefix as covered by `host-key-algorithm`.
        /// </summary>
        [Input("hostKey")]
        public Input<string>? HostKey { get; set; }

        /// <summary>
        /// The host key algorithm, should be `ssh-dss`, `ssh-rsa`, `ecdsa-sha2-nistp256`, `ecdsa-sha2-nistp384`, or `ecdsa-sha2-nistp521`. Required only if `host-key` exists.
        /// </summary>
        [Input("hostKeyAlgorithm")]
        public Input<string>? HostKeyAlgorithm { get; set; }

        /// <summary>
        /// The SSH private key to access the Git repository, required when the URI starts with `git@` or `ssh://`.
        /// </summary>
        [Input("privateKey", required: true)]
        public Input<string> PrivateKey { get; set; } = null!;

        /// <summary>
        /// Indicates whether the Config Server instance will fail to start if the host_key does not match.
        /// </summary>
        [Input("strictHostKeyCheckingEnabled")]
        public Input<bool>? StrictHostKeyCheckingEnabled { get; set; }

        public SpringCloudServiceConfigServerGitSettingSshAuthArgs()
        {
        }
    }

    public sealed class SpringCloudServiceConfigServerGitSettingSshAuthGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The host key of the Git repository server, should not include the algorithm prefix as covered by `host-key-algorithm`.
        /// </summary>
        [Input("hostKey")]
        public Input<string>? HostKey { get; set; }

        /// <summary>
        /// The host key algorithm, should be `ssh-dss`, `ssh-rsa`, `ecdsa-sha2-nistp256`, `ecdsa-sha2-nistp384`, or `ecdsa-sha2-nistp521`. Required only if `host-key` exists.
        /// </summary>
        [Input("hostKeyAlgorithm")]
        public Input<string>? HostKeyAlgorithm { get; set; }

        /// <summary>
        /// The SSH private key to access the Git repository, required when the URI starts with `git@` or `ssh://`.
        /// </summary>
        [Input("privateKey", required: true)]
        public Input<string> PrivateKey { get; set; } = null!;

        /// <summary>
        /// Indicates whether the Config Server instance will fail to start if the host_key does not match.
        /// </summary>
        [Input("strictHostKeyCheckingEnabled")]
        public Input<bool>? StrictHostKeyCheckingEnabled { get; set; }

        public SpringCloudServiceConfigServerGitSettingSshAuthGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class SpringCloudServiceConfigServerGitSetting
    {
        /// <summary>
        /// A `http_basic_auth` block as defined below.
        /// </summary>
        public readonly SpringCloudServiceConfigServerGitSettingHttpBasicAuth? HttpBasicAuth;
        /// <summary>
        /// The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.
        /// </summary>
        public readonly string? Label;
        /// <summary>
        /// One or more `repository` blocks as defined below.
        /// </summary>
        public readonly ImmutableArray<SpringCloudServiceConfigServerGitSettingRepositories> Repositories;
        /// <summary>
        /// An array of strings used to search subdirectories of the Git repository.
        /// </summary>
        public readonly ImmutableArray<string> SearchPaths;
        /// <summary>
        /// A `ssh_auth` block as defined below.
        /// </summary>
        public readonly SpringCloudServiceConfigServerGitSettingSshAuth? SshAuth;
        /// <summary>
        /// The URI of the default Git repository used as the Config Server back end, should be started with `http://`, `https://`, `git@`, or `ssh://`.
        /// </summary>
        public readonly string Uri;

        [OutputConstructor]
        private SpringCloudServiceConfigServerGitSetting(
            SpringCloudServiceConfigServerGitSettingHttpBasicAuth? httpBasicAuth,
            string? label,
            ImmutableArray<SpringCloudServiceConfigServerGitSettingRepositories> repositories,
            ImmutableArray<string> searchPaths,
            SpringCloudServiceConfigServerGitSettingSshAuth? sshAuth,
            string uri)
        {
            HttpBasicAuth = httpBasicAuth;
            Label = label;
            Repositories = repositories;
            SearchPaths = searchPaths;
            SshAuth = sshAuth;
            Uri = uri;
        }
    }

    [OutputType]
    public sealed class SpringCloudServiceConfigServerGitSettingHttpBasicAuth
    {
        /// <summary>
        /// The password used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// The username that's used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        /// </summary>
        public readonly string Username;

        [OutputConstructor]
        private SpringCloudServiceConfigServerGitSettingHttpBasicAuth(
            string password,
            string username)
        {
            Password = password;
            Username = username;
        }
    }

    [OutputType]
    public sealed class SpringCloudServiceConfigServerGitSettingRepositories
    {
        /// <summary>
        /// A `http_basic_auth` block as defined below.
        /// </summary>
        public readonly SpringCloudServiceConfigServerGitSettingRepositoriesHttpBasicAuth? HttpBasicAuth;
        /// <summary>
        /// The default label of the Git repository, should be the branch name, tag name, or commit-id of the repository.
        /// </summary>
        public readonly string? Label;
        /// <summary>
        /// A name to identify on the Git repository, required only if repos exists.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// An array of strings used to match an application name. For each pattern, use the `{application}/{profile}` format with wildcards.
        /// </summary>
        public readonly ImmutableArray<string> Patterns;
        /// <summary>
        /// An array of strings used to search subdirectories of the Git repository.
        /// </summary>
        public readonly ImmutableArray<string> SearchPaths;
        /// <summary>
        /// A `ssh_auth` block as defined below.
        /// </summary>
        public readonly SpringCloudServiceConfigServerGitSettingRepositoriesSshAuth? SshAuth;
        /// <summary>
        /// The URI of the Git repository that's used as the Config Server back end should be started with `http://`, `https://`, `git@`, or `ssh://`.
        /// </summary>
        public readonly string Uri;

        [OutputConstructor]
        private SpringCloudServiceConfigServerGitSettingRepositories(
            SpringCloudServiceConfigServerGitSettingRepositoriesHttpBasicAuth? httpBasicAuth,
            string? label,
            string name,
            ImmutableArray<string> patterns,
            ImmutableArray<string> searchPaths,
            SpringCloudServiceConfigServerGitSettingRepositoriesSshAuth? sshAuth,
            string uri)
        {
            HttpBasicAuth = httpBasicAuth;
            Label = label;
            Name = name;
            Patterns = patterns;
            SearchPaths = searchPaths;
            SshAuth = sshAuth;
            Uri = uri;
        }
    }

    [OutputType]
    public sealed class SpringCloudServiceConfigServerGitSettingRepositoriesHttpBasicAuth
    {
        /// <summary>
        /// The password used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// The username that's used to access the Git repository server, required when the Git repository server supports Http Basic Authentication.
        /// </summary>
        public readonly string Username;

        [OutputConstructor]
        private SpringCloudServiceConfigServerGitSettingRepositoriesHttpBasicAuth(
            string password,
            string username)
        {
            Password = password;
            Username = username;
        }
    }

    [OutputType]
    public sealed class SpringCloudServiceConfigServerGitSettingRepositoriesSshAuth
    {
        /// <summary>
        /// The host key of the Git repository server, should not include the algorithm prefix as covered by `host-key-algorithm`.
        /// </summary>
        public readonly string? HostKey;
        /// <summary>
        /// The host key algorithm, should be `ssh-dss`, `ssh-rsa`, `ecdsa-sha2-nistp256`, `ecdsa-sha2-nistp384`, or `ecdsa-sha2-nistp521`. Required only if `host-key` exists.
        /// </summary>
        public readonly string? HostKeyAlgorithm;
        /// <summary>
        /// The SSH private key to access the Git repository, required when the URI starts with `git@` or `ssh://`.
        /// </summary>
        public readonly string PrivateKey;
        /// <summary>
        /// Indicates whether the Config Server instance will fail to start if the host_key does not match.
        /// </summary>
        public readonly bool? StrictHostKeyCheckingEnabled;

        [OutputConstructor]
        private SpringCloudServiceConfigServerGitSettingRepositoriesSshAuth(
            string? hostKey,
            string? hostKeyAlgorithm,
            string privateKey,
            bool? strictHostKeyCheckingEnabled)
        {
            HostKey = hostKey;
            HostKeyAlgorithm = hostKeyAlgorithm;
            PrivateKey = privateKey;
            StrictHostKeyCheckingEnabled = strictHostKeyCheckingEnabled;
        }
    }

    [OutputType]
    public sealed class SpringCloudServiceConfigServerGitSettingSshAuth
    {
        /// <summary>
        /// The host key of the Git repository server, should not include the algorithm prefix as covered by `host-key-algorithm`.
        /// </summary>
        public readonly string? HostKey;
        /// <summary>
        /// The host key algorithm, should be `ssh-dss`, `ssh-rsa`, `ecdsa-sha2-nistp256`, `ecdsa-sha2-nistp384`, or `ecdsa-sha2-nistp521`. Required only if `host-key` exists.
        /// </summary>
        public readonly string? HostKeyAlgorithm;
        /// <summary>
        /// The SSH private key to access the Git repository, required when the URI starts with `git@` or `ssh://`.
        /// </summary>
        public readonly string PrivateKey;
        /// <summary>
        /// Indicates whether the Config Server instance will fail to start if the host_key does not match.
        /// </summary>
        public readonly bool? StrictHostKeyCheckingEnabled;

        [OutputConstructor]
        private SpringCloudServiceConfigServerGitSettingSshAuth(
            string? hostKey,
            string? hostKeyAlgorithm,
            string privateKey,
            bool? strictHostKeyCheckingEnabled)
        {
            HostKey = hostKey;
            HostKeyAlgorithm = hostKeyAlgorithm;
            PrivateKey = privateKey;
            StrictHostKeyCheckingEnabled = strictHostKeyCheckingEnabled;
        }
    }
    }
}
