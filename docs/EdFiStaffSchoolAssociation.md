# EdFi.OdsApi.Sdk.v62.Models.All.EdFiStaffSchoolAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**ProgramAssignmentDescriptor** | **string** | The name of the program for which the individual is assigned. | 
**CalendarReference** | [**EdFiCalendarReference**](EdFiCalendarReference.md) |  | [optional] 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**SchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | [optional] 
**StaffReference** | [**EdFiStaffReference**](EdFiStaffReference.md) |  | 
**AcademicSubjects** | [**List&lt;EdFiStaffSchoolAssociationAcademicSubject&gt;**](EdFiStaffSchoolAssociationAcademicSubject.md) | An unordered collection of staffSchoolAssociationAcademicSubjects. The academic subjects the individual is eligible to teach. | [optional] 
**GradeLevels** | [**List&lt;EdFiStaffSchoolAssociationGradeLevel&gt;**](EdFiStaffSchoolAssociationGradeLevel.md) | An unordered collection of staffSchoolAssociationGradeLevels. The grade levels the individual is eligible to teach. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StaffSchoolAssociation entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

