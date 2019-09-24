// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package eventhub

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a ServiceBus Namespace.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/servicebus_namespace_legacy.html.markdown.
type Namespace struct {
	s *pulumi.ResourceState
}

// NewNamespace registers a new resource with the given unique name, arguments, and options.
func NewNamespace(ctx *pulumi.Context,
	name string, args *NamespaceArgs, opts ...pulumi.ResourceOpt) (*Namespace, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Sku == nil {
		return nil, errors.New("missing required argument 'Sku'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["capacity"] = nil
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["resourceGroupName"] = nil
		inputs["sku"] = nil
		inputs["tags"] = nil
	} else {
		inputs["capacity"] = args.Capacity
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["sku"] = args.Sku
		inputs["tags"] = args.Tags
	}
	inputs["defaultPrimaryConnectionString"] = nil
	inputs["defaultPrimaryKey"] = nil
	inputs["defaultSecondaryConnectionString"] = nil
	inputs["defaultSecondaryKey"] = nil
	s, err := ctx.RegisterResource("azure:eventhub/namespace:Namespace", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Namespace{s: s}, nil
}

// GetNamespace gets an existing Namespace resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNamespace(ctx *pulumi.Context,
	name string, id pulumi.ID, state *NamespaceState, opts ...pulumi.ResourceOpt) (*Namespace, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["capacity"] = state.Capacity
		inputs["defaultPrimaryConnectionString"] = state.DefaultPrimaryConnectionString
		inputs["defaultPrimaryKey"] = state.DefaultPrimaryKey
		inputs["defaultSecondaryConnectionString"] = state.DefaultSecondaryConnectionString
		inputs["defaultSecondaryKey"] = state.DefaultSecondaryKey
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["sku"] = state.Sku
		inputs["tags"] = state.Tags
	}
	s, err := ctx.ReadResource("azure:eventhub/namespace:Namespace", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Namespace{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Namespace) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Namespace) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// Specifies the capacity. When `sku` is `Premium` can be `1`, `2` or `4`. When `sku` is `Basic` or `Standard` can be `0` only.
func (r *Namespace) Capacity() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["capacity"])
}

// The primary connection string for the authorization
// rule `RootManageSharedAccessKey`.
func (r *Namespace) DefaultPrimaryConnectionString() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["defaultPrimaryConnectionString"])
}

// The primary access key for the authorization rule `RootManageSharedAccessKey`.
func (r *Namespace) DefaultPrimaryKey() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["defaultPrimaryKey"])
}

// The secondary connection string for the
// authorization rule `RootManageSharedAccessKey`.
func (r *Namespace) DefaultSecondaryConnectionString() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["defaultSecondaryConnectionString"])
}

// The secondary access key for the authorization rule `RootManageSharedAccessKey`.
func (r *Namespace) DefaultSecondaryKey() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["defaultSecondaryKey"])
}

// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
func (r *Namespace) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// Specifies the name of the ServiceBus Namespace resource . Changing this forces a
// new resource to be created.
func (r *Namespace) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The name of the resource group in which to
// create the namespace.
func (r *Namespace) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// Defines which tier to use. Options are basic, standard or premium.
func (r *Namespace) Sku() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["sku"])
}

// A mapping of tags to assign to the resource.
func (r *Namespace) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Input properties used for looking up and filtering Namespace resources.
type NamespaceState struct {
	// Specifies the capacity. When `sku` is `Premium` can be `1`, `2` or `4`. When `sku` is `Basic` or `Standard` can be `0` only.
	Capacity interface{}
	// The primary connection string for the authorization
	// rule `RootManageSharedAccessKey`.
	DefaultPrimaryConnectionString interface{}
	// The primary access key for the authorization rule `RootManageSharedAccessKey`.
	DefaultPrimaryKey interface{}
	// The secondary connection string for the
	// authorization rule `RootManageSharedAccessKey`.
	DefaultSecondaryConnectionString interface{}
	// The secondary access key for the authorization rule `RootManageSharedAccessKey`.
	DefaultSecondaryKey interface{}
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the ServiceBus Namespace resource . Changing this forces a
	// new resource to be created.
	Name interface{}
	// The name of the resource group in which to
	// create the namespace.
	ResourceGroupName interface{}
	// Defines which tier to use. Options are basic, standard or premium.
	Sku interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}

// The set of arguments for constructing a Namespace resource.
type NamespaceArgs struct {
	// Specifies the capacity. When `sku` is `Premium` can be `1`, `2` or `4`. When `sku` is `Basic` or `Standard` can be `0` only.
	Capacity interface{}
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the ServiceBus Namespace resource . Changing this forces a
	// new resource to be created.
	Name interface{}
	// The name of the resource group in which to
	// create the namespace.
	ResourceGroupName interface{}
	// Defines which tier to use. Options are basic, standard or premium.
	Sku interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}
