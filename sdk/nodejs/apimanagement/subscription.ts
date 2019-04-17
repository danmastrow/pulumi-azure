// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a Subscription within a API Management Service.
 * 
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const testService = pulumi.output(azure.apimanagement.getService({
 *     name: "example-apim",
 *     resourceGroupName: "example-resources",
 * }));
 * const testProduct = pulumi.all([testService, testService]).apply(([testService, testService1]) => azure.apimanagement.getProduct({
 *     apiManagementName: testService.name,
 *     productId: "00000000-0000-0000-0000-000000000000",
 *     resourceGroupName: testService1.resourceGroupName,
 * }));
 * const testUser = pulumi.all([testService, testService]).apply(([testService, testService1]) => azure.apimanagement.getUser({
 *     apiManagementName: testService.name,
 *     resourceGroupName: testService1.resourceGroupName,
 *     userId: "11111111-1111-1111-1111-111111111111",
 * }));
 * const testSubscription = new azure.apimanagement.Subscription("test", {
 *     apiManagementName: testService.apply(testService => testService.name),
 *     displayName: "Parser API",
 *     productId: testProduct.apply(testProduct => testProduct.id),
 *     resourceGroupName: testService.apply(testService => testService.resourceGroupName),
 *     userId: testUser.apply(testUser => testUser.id),
 * });
 * ```
 */
export class Subscription extends pulumi.CustomResource {
    /**
     * Get an existing Subscription resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SubscriptionState, opts?: pulumi.CustomResourceOptions): Subscription {
        return new Subscription(name, <any>state, { ...opts, id: id });
    }

    /**
     * The name of the API Management Service where this Subscription should be created. Changing this forces a new resource to be created.
     */
    public readonly apiManagementName: pulumi.Output<string>;
    /**
     * The display name of this Subscription.
     */
    public readonly displayName: pulumi.Output<string>;
    public readonly primaryKey: pulumi.Output<string>;
    /**
     * The ID of the Product which should be assigned to this Subscription. Changing this forces a new resource to be created.
     */
    public readonly productId: pulumi.Output<string>;
    /**
     * The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName: pulumi.Output<string>;
    public readonly secondaryKey: pulumi.Output<string>;
    /**
     * The state of this Subscription. Possible values are `Active`, `Cancelled`, `Expired`, `Rejected`, `Submitted` and `Suspended`. Defaults to `Submitted`.
     */
    public readonly state: pulumi.Output<string | undefined>;
    /**
     * An Identifier which should used as the ID of this Subscription. If not specified a new Subscription ID will be generated. Changing this forces a new resource to be created.
     */
    public readonly subscriptionId: pulumi.Output<string>;
    /**
     * The ID of the User which should be assigned to this Subscription. Changing this forces a new resource to be created.
     */
    public readonly userId: pulumi.Output<string>;

    /**
     * Create a Subscription resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SubscriptionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SubscriptionArgs | SubscriptionState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: SubscriptionState = argsOrState as SubscriptionState | undefined;
            inputs["apiManagementName"] = state ? state.apiManagementName : undefined;
            inputs["displayName"] = state ? state.displayName : undefined;
            inputs["primaryKey"] = state ? state.primaryKey : undefined;
            inputs["productId"] = state ? state.productId : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["secondaryKey"] = state ? state.secondaryKey : undefined;
            inputs["state"] = state ? state.state : undefined;
            inputs["subscriptionId"] = state ? state.subscriptionId : undefined;
            inputs["userId"] = state ? state.userId : undefined;
        } else {
            const args = argsOrState as SubscriptionArgs | undefined;
            if (!args || args.apiManagementName === undefined) {
                throw new Error("Missing required property 'apiManagementName'");
            }
            if (!args || args.displayName === undefined) {
                throw new Error("Missing required property 'displayName'");
            }
            if (!args || args.productId === undefined) {
                throw new Error("Missing required property 'productId'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.userId === undefined) {
                throw new Error("Missing required property 'userId'");
            }
            inputs["apiManagementName"] = args ? args.apiManagementName : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["primaryKey"] = args ? args.primaryKey : undefined;
            inputs["productId"] = args ? args.productId : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["secondaryKey"] = args ? args.secondaryKey : undefined;
            inputs["state"] = args ? args.state : undefined;
            inputs["subscriptionId"] = args ? args.subscriptionId : undefined;
            inputs["userId"] = args ? args.userId : undefined;
        }
        super("azure:apimanagement/subscription:Subscription", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Subscription resources.
 */
export interface SubscriptionState {
    /**
     * The name of the API Management Service where this Subscription should be created. Changing this forces a new resource to be created.
     */
    readonly apiManagementName?: pulumi.Input<string>;
    /**
     * The display name of this Subscription.
     */
    readonly displayName?: pulumi.Input<string>;
    readonly primaryKey?: pulumi.Input<string>;
    /**
     * The ID of the Product which should be assigned to this Subscription. Changing this forces a new resource to be created.
     */
    readonly productId?: pulumi.Input<string>;
    /**
     * The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    readonly secondaryKey?: pulumi.Input<string>;
    /**
     * The state of this Subscription. Possible values are `Active`, `Cancelled`, `Expired`, `Rejected`, `Submitted` and `Suspended`. Defaults to `Submitted`.
     */
    readonly state?: pulumi.Input<string>;
    /**
     * An Identifier which should used as the ID of this Subscription. If not specified a new Subscription ID will be generated. Changing this forces a new resource to be created.
     */
    readonly subscriptionId?: pulumi.Input<string>;
    /**
     * The ID of the User which should be assigned to this Subscription. Changing this forces a new resource to be created.
     */
    readonly userId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Subscription resource.
 */
export interface SubscriptionArgs {
    /**
     * The name of the API Management Service where this Subscription should be created. Changing this forces a new resource to be created.
     */
    readonly apiManagementName: pulumi.Input<string>;
    /**
     * The display name of this Subscription.
     */
    readonly displayName: pulumi.Input<string>;
    readonly primaryKey?: pulumi.Input<string>;
    /**
     * The ID of the Product which should be assigned to this Subscription. Changing this forces a new resource to be created.
     */
    readonly productId: pulumi.Input<string>;
    /**
     * The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    readonly secondaryKey?: pulumi.Input<string>;
    /**
     * The state of this Subscription. Possible values are `Active`, `Cancelled`, `Expired`, `Rejected`, `Submitted` and `Suspended`. Defaults to `Submitted`.
     */
    readonly state?: pulumi.Input<string>;
    /**
     * An Identifier which should used as the ID of this Subscription. If not specified a new Subscription ID will be generated. Changing this forces a new resource to be created.
     */
    readonly subscriptionId?: pulumi.Input<string>;
    /**
     * The ID of the User which should be assigned to this Subscription. Changing this forces a new resource to be created.
     */
    readonly userId: pulumi.Input<string>;
}
