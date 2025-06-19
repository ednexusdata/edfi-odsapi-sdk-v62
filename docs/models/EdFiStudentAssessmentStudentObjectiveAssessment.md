# EdFi.OdsApi.Sdk.v62.Models.All.EdFiStudentAssessmentStudentObjectiveAssessment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectiveAssessmentReference** | [**EdFiObjectiveAssessmentReference**](EdFiObjectiveAssessmentReference.md) |  | 
**AdministrationDate** | **DateTime** | The date and time an assessment was completed by the student. The use of ISO-8601 formats with a timezone designator (UTC or time offset) is recommended in order to prevent ambiguity due to time zones. | [optional] 
**AdministrationEndDate** | **DateTime** | The date and time an assessment administration ended. | [optional] 
**AssessedMinutes** | **int** | Reported time student was assessed in minutes. | [optional] 
**PerformanceLevels** | [**List&lt;EdFiStudentAssessmentStudentObjectiveAssessmentPerformanceLevel&gt;**](EdFiStudentAssessmentStudentObjectiveAssessmentPerformanceLevel.md) | An unordered collection of studentAssessmentStudentObjectiveAssessmentPerformanceLevels. The performance level(s) achieved for the objective assessment. | [optional] 
**ScoreResults** | [**List&lt;EdFiStudentAssessmentStudentObjectiveAssessmentScoreResult&gt;**](EdFiStudentAssessmentStudentObjectiveAssessmentScoreResult.md) | An unordered collection of studentAssessmentStudentObjectiveAssessmentScoreResults. A meaningful score or statistical expression of the performance of an individual. The results can be expressed as a number, percentile, range, level, etc. | [optional] 
**Ext** | **Object** | Extensions to the StudentAssessmentStudentObjectiveAssessment entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

