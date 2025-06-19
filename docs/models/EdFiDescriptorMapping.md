# EdFi.OdsApi.Sdk.v62.Models.All.EdFiDescriptorMapping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MappedNamespace** | **string** | The namespace of the descriptor value to which the from descriptor value is mapped to. | 
**MappedValue** | **string** | The descriptor value to which the from descriptor value is being mapped to. | 
**Namespace** | **string** | The namespace of the descriptor value that is being mapped to another value. | 
**Value** | **string** | The descriptor value that is being mapped to another value. | 
**Id** | **string** |  | [optional] 
**ModelEntities** | [**List&lt;EdFiDescriptorMappingModelEntity&gt;**](EdFiDescriptorMappingModelEntity.md) | An unordered collection of descriptorMappingModelEntities. The resources for which the descriptor mapping applies. If empty, the mapping is assumed to be applicable to all resources in which the descriptor appears. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the DescriptorMapping entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

