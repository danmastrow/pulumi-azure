# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class ApiSchema(pulumi.CustomResource):
    api_management_name: pulumi.Output[str]
    """
    The Name of the API Management Service where the API exists. Changing this forces a new resource to be created.
    """
    api_name: pulumi.Output[str]
    """
    The name of the API within the API Management Service where this API Schema should be created. Changing this forces a new resource to be created.
    """
    content_type: pulumi.Output[str]
    """
    The content type of the API Schema.
    """
    resource_group_name: pulumi.Output[str]
    """
    The Name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
    """
    schema_id: pulumi.Output[str]
    """
    A unique identifier for this API Schema. Changing this forces a new resource to be created.
    """
    value: pulumi.Output[str]
    """
    The JSON escaped string defining the document representing the Schema.
    """
    def __init__(__self__, resource_name, opts=None, api_management_name=None, api_name=None, content_type=None, resource_group_name=None, schema_id=None, value=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages an API Schema within an API Management Service.



        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_management_name: The Name of the API Management Service where the API exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] api_name: The name of the API within the API Management Service where this API Schema should be created. Changing this forces a new resource to be created.
        :param pulumi.Input[str] content_type: The content type of the API Schema.
        :param pulumi.Input[str] resource_group_name: The Name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] schema_id: A unique identifier for this API Schema. Changing this forces a new resource to be created.
        :param pulumi.Input[str] value: The JSON escaped string defining the document representing the Schema.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if api_management_name is None:
                raise TypeError("Missing required property 'api_management_name'")
            __props__['api_management_name'] = api_management_name
            if api_name is None:
                raise TypeError("Missing required property 'api_name'")
            __props__['api_name'] = api_name
            if content_type is None:
                raise TypeError("Missing required property 'content_type'")
            __props__['content_type'] = content_type
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if schema_id is None:
                raise TypeError("Missing required property 'schema_id'")
            __props__['schema_id'] = schema_id
            if value is None:
                raise TypeError("Missing required property 'value'")
            __props__['value'] = value
        super(ApiSchema, __self__).__init__(
            'azure:apimanagement/apiSchema:ApiSchema',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, api_management_name=None, api_name=None, content_type=None, resource_group_name=None, schema_id=None, value=None):
        """
        Get an existing ApiSchema resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] api_management_name: The Name of the API Management Service where the API exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] api_name: The name of the API within the API Management Service where this API Schema should be created. Changing this forces a new resource to be created.
        :param pulumi.Input[str] content_type: The content type of the API Schema.
        :param pulumi.Input[str] resource_group_name: The Name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] schema_id: A unique identifier for this API Schema. Changing this forces a new resource to be created.
        :param pulumi.Input[str] value: The JSON escaped string defining the document representing the Schema.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["api_management_name"] = api_management_name
        __props__["api_name"] = api_name
        __props__["content_type"] = content_type
        __props__["resource_group_name"] = resource_group_name
        __props__["schema_id"] = schema_id
        __props__["value"] = value
        return ApiSchema(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

