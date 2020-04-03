// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package managementgroups

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing Management Group.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/management_group.html.markdown.
func LookupManagementGroup(ctx *pulumi.Context, args *LookupManagementGroupArgs, opts ...pulumi.InvokeOption) (*LookupManagementGroupResult, error) {
	var rv LookupManagementGroupResult
	err := ctx.Invoke("azure:managementgroups/getManagementGroup:getManagementGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getManagementGroup.
type LookupManagementGroupArgs struct {
	// Specifies the name or UUID of this Management Group.
	GroupId *string `pulumi:"groupId"`
	// Specifies the name or UUID of this Management Group.
	Name *string `pulumi:"name"`
}

// A collection of values returned by getManagementGroup.
type LookupManagementGroupResult struct {
	// A friendly name for the Management Group.
	DisplayName string `pulumi:"displayName"`
	GroupId     string `pulumi:"groupId"`
	// id is the provider-assigned unique ID for this managed resource.
	Id   string `pulumi:"id"`
	Name string `pulumi:"name"`
	// The ID of any Parent Management Group.
	ParentManagementGroupId string `pulumi:"parentManagementGroupId"`
	// A list of Subscription ID's which are assigned to the Management Group.
	SubscriptionIds []string `pulumi:"subscriptionIds"`
}
