# EdFi.OdsApi.Sdk.v62.Models.All.EdFiStudentGradebookEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GradebookEntryReference** | [**EdFiGradebookEntryReference**](EdFiGradebookEntryReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**Id** | **string** |  | [optional] 
**AssignmentLateStatusDescriptor** | **string** | Status of whether the assignment was submitted after the due date and/or marked as. | [optional] 
**CompetencyLevelDescriptor** | **string** | The competency level assessed for the student for the referenced learning objective. | [optional] 
**DateFulfilled** | **DateOnly** | The date an assignment was turned in or the date of an assessment. | [optional] 
**DiagnosticStatement** | **string** | A statement provided by the teacher that provides information in addition to the grade or assessment score. | [optional] 
**LetterGradeEarned** | **string** | A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. | [optional] 
**NumericGradeEarned** | **double** | A final or interim (grading period) indicator of student performance in a class as submitted by the instructor. | [optional] 
**PointsEarned** | **double** | The points earned for the submission. With extra credit, the points earned may exceed the max points. | [optional] 
**SubmissionStatusDescriptor** | **string** | The status of the student&#39;s submission. | [optional] 
**TimeFulfilled** | **string** | The time an assignment was turned in on the date fulfilled. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StudentGradebookEntry entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

