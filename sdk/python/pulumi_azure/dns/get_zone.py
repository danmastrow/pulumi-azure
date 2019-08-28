# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetZoneResult:
    """
    A collection of values returned by getZone.
    """
    def __init__(__self__, max_number_of_record_sets=None, name=None, name_servers=None, number_of_record_sets=None, registration_virtual_network_ids=None, resolution_virtual_network_ids=None, resource_group_name=None, tags=None, zone_type=None, id=None):
        if max_number_of_record_sets and not isinstance(max_number_of_record_sets, float):
            raise TypeError("Expected argument 'max_number_of_record_sets' to be a float")
        __self__.max_number_of_record_sets = max_number_of_record_sets
        """
        Maximum number of Records in the zone.
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if name_servers and not isinstance(name_servers, list):
            raise TypeError("Expected argument 'name_servers' to be a list")
        __self__.name_servers = name_servers
        """
        A list of values that make up the NS record for the zone.
        """
        if number_of_record_sets and not isinstance(number_of_record_sets, float):
            raise TypeError("Expected argument 'number_of_record_sets' to be a float")
        __self__.number_of_record_sets = number_of_record_sets
        """
        The number of records already in the zone.
        """
        if registration_virtual_network_ids and not isinstance(registration_virtual_network_ids, list):
            raise TypeError("Expected argument 'registration_virtual_network_ids' to be a list")
        __self__.registration_virtual_network_ids = registration_virtual_network_ids
        """
        A list of Virtual Network ID's that register hostnames in this DNS zone.
        """
        if resolution_virtual_network_ids and not isinstance(resolution_virtual_network_ids, list):
            raise TypeError("Expected argument 'resolution_virtual_network_ids' to be a list")
        __self__.resolution_virtual_network_ids = resolution_virtual_network_ids
        """
        A list of Virtual Network ID's that resolve records in this DNS zone.
        """
        if resource_group_name and not isinstance(resource_group_name, str):
            raise TypeError("Expected argument 'resource_group_name' to be a str")
        __self__.resource_group_name = resource_group_name
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        __self__.tags = tags
        """
        A mapping of tags to assign to the EventHub Namespace.
        """
        if zone_type and not isinstance(zone_type, str):
            raise TypeError("Expected argument 'zone_type' to be a str")
        __self__.zone_type = zone_type
        """
        (**Deprecated**) The type of this DNS zone, such as `Public` or `Private`.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """
class AwaitableGetZoneResult(GetZoneResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetZoneResult(
            max_number_of_record_sets=self.max_number_of_record_sets,
            name=self.name,
            name_servers=self.name_servers,
            number_of_record_sets=self.number_of_record_sets,
            registration_virtual_network_ids=self.registration_virtual_network_ids,
            resolution_virtual_network_ids=self.resolution_virtual_network_ids,
            resource_group_name=self.resource_group_name,
            tags=self.tags,
            zone_type=self.zone_type,
            id=self.id)

def get_zone(name=None,resource_group_name=None,opts=None):
    """
    Use this data source to access information about an existing DNS Zone.
    
    :param str name: The name of the DNS Zone.
    :param str resource_group_name: The Name of the Resource Group where the DNS Zone exists.
           If the Name of the Resource Group is not provided, the first DNS Zone from the list of DNS Zones
           in your subscription that matches `name` will be returned.

    > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/dns_zone.html.markdown.
    """
    __args__ = dict()

    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:dns/getZone:getZone', __args__, opts=opts).value

    return AwaitableGetZoneResult(
        max_number_of_record_sets=__ret__.get('maxNumberOfRecordSets'),
        name=__ret__.get('name'),
        name_servers=__ret__.get('nameServers'),
        number_of_record_sets=__ret__.get('numberOfRecordSets'),
        registration_virtual_network_ids=__ret__.get('registrationVirtualNetworkIds'),
        resolution_virtual_network_ids=__ret__.get('resolutionVirtualNetworkIds'),
        resource_group_name=__ret__.get('resourceGroupName'),
        tags=__ret__.get('tags'),
        zone_type=__ret__.get('zoneType'),
        id=__ret__.get('id'))
