# EdFi.OdsApi.Sdk.v62.Models.All.EdFiGradebookEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GradebookEntryIdentifier** | **string** | A unique number or alphanumeric code assigned to a gradebook entry by the source system. | 
**Namespace** | **string** | Namespace URI for the source of the gradebook entry. | 
**DateAssigned** | **DateOnly** | The date the assignment, homework, or assessment was assigned or executed. | 
**SourceSectionIdentifier** | **string** | The local identifier assigned to a section. | 
**Title** | **string** | The name or title of the activity to be recorded in the gradebook entry. | 
**Id** | **string** |  | [optional] 
**GradingPeriodReference** | [**EdFiGradingPeriodReference**](EdFiGradingPeriodReference.md) |  | [optional] 
**SectionReference** | [**EdFiSectionReference**](EdFiSectionReference.md) |  | [optional] 
**Description** | **string** | A description of the assignment, homework, or classroom assessment. | [optional] 
**DueDate** | **DateOnly** | The date the assignment, homework, or assessment is due. | [optional] 
**DueTime** | **string** | The time the assignment, homework, or assessment is due. | [optional] 
**GradebookEntryTypeDescriptor** | **string** | The type of the gradebook entry. | [optional] 
**LearningStandards** | [**List&lt;EdFiGradebookEntryLearningStandard&gt;**](EdFiGradebookEntryLearningStandard.md) | An unordered collection of gradebookEntryLearningStandards. LearningStandard(s) associated with the gradebook entry. | [optional] 
**MaxPoints** | **double** | The maximum number of points  that can be earned for the submission. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the GradebookEntry entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

