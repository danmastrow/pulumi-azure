// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing ServiceBus Namespace Authorization Rule.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const example = azure.servicebus.getNamespaceAuthorizationRule({
 *     name: "examplerule",
 *     namespaceName: "examplenamespace",
 *     resourceGroupName: "example-resources",
 * });
 * 
 * export const ruleId = example.id;
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/servicebus_namespace_authorization_rule.html.markdown.
 */
export function getNamespaceAuthorizationRule(args: GetNamespaceAuthorizationRuleArgs, opts?: pulumi.InvokeOptions): Promise<GetNamespaceAuthorizationRuleResult> & GetNamespaceAuthorizationRuleResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetNamespaceAuthorizationRuleResult> = pulumi.runtime.invoke("azure:servicebus/getNamespaceAuthorizationRule:getNamespaceAuthorizationRule", {
        "name": args.name,
        "namespaceName": args.namespaceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getNamespaceAuthorizationRule.
 */
export interface GetNamespaceAuthorizationRuleArgs {
    /**
     * Specifies the name of the ServiceBus Namespace Authorization Rule.
     */
    readonly name: string;
    /**
     * Specifies the name of the ServiceBus Namespace.
     */
    readonly namespaceName: string;
    /**
     * Specifies the name of the Resource Group where the ServiceBus Namespace exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getNamespaceAuthorizationRule.
 */
export interface GetNamespaceAuthorizationRuleResult {
    readonly name: string;
    readonly namespaceName: string;
    /**
     * The primary connection string for the authorization rule.
     */
    readonly primaryConnectionString: string;
    /**
     * The primary access key for the authorization rule.
     */
    readonly primaryKey: string;
    readonly resourceGroupName: string;
    /**
     * The secondary connection string for the authorization rule.
     */
    readonly secondaryConnectionString: string;
    /**
     * The secondary access key for the authorization rule.
     */
    readonly secondaryKey: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
