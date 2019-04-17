# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class Service(pulumi.CustomResource):
    agent_pool_profile: pulumi.Output[dict]
    """
    A Agent Pool Profile's block as documented below.
    """
    diagnostics_profile: pulumi.Output[dict]
    """
    A VM Diagnostics Profile block as documented below.
    """
    linux_profile: pulumi.Output[dict]
    """
    A Linux Profile block as documented below.
    """
    location: pulumi.Output[str]
    """
    The location where the Container Service instance should be created. Changing this forces a new resource to be created.
    """
    master_profile: pulumi.Output[dict]
    """
    A Master Profile block as documented below.
    """
    name: pulumi.Output[str]
    """
    Unique name of the agent pool profile in the context of the subscription and resource group.
    """
    orchestration_platform: pulumi.Output[str]
    """
    Specifies the Container Orchestration Platform to use. Currently can be either `DCOS`, `Kubernetes` or `Swarm`. Changing this forces a new resource to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
    """
    service_principal: pulumi.Output[dict]
    """
    A Service Principal block as documented below.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    def __init__(__self__, resource_name, opts=None, agent_pool_profile=None, diagnostics_profile=None, linux_profile=None, location=None, master_profile=None, name=None, orchestration_platform=None, resource_group_name=None, service_principal=None, tags=None, __name__=None, __opts__=None):
        """
        Manages an Azure Container Service Instance
        
        > **NOTE:** All arguments including the client secret will be stored in the raw state as plain-text.
        [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
        
        > **DEPRECATED:** [Azure Container Service (ACS) has been deprecated by Azure in favour of Azure (Managed) Kubernetes Service (AKS)](https://azure.microsoft.com/en-us/updates/azure-container-service-will-retire-on-january-31-2020/). Support for ACS will be removed in the next major version of the AzureRM Provider (2.0) - and we **strongly recommend** you consider using Azure Kubernetes Service (AKS) for new deployments.
        
        ## Example Usage (DCOS)
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] agent_pool_profile: A Agent Pool Profile's block as documented below.
        :param pulumi.Input[dict] diagnostics_profile: A VM Diagnostics Profile block as documented below.
        :param pulumi.Input[dict] linux_profile: A Linux Profile block as documented below.
        :param pulumi.Input[str] location: The location where the Container Service instance should be created. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] master_profile: A Master Profile block as documented below.
        :param pulumi.Input[str] name: Unique name of the agent pool profile in the context of the subscription and resource group.
        :param pulumi.Input[str] orchestration_platform: Specifies the Container Orchestration Platform to use. Currently can be either `DCOS`, `Kubernetes` or `Swarm`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] service_principal: A Service Principal block as documented below.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if not resource_name:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(resource_name, str):
            raise TypeError('Expected resource name to be a string')
        if opts and not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if agent_pool_profile is None:
            raise TypeError("Missing required property 'agent_pool_profile'")
        __props__['agent_pool_profile'] = agent_pool_profile

        if diagnostics_profile is None:
            raise TypeError("Missing required property 'diagnostics_profile'")
        __props__['diagnostics_profile'] = diagnostics_profile

        if linux_profile is None:
            raise TypeError("Missing required property 'linux_profile'")
        __props__['linux_profile'] = linux_profile

        if location is None:
            raise TypeError("Missing required property 'location'")
        __props__['location'] = location

        if master_profile is None:
            raise TypeError("Missing required property 'master_profile'")
        __props__['master_profile'] = master_profile

        __props__['name'] = name

        if orchestration_platform is None:
            raise TypeError("Missing required property 'orchestration_platform'")
        __props__['orchestration_platform'] = orchestration_platform

        if resource_group_name is None:
            raise TypeError("Missing required property 'resource_group_name'")
        __props__['resource_group_name'] = resource_group_name

        __props__['service_principal'] = service_principal

        __props__['tags'] = tags

        super(Service, __self__).__init__(
            'azure:containerservice/service:Service',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

