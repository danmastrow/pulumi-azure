// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package automation

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing Automation Int Variable.
func LookupIntVariable(ctx *pulumi.Context, args *GetIntVariableArgs) (*GetIntVariableResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["automationAccountName"] = args.AutomationAccountName
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
	}
	outputs, err := ctx.Invoke("azure:automation/getIntVariable:getIntVariable", inputs)
	if err != nil {
		return nil, err
	}
	return &GetIntVariableResult{
		AutomationAccountName: outputs["automationAccountName"],
		Description: outputs["description"],
		Encrypted: outputs["encrypted"],
		Name: outputs["name"],
		ResourceGroupName: outputs["resourceGroupName"],
		Value: outputs["value"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getIntVariable.
type GetIntVariableArgs struct {
	// The name of the automation account in which the Automation Variable exists.
	AutomationAccountName interface{}
	// The name of the Automation Variable.
	Name interface{}
	// The Name of the Resource Group where the automation account exists.
	ResourceGroupName interface{}
}

// A collection of values returned by getIntVariable.
type GetIntVariableResult struct {
	AutomationAccountName interface{}
	// The description of the Automation Variable.
	Description interface{}
	// Specifies if the Automation Variable is encrypted. Defaults to `false`.
	Encrypted interface{}
	Name interface{}
	ResourceGroupName interface{}
	// The value of the Automation Variable as a `integer`.
	Value interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}