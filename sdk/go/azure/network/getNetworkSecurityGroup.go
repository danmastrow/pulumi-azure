// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package network

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access the properties of a Network Security Group.
func LookupNetworkSecurityGroup(ctx *pulumi.Context, args *GetNetworkSecurityGroupArgs) (*GetNetworkSecurityGroupResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
	}
	outputs, err := ctx.Invoke("azure:network/getNetworkSecurityGroup:getNetworkSecurityGroup", inputs)
	if err != nil {
		return nil, err
	}
	return &GetNetworkSecurityGroupResult{
		Location: outputs["location"],
	}
		SecurityRules: outputs["securityRules"],
	}
		Tags: outputs["tags"],
	}
	}, nil
}

// A collection of arguments for invoking getNetworkSecurityGroup.
type GetNetworkSecurityGroupArgs struct {
	// Specifies the Name of the Network Security Group.
	Name interface{}
	// Specifies the Name of the Resource Group within which the Network Security Group exists
	ResourceGroupName interface{}
}

// A collection of values returned by getNetworkSecurityGroup.
type GetNetworkSecurityGroupResult struct {
	// The supported Azure location where the resource exists.
	Location interface{}
	// One or more `security_rule` blocks as defined below.
	SecurityRules interface{}
	// A mapping of tags assigned to the resource.
	Tags interface{}
}
