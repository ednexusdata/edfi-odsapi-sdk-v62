# EdFi.OdsApi.Sdk.v62.Models.All.EdFiBellSchedule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BellScheduleName** | **string** | Name or title of the bell schedule. | 
**ClassPeriods** | [**List&lt;EdFiBellScheduleClassPeriod&gt;**](EdFiBellScheduleClassPeriod.md) | An unordered collection of bellScheduleClassPeriods. The class periods that compose this bell schedule. | 
**SchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | 
**Id** | **string** |  | [optional] 
**AlternateDayName** | **string** | An alternate name for the day (e.g., Red, Blue). | [optional] 
**Dates** | [**List&lt;EdFiBellScheduleDate&gt;**](EdFiBellScheduleDate.md) | An unordered collection of bellScheduleDates. The dates for which the bell schedule applies. | [optional] 
**EndTime** | **string** | An indication of the time of day the bell schedule ends. | [optional] 
**GradeLevels** | [**List&lt;EdFiBellScheduleGradeLevel&gt;**](EdFiBellScheduleGradeLevel.md) | An unordered collection of bellScheduleGradeLevels. The grade levels the particular bell schedule applies to. | [optional] 
**StartTime** | **string** | An indication of the time of day the bell schedule begins. | [optional] 
**TotalInstructionalTime** | **int** | The total instructional time in minutes per day for the bell schedule. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the BellSchedule entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

