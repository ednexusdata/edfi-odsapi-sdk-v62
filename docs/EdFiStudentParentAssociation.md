# EdFi.OdsApi.Sdk.v62.Models.All.EdFiStudentParentAssociation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**ParentReference** | [**EdFiParentReference**](EdFiParentReference.md) |  | 
**StudentReference** | [**EdFiStudentReference**](EdFiStudentReference.md) |  | 
**ContactPriority** | **int?** | The numeric order of the preferred sequence or priority of contact. | [optional] 
**ContactRestrictions** | **string** | Restrictions for student and/or teacher contact with the individual (e.g., the student may not be picked up by the individual). | [optional] 
**EmergencyContactStatus** | **bool?** | Indicator of whether the person is a designated emergency contact for the student. | [optional] 
**LegalGuardian** | **bool?** | Indicator of whether the person is a legal guardian for the student. | [optional] 
**LivesWith** | **bool?** | Indicator of whether the student lives with the associated parent. | [optional] 
**PrimaryContactStatus** | **bool?** | Indicator of whether the person is a primary parental contact for the student. | [optional] 
**RelationDescriptor** | **string** | The nature of an individual&#39;s relationship to a student, primarily used to capture family relationships. | [optional] 
**Etag** | **string** | A unique system-generated value that identifies the version of the resource. | [optional] 
**Ext** | **Object** | Extensions to the StudentParentAssociation entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

