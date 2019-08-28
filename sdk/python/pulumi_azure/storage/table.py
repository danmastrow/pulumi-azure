# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Table(pulumi.CustomResource):
    acls: pulumi.Output[list]
    """
    One or more `acl` blocks as defined below.
    
      * `access_policies` (`list`)
    
        * `expiry` (`str`)
        * `permissions` (`str`)
        * `start` (`str`)
    
      * `id` (`str`) - The ID of the Table within the Storage Account.
    """
    name: pulumi.Output[str]
    """
    The name of the storage table. Must be unique within the storage account the table is located.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to create the storage table.
    """
    storage_account_name: pulumi.Output[str]
    """
    Specifies the storage account in which to create the storage table.
    Changing this forces a new resource to be created.
    """
    def __init__(__self__, resource_name, opts=None, acls=None, name=None, resource_group_name=None, storage_account_name=None, __props__=None, __name__=None, __opts__=None):
        """
        Manage a Table within an Azure Storage Account.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[list] acls: One or more `acl` blocks as defined below.
        :param pulumi.Input[str] name: The name of the storage table. Must be unique within the storage account the table is located.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the storage table.
        :param pulumi.Input[str] storage_account_name: Specifies the storage account in which to create the storage table.
               Changing this forces a new resource to be created.
        
        The **acls** object supports the following:
        
          * `access_policies` (`pulumi.Input[list]`)
        
            * `expiry` (`pulumi.Input[str]`)
            * `permissions` (`pulumi.Input[str]`)
            * `start` (`pulumi.Input[str]`)
        
          * `id` (`pulumi.Input[str]`) - The ID of the Table within the Storage Account.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/storage_table.html.markdown.
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

            __props__['acls'] = acls
            __props__['name'] = name
            __props__['resource_group_name'] = resource_group_name
            if storage_account_name is None:
                raise TypeError("Missing required property 'storage_account_name'")
            __props__['storage_account_name'] = storage_account_name
        super(Table, __self__).__init__(
            'azure:storage/table:Table',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, acls=None, name=None, resource_group_name=None, storage_account_name=None):
        """
        Get an existing Table resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[list] acls: One or more `acl` blocks as defined below.
        :param pulumi.Input[str] name: The name of the storage table. Must be unique within the storage account the table is located.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the storage table.
        :param pulumi.Input[str] storage_account_name: Specifies the storage account in which to create the storage table.
               Changing this forces a new resource to be created.
        
        The **acls** object supports the following:
        
          * `access_policies` (`pulumi.Input[list]`)
        
            * `expiry` (`pulumi.Input[str]`)
            * `permissions` (`pulumi.Input[str]`)
            * `start` (`pulumi.Input[str]`)
        
          * `id` (`pulumi.Input[str]`) - The ID of the Table within the Storage Account.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/storage_table.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["acls"] = acls
        __props__["name"] = name
        __props__["resource_group_name"] = resource_group_name
        __props__["storage_account_name"] = storage_account_name
        return Table(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

