// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manage a custom virtual machine image that can be used to create virtual machines.
type Image struct {
	s *pulumi.ResourceState
}

// NewImage registers a new resource with the given unique name, arguments, and options.
func NewImage(ctx *pulumi.Context,
	name string, args *ImageArgs, opts ...pulumi.ResourceOpt) (*Image, error) {
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["dataDisks"] = nil
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["osDisk"] = nil
		inputs["resourceGroupName"] = nil
		inputs["sourceVirtualMachineId"] = nil
		inputs["tags"] = nil
		inputs["zoneResilient"] = nil
	} else {
		inputs["dataDisks"] = args.DataDisks
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["osDisk"] = args.OsDisk
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["sourceVirtualMachineId"] = args.SourceVirtualMachineId
		inputs["tags"] = args.Tags
		inputs["zoneResilient"] = args.ZoneResilient
	}
	s, err := ctx.RegisterResource("azure:compute/image:Image", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Image{s: s}, nil
}

// GetImage gets an existing Image resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetImage(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ImageState, opts ...pulumi.ResourceOpt) (*Image, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["dataDisks"] = state.DataDisks
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["osDisk"] = state.OsDisk
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["sourceVirtualMachineId"] = state.SourceVirtualMachineId
		inputs["tags"] = state.Tags
		inputs["zoneResilient"] = state.ZoneResilient
	}
	s, err := ctx.ReadResource("azure:compute/image:Image", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Image{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Image) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Image) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// One or more `data_disk` elements as defined below.
func (r *Image) DataDisks() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["dataDisks"])
}

// Specified the supported Azure location where the resource exists.
// Changing this forces a new resource to be created.
func (r *Image) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// Specifies the name of the image. Changing this forces a
// new resource to be created.
func (r *Image) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// One or more `os_disk` elements as defined below.
func (r *Image) OsDisk() *pulumi.Output {
	return r.s.State["osDisk"]
}

// The name of the resource group in which to create
// the image. Changing this forces a new resource to be created.
func (r *Image) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// The Virtual Machine ID from which to create the image.
func (r *Image) SourceVirtualMachineId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["sourceVirtualMachineId"])
}

// A mapping of tags to assign to the resource.
func (r *Image) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Is zone resiliency enabled?  Defaults to `false`.  Changing this forces a new resource to be created.
func (r *Image) ZoneResilient() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["zoneResilient"])
}

// Input properties used for looking up and filtering Image resources.
type ImageState struct {
	// One or more `data_disk` elements as defined below.
	DataDisks interface{}
	// Specified the supported Azure location where the resource exists.
	// Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the image. Changing this forces a
	// new resource to be created.
	Name interface{}
	// One or more `os_disk` elements as defined below.
	OsDisk interface{}
	// The name of the resource group in which to create
	// the image. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// The Virtual Machine ID from which to create the image.
	SourceVirtualMachineId interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// Is zone resiliency enabled?  Defaults to `false`.  Changing this forces a new resource to be created.
	ZoneResilient interface{}
}

// The set of arguments for constructing a Image resource.
type ImageArgs struct {
	// One or more `data_disk` elements as defined below.
	DataDisks interface{}
	// Specified the supported Azure location where the resource exists.
	// Changing this forces a new resource to be created.
	Location interface{}
	// Specifies the name of the image. Changing this forces a
	// new resource to be created.
	Name interface{}
	// One or more `os_disk` elements as defined below.
	OsDisk interface{}
	// The name of the resource group in which to create
	// the image. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// The Virtual Machine ID from which to create the image.
	SourceVirtualMachineId interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// Is zone resiliency enabled?  Defaults to `false`.  Changing this forces a new resource to be created.
	ZoneResilient interface{}
}
