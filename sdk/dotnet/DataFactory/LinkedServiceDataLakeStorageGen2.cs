// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.DataFactory
{
    /// <summary>
    /// Manages a Linked Service (connection) between Data Lake Storage Gen2 and Azure Data Factory.
    /// </summary>
    public partial class LinkedServiceDataLakeStorageGen2 : Pulumi.CustomResource
    {
        /// <summary>
        /// A map of additional properties to associate with the Data Factory Linked Service MySQL.
        /// </summary>
        [Output("additionalProperties")]
        public Output<ImmutableDictionary<string, string>?> AdditionalProperties { get; private set; } = null!;

        /// <summary>
        /// List of tags that can be used for describing the Data Factory Linked Service MySQL.
        /// </summary>
        [Output("annotations")]
        public Output<ImmutableArray<string>> Annotations { get; private set; } = null!;

        /// <summary>
        /// The Data Factory name in which to associate the Linked Service with. Changing this forces a new resource.
        /// </summary>
        [Output("dataFactoryName")]
        public Output<string> DataFactoryName { get; private set; } = null!;

        /// <summary>
        /// The description for the Data Factory Linked Service MySQL.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The integration runtime reference to associate with the Data Factory Linked Service MySQL.
        /// </summary>
        [Output("integrationRuntimeName")]
        public Output<string?> IntegrationRuntimeName { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Data Factory Linked Service MySQL. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A map of parameters to associate with the Data Factory Linked Service MySQL.
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, string>?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Data Factory Linked Service MySQL. Changing this forces a new resource
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The service principal id in which to authenticate against the Azure Data Lake Storage Gen2 account.
        /// </summary>
        [Output("servicePrincipalId")]
        public Output<string> ServicePrincipalId { get; private set; } = null!;

        /// <summary>
        /// The service principal key in which to authenticate against the Azure Data Lake Storage Gen2 account.
        /// </summary>
        [Output("servicePrincipalKey")]
        public Output<string> ServicePrincipalKey { get; private set; } = null!;

        /// <summary>
        /// The tenant id or name in which to authenticate against the Azure Data Lake Storage Gen2 account.
        /// </summary>
        [Output("tenant")]
        public Output<string> Tenant { get; private set; } = null!;

        /// <summary>
        /// The endpoint for the Azure Data Lake Storage Gen2 service.
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a LinkedServiceDataLakeStorageGen2 resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LinkedServiceDataLakeStorageGen2(string name, LinkedServiceDataLakeStorageGen2Args args, CustomResourceOptions? options = null)
            : base("azure:datafactory/linkedServiceDataLakeStorageGen2:LinkedServiceDataLakeStorageGen2", name, args ?? new LinkedServiceDataLakeStorageGen2Args(), MakeResourceOptions(options, ""))
        {
        }

        private LinkedServiceDataLakeStorageGen2(string name, Input<string> id, LinkedServiceDataLakeStorageGen2State? state = null, CustomResourceOptions? options = null)
            : base("azure:datafactory/linkedServiceDataLakeStorageGen2:LinkedServiceDataLakeStorageGen2", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LinkedServiceDataLakeStorageGen2 resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LinkedServiceDataLakeStorageGen2 Get(string name, Input<string> id, LinkedServiceDataLakeStorageGen2State? state = null, CustomResourceOptions? options = null)
        {
            return new LinkedServiceDataLakeStorageGen2(name, id, state, options);
        }
    }

    public sealed class LinkedServiceDataLakeStorageGen2Args : Pulumi.ResourceArgs
    {
        [Input("additionalProperties")]
        private InputMap<string>? _additionalProperties;

        /// <summary>
        /// A map of additional properties to associate with the Data Factory Linked Service MySQL.
        /// </summary>
        public InputMap<string> AdditionalProperties
        {
            get => _additionalProperties ?? (_additionalProperties = new InputMap<string>());
            set => _additionalProperties = value;
        }

        [Input("annotations")]
        private InputList<string>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the Data Factory Linked Service MySQL.
        /// </summary>
        public InputList<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// The Data Factory name in which to associate the Linked Service with. Changing this forces a new resource.
        /// </summary>
        [Input("dataFactoryName", required: true)]
        public Input<string> DataFactoryName { get; set; } = null!;

        /// <summary>
        /// The description for the Data Factory Linked Service MySQL.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The integration runtime reference to associate with the Data Factory Linked Service MySQL.
        /// </summary>
        [Input("integrationRuntimeName")]
        public Input<string>? IntegrationRuntimeName { get; set; }

        /// <summary>
        /// Specifies the name of the Data Factory Linked Service MySQL. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// A map of parameters to associate with the Data Factory Linked Service MySQL.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        /// <summary>
        /// The name of the resource group in which to create the Data Factory Linked Service MySQL. Changing this forces a new resource
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The service principal id in which to authenticate against the Azure Data Lake Storage Gen2 account.
        /// </summary>
        [Input("servicePrincipalId", required: true)]
        public Input<string> ServicePrincipalId { get; set; } = null!;

        /// <summary>
        /// The service principal key in which to authenticate against the Azure Data Lake Storage Gen2 account.
        /// </summary>
        [Input("servicePrincipalKey", required: true)]
        public Input<string> ServicePrincipalKey { get; set; } = null!;

        /// <summary>
        /// The tenant id or name in which to authenticate against the Azure Data Lake Storage Gen2 account.
        /// </summary>
        [Input("tenant", required: true)]
        public Input<string> Tenant { get; set; } = null!;

        /// <summary>
        /// The endpoint for the Azure Data Lake Storage Gen2 service.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public LinkedServiceDataLakeStorageGen2Args()
        {
        }
    }

    public sealed class LinkedServiceDataLakeStorageGen2State : Pulumi.ResourceArgs
    {
        [Input("additionalProperties")]
        private InputMap<string>? _additionalProperties;

        /// <summary>
        /// A map of additional properties to associate with the Data Factory Linked Service MySQL.
        /// </summary>
        public InputMap<string> AdditionalProperties
        {
            get => _additionalProperties ?? (_additionalProperties = new InputMap<string>());
            set => _additionalProperties = value;
        }

        [Input("annotations")]
        private InputList<string>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the Data Factory Linked Service MySQL.
        /// </summary>
        public InputList<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<string>());
            set => _annotations = value;
        }

        /// <summary>
        /// The Data Factory name in which to associate the Linked Service with. Changing this forces a new resource.
        /// </summary>
        [Input("dataFactoryName")]
        public Input<string>? DataFactoryName { get; set; }

        /// <summary>
        /// The description for the Data Factory Linked Service MySQL.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The integration runtime reference to associate with the Data Factory Linked Service MySQL.
        /// </summary>
        [Input("integrationRuntimeName")]
        public Input<string>? IntegrationRuntimeName { get; set; }

        /// <summary>
        /// Specifies the name of the Data Factory Linked Service MySQL. Changing this forces a new resource to be created. Must be globally unique. See the [Microsoft documentation](https://docs.microsoft.com/en-us/azure/data-factory/naming-rules) for all restrictions.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// A map of parameters to associate with the Data Factory Linked Service MySQL.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        /// <summary>
        /// The name of the resource group in which to create the Data Factory Linked Service MySQL. Changing this forces a new resource
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The service principal id in which to authenticate against the Azure Data Lake Storage Gen2 account.
        /// </summary>
        [Input("servicePrincipalId")]
        public Input<string>? ServicePrincipalId { get; set; }

        /// <summary>
        /// The service principal key in which to authenticate against the Azure Data Lake Storage Gen2 account.
        /// </summary>
        [Input("servicePrincipalKey")]
        public Input<string>? ServicePrincipalKey { get; set; }

        /// <summary>
        /// The tenant id or name in which to authenticate against the Azure Data Lake Storage Gen2 account.
        /// </summary>
        [Input("tenant")]
        public Input<string>? Tenant { get; set; }

        /// <summary>
        /// The endpoint for the Azure Data Lake Storage Gen2 service.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public LinkedServiceDataLakeStorageGen2State()
        {
        }
    }
}