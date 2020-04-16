// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.LogAnalytics
{
    /// <summary>
    /// Manages a Log Analytics (formally Operational Insights) Windows Performance Counter DataSource.
    /// </summary>
    public partial class DataSourceWindowsPerformanceCounter : Pulumi.CustomResource
    {
        /// <summary>
        /// The friendly name of the performance counter.
        /// </summary>
        [Output("counterName")]
        public Output<string> CounterName { get; private set; } = null!;

        /// <summary>
        /// The name of the virtual machine instance to which the Windows Performance Counter DataSource be applied. Specify a `*` will apply to all instances.
        /// </summary>
        [Output("instanceName")]
        public Output<string> InstanceName { get; private set; } = null!;

        /// <summary>
        /// The time of sample interval in seconds. Supports values between 10 and 2147483647.
        /// </summary>
        [Output("intervalSeconds")]
        public Output<int> IntervalSeconds { get; private set; } = null!;

        /// <summary>
        /// The Name which should be used for this Log Analytics Windows Performance Counter DataSource. Changing this forces a new Log Analytics Windows Performance Counter DataSource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The object name of the Log Analytics Windows Performance Counter DataSource.
        /// </summary>
        [Output("objectName")]
        public Output<string> ObjectName { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the Log Analytics Windows Performance Counter DataSource should exist. Changing this forces a new Log Analytics Windows Performance Counter DataSource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The name of the Log Analytics Workspace where the Log Analytics Windows Performance Counter DataSource should exist. Changing this forces a new Log Analytics Windows Performance Counter DataSource to be created.
        /// </summary>
        [Output("workspaceName")]
        public Output<string> WorkspaceName { get; private set; } = null!;


        /// <summary>
        /// Create a DataSourceWindowsPerformanceCounter resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DataSourceWindowsPerformanceCounter(string name, DataSourceWindowsPerformanceCounterArgs args, CustomResourceOptions? options = null)
            : base("azure:loganalytics/dataSourceWindowsPerformanceCounter:DataSourceWindowsPerformanceCounter", name, args ?? new DataSourceWindowsPerformanceCounterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DataSourceWindowsPerformanceCounter(string name, Input<string> id, DataSourceWindowsPerformanceCounterState? state = null, CustomResourceOptions? options = null)
            : base("azure:loganalytics/dataSourceWindowsPerformanceCounter:DataSourceWindowsPerformanceCounter", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DataSourceWindowsPerformanceCounter resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DataSourceWindowsPerformanceCounter Get(string name, Input<string> id, DataSourceWindowsPerformanceCounterState? state = null, CustomResourceOptions? options = null)
        {
            return new DataSourceWindowsPerformanceCounter(name, id, state, options);
        }
    }

    public sealed class DataSourceWindowsPerformanceCounterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The friendly name of the performance counter.
        /// </summary>
        [Input("counterName", required: true)]
        public Input<string> CounterName { get; set; } = null!;

        /// <summary>
        /// The name of the virtual machine instance to which the Windows Performance Counter DataSource be applied. Specify a `*` will apply to all instances.
        /// </summary>
        [Input("instanceName", required: true)]
        public Input<string> InstanceName { get; set; } = null!;

        /// <summary>
        /// The time of sample interval in seconds. Supports values between 10 and 2147483647.
        /// </summary>
        [Input("intervalSeconds", required: true)]
        public Input<int> IntervalSeconds { get; set; } = null!;

        /// <summary>
        /// The Name which should be used for this Log Analytics Windows Performance Counter DataSource. Changing this forces a new Log Analytics Windows Performance Counter DataSource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The object name of the Log Analytics Windows Performance Counter DataSource.
        /// </summary>
        [Input("objectName", required: true)]
        public Input<string> ObjectName { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the Log Analytics Windows Performance Counter DataSource should exist. Changing this forces a new Log Analytics Windows Performance Counter DataSource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Log Analytics Workspace where the Log Analytics Windows Performance Counter DataSource should exist. Changing this forces a new Log Analytics Windows Performance Counter DataSource to be created.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public DataSourceWindowsPerformanceCounterArgs()
        {
        }
    }

    public sealed class DataSourceWindowsPerformanceCounterState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The friendly name of the performance counter.
        /// </summary>
        [Input("counterName")]
        public Input<string>? CounterName { get; set; }

        /// <summary>
        /// The name of the virtual machine instance to which the Windows Performance Counter DataSource be applied. Specify a `*` will apply to all instances.
        /// </summary>
        [Input("instanceName")]
        public Input<string>? InstanceName { get; set; }

        /// <summary>
        /// The time of sample interval in seconds. Supports values between 10 and 2147483647.
        /// </summary>
        [Input("intervalSeconds")]
        public Input<int>? IntervalSeconds { get; set; }

        /// <summary>
        /// The Name which should be used for this Log Analytics Windows Performance Counter DataSource. Changing this forces a new Log Analytics Windows Performance Counter DataSource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The object name of the Log Analytics Windows Performance Counter DataSource.
        /// </summary>
        [Input("objectName")]
        public Input<string>? ObjectName { get; set; }

        /// <summary>
        /// The name of the Resource Group where the Log Analytics Windows Performance Counter DataSource should exist. Changing this forces a new Log Analytics Windows Performance Counter DataSource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The name of the Log Analytics Workspace where the Log Analytics Windows Performance Counter DataSource should exist. Changing this forces a new Log Analytics Windows Performance Counter DataSource to be created.
        /// </summary>
        [Input("workspaceName")]
        public Input<string>? WorkspaceName { get; set; }

        public DataSourceWindowsPerformanceCounterState()
        {
        }
    }
}