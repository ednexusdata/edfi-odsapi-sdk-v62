# EdFi.OdsApi.Sdk.v62.Models.All.EdFiLearningObjective

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcademicSubjects** | [**List&lt;EdFiLearningObjectiveAcademicSubject&gt;**](EdFiLearningObjectiveAcademicSubject.md) | An unordered collection of learningObjectiveAcademicSubjects. The description of the content or subject area of an assessment. | 
**LearningObjectiveId** | **string** | The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A). | 
**Namespace** | **string** | Namespace for the learning objective. | 
**Objective** | **string** | The designated title of the learning objective. | 
**Id** | **string** |  | [optional] 
**ParentLearningObjectiveReference** | [**EdFiLearningObjectiveReference**](EdFiLearningObjectiveReference.md) |  | [optional] 
**ContentStandard** | [**EdFiLearningObjectiveContentStandard**](EdFiLearningObjectiveContentStandard.md) |  | [optional] 
**Description** | **string** | The description of the learning objective. | [optional] 
**GradeLevels** | [**List&lt;EdFiLearningObjectiveGradeLevel&gt;**](EdFiLearningObjectiveGradeLevel.md) | An unordered collection of learningObjectiveGradeLevels. The grade level for which the learning objective is targeted. The semantics of null is assumed to mean that the learning objective is not associated with any grade level. | [optional] 
**LearningStandards** | [**List&lt;EdFiLearningObjectiveLearningStandard&gt;**](EdFiLearningObjectiveLearningStandard.md) | An unordered collection of learningObjectiveLearningStandards. Learning standard(s) included in this objective. | [optional] 
**Nomenclature** | **string** | Reflects the specific nomenclature used for the learning objective. | [optional] 
**SuccessCriteria** | **string** | One or more statements that describes the criteria used by teachers and students to check for attainment of a learning objective. This criteria gives clear indications as to the degree to which learning is moving through the Zone or Proximal Development toward independent achievement of the learning objective. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the LearningObjective entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

