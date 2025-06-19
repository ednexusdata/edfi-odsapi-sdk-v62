# EdFi.OdsApi.Sdk.v62.Models.All.EdFiSection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SectionIdentifier** | **string** | The local identifier assigned to a section. | 
**CourseOfferingReference** | [**EdFiCourseOfferingReference**](EdFiCourseOfferingReference.md) |  | 
**Id** | **string** |  | [optional] 
**LocationReference** | [**EdFiLocationReference**](EdFiLocationReference.md) |  | [optional] 
**LocationSchoolReference** | [**EdFiSchoolReference**](EdFiSchoolReference.md) |  | [optional] 
**AvailableCreditConversion** | **double** | Conversion factor that when multiplied by the number of credits is equivalent to Carnegie units. | [optional] 
**AvailableCredits** | **double** | The value of credits or units of value awarded for the completion of a course. | [optional] 
**AvailableCreditTypeDescriptor** | **string** | The type of credits or units of value awarded for the completion of a course. | [optional] 
**Characteristics** | [**List&lt;EdFiSectionCharacteristic&gt;**](EdFiSectionCharacteristic.md) | An unordered collection of sectionCharacteristics. Reflects important characteristics of the section, such as whether or not attendance is taken and the section is graded. | [optional] 
**ClassPeriods** | [**List&lt;EdFiSectionClassPeriod&gt;**](EdFiSectionClassPeriod.md) | An unordered collection of sectionClassPeriods. The class period during which the section meets. | [optional] 
**CourseLevelCharacteristics** | [**List&lt;EdFiSectionCourseLevelCharacteristic&gt;**](EdFiSectionCourseLevelCharacteristic.md) | An unordered collection of sectionCourseLevelCharacteristics. The type of specific program or designation with which the section is associated. This collection should only be populated if it differs from the course level characteristics identified at the course offering level. | [optional] 
**EducationalEnvironmentDescriptor** | **string** | The setting in which a student receives education and related services. | [optional] 
**InstructionLanguageDescriptor** | **string** | The primary language of instruction. If omitted, English is assumed. | [optional] 
**MediumOfInstructionDescriptor** | **string** | The media through which teachers provide instruction to students and students and teachers communicate about instructional matters. | [optional] 
**OfferedGradeLevels** | [**List&lt;EdFiSectionOfferedGradeLevel&gt;**](EdFiSectionOfferedGradeLevel.md) | An unordered collection of sectionOfferedGradeLevels. The grade levels in which the section is offered. This collection should only be populated if it differs from the Offered Grade Levels identified at the course offering level. | [optional] 
**OfficialAttendancePeriod** | **bool** | Indicator of whether this section is used for official daily attendance. Alternatively, official daily attendance may be tied to a class period. | [optional] 
**PopulationServedDescriptor** | **string** | The type of students the section is offered and tailored to. | [optional] 
**Programs** | [**List&lt;EdFiSectionProgram&gt;**](EdFiSectionProgram.md) | An unordered collection of sectionPrograms. Optional reference to program to which the section is associated. | [optional] 
**SectionName** | **string** | A locally-defined name for the section, generally created to make the section more recognizable in informal contexts and generally distinct from the section identifier. | [optional] 
**SequenceOfCourse** | **int** | When a section is part of a sequence of parts for a course, the number of the sequence. If the course has only one part, the value of this section attribute should be 1. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the Section entity. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

