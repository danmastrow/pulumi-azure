// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Use this data source to access the properties of a Recovery Services Vault.
 */
export function getVault(args: GetVaultArgs): Promise<GetVaultResult> {
    return pulumi.runtime.invoke("azure:recoveryservices/getVault:getVault", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    });
}

/**
 * A collection of arguments for invoking getVault.
 */
export interface GetVaultArgs {
    /**
     * Specifies the name of the Recovery Services Vault. 
     */
    readonly name: pulumi.Input<string>;
    /**
     * The name of the resource group in which the Recovery Services Vault resides.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}

/**
 * A collection of values returned by getVault.
 */
export interface GetVaultResult {
    /**
     * The Azure location where the resource resides. 
     */
    readonly location: string;
    /**
     * The vault's current SKU.
     */
    readonly sku: string;
    /**
     * A mapping of tags assigned to the resource.
     */
    readonly tags: {[key: string]: any};
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}