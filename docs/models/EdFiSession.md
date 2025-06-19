# EdFi.OdsApi.Sdk.v62.Models.All.EdFiSession

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SessionName** | **string** | The identifier for the calendar for the academic session. | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**SchoolYearTypeReference** | [**EdFiSchoolYearTypeReference**](EdFiSchoolYearTypeReference.md) |  | 
**BeginDate** | **DateOnly** | Month, day, and year of the first day of the session. | 
**EndDate** | **DateOnly** | Month, day and year of the last day of the session. | 
**TermDescriptor** | **string** | An descriptor value indicating the term. | 
**TotalInstructionalDays** | **int** | The total number of instructional days in the school calendar. | 
**Id** | **string** |  | [optional] 
**AcademicWeeks** | [**List&lt;EdFiSessionAcademicWeek&gt;**](EdFiSessionAcademicWeek.md) | An unordered collection of sessionAcademicWeeks. The academic weeks associated with the school year. | [optional] 
**GradingPeriods** | [**List&lt;EdFiSessionGradingPeriod&gt;**](EdFiSessionGradingPeriod.md) | An unordered collection of sessionGradingPeriods. Grading periods associated with the session. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the Session entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

