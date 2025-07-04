# EdFi.OdsApi.Sdk.v62.Models.All.EdFiAssessmentContentStandard

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PublicationStatusDescriptor** | **string** | The publication status of the document (i.e., Adopted, Draft, Published, Deprecated, Unknown). | [optional] 
**BeginDate** | **DateOnly?** | The beginning of the period during which this learning standard document is intended for use. | [optional] 
**EndDate** | **DateOnly?** | The end of the period during which this learning standard document is intended for use. | [optional] 
**PublicationDate** | **DateOnly?** | The date on which this content was first published. | [optional] 
**PublicationYear** | **int?** | The year at which this content was first published. | [optional] 
**Title** | **string** | The name of the content standard, for example Common Core. | 
**Uri** | **string** | An unambiguous reference to the standards using a network-resolvable URI. | [optional] 
**VarVersion** | **string** | The version identifier for the content. | [optional] 
**MandatingEducationOrganizationReference** | [**EdFiEducationOrganizationReference**](EdFiEducationOrganizationReference.md) |  | [optional] 
**Authors** | [**List&lt;EdFiAssessmentContentStandardAuthor&gt;**](EdFiAssessmentContentStandardAuthor.md) | An unordered collection of assessmentContentStandardAuthors. The person or organization chiefly responsible for the intellectual content of the standard. | [optional] 
**Ext** | **Object** | Extensions to the AssessmentContentStandard entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

