// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package dns

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to obtain information about a DNS Zone.
func LookupZone(ctx *pulumi.Context, args *GetZoneArgs) (*GetZoneResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
	}
	outputs, err := ctx.Invoke("azure:dns/getZone:getZone", inputs)
	if err != nil {
		return nil, err
	}
	return &GetZoneResult{
		MaxNumberOfRecordSets: outputs["maxNumberOfRecordSets"],
	}
		NameServers: outputs["nameServers"],
	}
		NumberOfRecordSets: outputs["numberOfRecordSets"],
	}
		ResourceGroupName: outputs["resourceGroupName"],
	}
		Tags: outputs["tags"],
	}
	}, nil
}

// A collection of arguments for invoking getZone.
type GetZoneArgs struct {
	// The name of the DNS Zone.
	Name interface{}
	// The Name of the Resource Group where the DNS Zone exists.
	// If the Name of the Resource Group is not provided, the first DNS Zone from the list of DNS Zones
	// in your subscription that matches `name` will be returned.
	ResourceGroupName interface{}
}

// A collection of values returned by getZone.
type GetZoneResult struct {
	// Maximum number of Records in the zone.
	MaxNumberOfRecordSets interface{}
	// A list of values that make up the NS record for the zone.
	NameServers interface{}
	// The number of records already in the zone.
	NumberOfRecordSets interface{}
	ResourceGroupName interface{}
	// A mapping of tags to assign to the EventHub Namespace.
	Tags interface{}
}
