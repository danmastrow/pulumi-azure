// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package network

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing Azure Network DDoS Protection Plan.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/network_ddos_protection_plan.html.markdown.
func LookupNetworkDdosProtectionPlan(ctx *pulumi.Context, args *GetNetworkDdosProtectionPlanArgs) (*GetNetworkDdosProtectionPlanResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["tags"] = args.Tags
	}
	outputs, err := ctx.Invoke("azure:network/getNetworkDdosProtectionPlan:getNetworkDdosProtectionPlan", inputs)
	if err != nil {
		return nil, err
	}
	return &GetNetworkDdosProtectionPlanResult{
		Location: outputs["location"],
		Name: outputs["name"],
		ResourceGroupName: outputs["resourceGroupName"],
		Tags: outputs["tags"],
		VirtualNetworkIds: outputs["virtualNetworkIds"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getNetworkDdosProtectionPlan.
type GetNetworkDdosProtectionPlanArgs struct {
	// The name of the Network DDoS Protection Plan.
	Name interface{}
	// The name of the resource group where the Network DDoS Protection Plan exists.
	ResourceGroupName interface{}
	Tags interface{}
}

// A collection of values returned by getNetworkDdosProtectionPlan.
type GetNetworkDdosProtectionPlanResult struct {
	// Specifies the supported Azure location where the resource exists.
	Location interface{}
	Name interface{}
	ResourceGroupName interface{}
	// A mapping of tags assigned to the resource.
	Tags interface{}
	// The Resource ID list of the Virtual Networks associated with DDoS Protection Plan.
	VirtualNetworkIds interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
