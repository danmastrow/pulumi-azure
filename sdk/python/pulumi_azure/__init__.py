# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import importlib
# Make subpackages available:
__all__ = ['analysisservices', 'apimanagement', 'appconfiguration', 'appinsights', 'appplatform', 'appservice', 'authorization', 'automation', 'backup', 'batch', 'bot', 'cdn', 'cognitive', 'compute', 'config', 'containerservice', 'core', 'cosmosdb', 'costmanagement', 'dashboard', 'databasemigration', 'databricks', 'datafactory', 'datalake', 'devspace', 'devtest', 'dns', 'eventgrid', 'eventhub', 'frontdoor', 'hdinsight', 'healthcare', 'hpc', 'iot', 'iotcentral', 'keyvault', 'kusto', 'lb', 'loganalytics', 'logicapps', 'machinelearning', 'managedapplication', 'management', 'managementgroups', 'managementresource', 'maps', 'mariadb', 'marketplace', 'mediaservices', 'mixedreality', 'monitoring', 'msi', 'mssql', 'mysql', 'netapp', 'network', 'notificationhub', 'operationalinsights', 'policy', 'postgresql', 'powerbi', 'privatedns', 'privatelink', 'proximity', 'recoveryservices', 'redis', 'relay', 'role', 'search', 'securitycenter', 'servicebus', 'servicefabric', 'signalr', 'siterecovery', 'sql', 'storage', 'streamanalytics', 'trafficmanager', 'waf']
for pkg in __all__:
    if pkg != 'config':
        importlib.import_module(f'{__name__}.{pkg}')

# Export this package's modules as members:
from .provider import *
