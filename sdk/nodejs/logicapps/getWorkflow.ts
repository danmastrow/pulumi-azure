// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Gets information about a Logic App Workflow.
 */
export function getWorkflow(args: GetWorkflowArgs, opts?: pulumi.InvokeOptions): Promise<GetWorkflowResult> {
    return pulumi.runtime.invoke("azure:logicapps/getWorkflow:getWorkflow", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getWorkflow.
 */
export interface GetWorkflowArgs {
    /**
     * The name of the Logic App Workflow.
     */
    readonly name: string;
    /**
     * The name of the Resource Group in which the Logic App Workflow exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getWorkflow.
 */
export interface GetWorkflowResult {
    /**
     * The Access Endpoint for the Logic App Workflow
     */
    readonly accessEndpoint: string;
    /**
     * The Azure location where the Logic App Workflow exists.
     */
    readonly location: string;
    /**
     * A map of Key-Value pairs.
     */
    readonly parameters: {[key: string]: any};
    /**
     * A mapping of tags assigned to the resource.
     */
    readonly tags: {[key: string]: any};
    /**
     * The Schema used for this Logic App Workflow.
     */
    readonly workflowSchema: string;
    /**
     * The version of the Schema used for this Logic App Workflow. Defaults to `1.0.0.0`.
     */
    readonly workflowVersion: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
