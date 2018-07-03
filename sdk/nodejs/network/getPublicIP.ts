// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Use this data source to access the properties of an existing Azure Public IP Address.
 */
export function getPublicIP(args: GetPublicIPArgs): Promise<GetPublicIPResult> {
    return pulumi.runtime.invoke("azure:network/getPublicIP:getPublicIP", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
        "tags": args.tags,
    });
}

/**
 * A collection of arguments for invoking getPublicIP.
 */
export interface GetPublicIPArgs {
    /**
     * Specifies the name of the public IP address.
     */
    readonly name: pulumi.Input<string>;
    /**
     * Specifies the name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * A collection of values returned by getPublicIP.
 */
export interface GetPublicIPResult {
    /**
     * The label for the Domain Name.
     */
    readonly domainNameLabel: string;
    /**
     * Fully qualified domain name of the A DNS record associated with the public IP. This is the concatenation of the domainNameLabel and the regionalized DNS zone.
     */
    readonly fqdn: string;
    /**
     * Specifies the timeout for the TCP idle connection.
     */
    readonly idleTimeoutInMinutes: number;
    /**
     * The IP address value that was allocated.
     */
    readonly ipAddress: string;
    /**
     * A mapping of tags to assigned to the resource.
     */
    readonly tags: {[key: string]: any};
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}