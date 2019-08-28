// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package mssql

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing SQL elastic pool.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/mssql_elasticpool.html.markdown.
func LookupElasticPool(ctx *pulumi.Context, args *GetElasticPoolArgs) (*GetElasticPoolResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["serverName"] = args.ServerName
	}
	outputs, err := ctx.Invoke("azure:mssql/getElasticPool:getElasticPool", inputs)
	if err != nil {
		return nil, err
	}
	return &GetElasticPoolResult{
		Location: outputs["location"],
		MaxSizeBytes: outputs["maxSizeBytes"],
		MaxSizeGb: outputs["maxSizeGb"],
		Name: outputs["name"],
		PerDbMaxCapacity: outputs["perDbMaxCapacity"],
		PerDbMinCapacity: outputs["perDbMinCapacity"],
		ResourceGroupName: outputs["resourceGroupName"],
		ServerName: outputs["serverName"],
		Tags: outputs["tags"],
		ZoneRedundant: outputs["zoneRedundant"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getElasticPool.
type GetElasticPoolArgs struct {
	// The name of the elastic pool.
	Name interface{}
	// The name of the resource group which contains the elastic pool.
	ResourceGroupName interface{}
	// The name of the SQL Server which contains the elastic pool.
	ServerName interface{}
}

// A collection of values returned by getElasticPool.
type GetElasticPoolResult struct {
	// Specifies the supported Azure location where the resource exists.
	Location interface{}
	// The max data size of the elastic pool in bytes.
	MaxSizeBytes interface{}
	// The max data size of the elastic pool in gigabytes.
	MaxSizeGb interface{}
	Name interface{}
	// The maximum capacity any one database can consume.
	PerDbMaxCapacity interface{}
	// The minimum capacity all databases are guaranteed.
	PerDbMinCapacity interface{}
	ResourceGroupName interface{}
	ServerName interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// Whether or not this elastic pool is zone redundant.
	ZoneRedundant interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
