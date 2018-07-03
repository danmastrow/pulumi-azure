# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetGeographicalLocationResult(object):
    """
    A collection of values returned by getGeographicalLocation.
    """
    def __init__(__self__, id=None):
        if id and not isinstance(id, basestring):
            raise TypeError('Expected argument id to be a basestring')
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

def get_geographical_location(name=None):
    """
    Use this data source to access the ID of a specified Traffic Manager Geographical Location within the Geographical Hierarchy.
    """
    __args__ = dict()

    __args__['name'] = name
    __ret__ = pulumi.runtime.invoke('azure:trafficmanager/getGeographicalLocation:getGeographicalLocation', __args__)

    return GetGeographicalLocationResult(
        id=__ret__.get('id'))