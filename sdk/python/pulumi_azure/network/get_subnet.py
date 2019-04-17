# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class GetSubnetResult:
    """
    A collection of values returned by getSubnet.
    """
    def __init__(__self__, address_prefix=None, ip_configurations=None, name=None, network_security_group_id=None, resource_group_name=None, route_table_id=None, virtual_network_name=None, id=None):
        if address_prefix and not isinstance(address_prefix, str):
            raise TypeError("Expected argument 'address_prefix' to be a str")
        __self__.address_prefix = address_prefix
        """
        The address prefix used for the subnet.
        """
        if ip_configurations and not isinstance(ip_configurations, list):
            raise TypeError("Expected argument 'ip_configurations' to be a list")
        __self__.ip_configurations = ip_configurations
        """
        The collection of IP Configurations with IPs within this subnet.
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if network_security_group_id and not isinstance(network_security_group_id, str):
            raise TypeError("Expected argument 'network_security_group_id' to be a str")
        __self__.network_security_group_id = network_security_group_id
        """
        The ID of the Network Security Group associated with the subnet.
        """
        if resource_group_name and not isinstance(resource_group_name, str):
            raise TypeError("Expected argument 'resource_group_name' to be a str")
        __self__.resource_group_name = resource_group_name
        if route_table_id and not isinstance(route_table_id, str):
            raise TypeError("Expected argument 'route_table_id' to be a str")
        __self__.route_table_id = route_table_id
        """
        The ID of the Route Table associated with this subnet.
        """
        if virtual_network_name and not isinstance(virtual_network_name, str):
            raise TypeError("Expected argument 'virtual_network_name' to be a str")
        __self__.virtual_network_name = virtual_network_name
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

async def get_subnet(name=None,resource_group_name=None,virtual_network_name=None,opts=None):
    """
    Use this data source to access information about an existing Subnet within a Virtual Network.
    """
    __args__ = dict()

    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __args__['virtualNetworkName'] = virtual_network_name
    __ret__ = await pulumi.runtime.invoke('azure:network/getSubnet:getSubnet', __args__, opts=opts)

    return GetSubnetResult(
        address_prefix=__ret__.get('addressPrefix'),
        ip_configurations=__ret__.get('ipConfigurations'),
        name=__ret__.get('name'),
        network_security_group_id=__ret__.get('networkSecurityGroupId'),
        resource_group_name=__ret__.get('resourceGroupName'),
        route_table_id=__ret__.get('routeTableId'),
        virtual_network_name=__ret__.get('virtualNetworkName'),
        id=__ret__.get('id'))
