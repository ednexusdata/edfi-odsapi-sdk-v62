# EdFi.OdsApi.Sdk.v62.Apis.All.StudentDisciplineIncidentBehaviorAssociationsApi

All URIs are relative to *https://api.ed-fi.org:443/v6.2/api/data/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteStudentDisciplineIncidentBehaviorAssociationById**](StudentDisciplineIncidentBehaviorAssociationsApi.md#deletestudentdisciplineincidentbehaviorassociationbyid) | **DELETE** /ed-fi/studentDisciplineIncidentBehaviorAssociations/{id} | Deletes an existing resource using the resource identifier. |
| [**DeletesStudentDisciplineIncidentBehaviorAssociations**](StudentDisciplineIncidentBehaviorAssociationsApi.md#deletesstudentdisciplineincidentbehaviorassociations) | **GET** /ed-fi/studentDisciplineIncidentBehaviorAssociations/deletes | Retrieves deleted resources based on change version. |
| [**GetStudentDisciplineIncidentBehaviorAssociations**](StudentDisciplineIncidentBehaviorAssociationsApi.md#getstudentdisciplineincidentbehaviorassociations) | **GET** /ed-fi/studentDisciplineIncidentBehaviorAssociations | Retrieves specific resources using the resource&#39;s property values (using the \&quot;Get\&quot; pattern). |
| [**GetStudentDisciplineIncidentBehaviorAssociationsById**](StudentDisciplineIncidentBehaviorAssociationsApi.md#getstudentdisciplineincidentbehaviorassociationsbyid) | **GET** /ed-fi/studentDisciplineIncidentBehaviorAssociations/{id} | Retrieves a specific resource using the resource&#39;s identifier (using the \&quot;Get By Id\&quot; pattern). |
| [**KeyChangesStudentDisciplineIncidentBehaviorAssociations**](StudentDisciplineIncidentBehaviorAssociationsApi.md#keychangesstudentdisciplineincidentbehaviorassociations) | **GET** /ed-fi/studentDisciplineIncidentBehaviorAssociations/keyChanges | Retrieves resources key changes based on change version. |
| [**PostStudentDisciplineIncidentBehaviorAssociation**](StudentDisciplineIncidentBehaviorAssociationsApi.md#poststudentdisciplineincidentbehaviorassociation) | **POST** /ed-fi/studentDisciplineIncidentBehaviorAssociations | Creates or updates resources based on the natural key values of the supplied resource. |
| [**PutStudentDisciplineIncidentBehaviorAssociation**](StudentDisciplineIncidentBehaviorAssociationsApi.md#putstudentdisciplineincidentbehaviorassociation) | **PUT** /ed-fi/studentDisciplineIncidentBehaviorAssociations/{id} | Updates a resource based on the resource identifier. |

<a id="deletestudentdisciplineincidentbehaviorassociationbyid"></a>
# **DeleteStudentDisciplineIncidentBehaviorAssociationById**
> void DeleteStudentDisciplineIncidentBehaviorAssociationById (string id, string? ifMatch = null)

Deletes an existing resource using the resource identifier.

The DELETE operation is used to delete an existing resource by identifier. If the resource doesn't exist, an error will result (the resource will not be found).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v62.Apis.All;
using EdFi.OdsApi.Sdk.v62.Client;
using EdFi.OdsApi.Sdk.v62.Models.All;

namespace Example
{
    public class DeleteStudentDisciplineIncidentBehaviorAssociationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v6.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentBehaviorAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. (optional) 

            try
            {
                // Deletes an existing resource using the resource identifier.
                apiInstance.DeleteStudentDisciplineIncidentBehaviorAssociationById(id, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.DeleteStudentDisciplineIncidentBehaviorAssociationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStudentDisciplineIncidentBehaviorAssociationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an existing resource using the resource identifier.
    apiInstance.DeleteStudentDisciplineIncidentBehaviorAssociationByIdWithHttpInfo(id, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.DeleteStudentDisciplineIncidentBehaviorAssociationByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **ifMatch** | **string?** | The ETag header value used to prevent the DELETE from removing a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The resource was successfully deleted. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **405** | Method Is Not Allowed. When the Snapshot-Identifier header is present the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletesstudentdisciplineincidentbehaviorassociations"></a>
# **DeletesStudentDisciplineIncidentBehaviorAssociations**
> List&lt;TrackedChangesEdFiStudentDisciplineIncidentBehaviorAssociationDelete&gt; DeletesStudentDisciplineIncidentBehaviorAssociations (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? snapshotIdentifier = null)

Retrieves deleted resources based on change version.

This operation is used to retrieve identifying information about resources that have been deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v62.Apis.All;
using EdFi.OdsApi.Sdk.v62.Client;
using EdFi.OdsApi.Sdk.v62.Models.All;

namespace Example
{
    public class DeletesStudentDisciplineIncidentBehaviorAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v6.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentBehaviorAssociationsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves deleted resources based on change version.
                List<TrackedChangesEdFiStudentDisciplineIncidentBehaviorAssociationDelete> result = apiInstance.DeletesStudentDisciplineIncidentBehaviorAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.DeletesStudentDisciplineIncidentBehaviorAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletesStudentDisciplineIncidentBehaviorAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves deleted resources based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentDisciplineIncidentBehaviorAssociationDelete>> response = apiInstance.DeletesStudentDisciplineIncidentBehaviorAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.DeletesStudentDisciplineIncidentBehaviorAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long?** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long?** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool?** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;TrackedChangesEdFiStudentDisciplineIncidentBehaviorAssociationDelete&gt;**](TrackedChangesEdFiStudentDisciplineIncidentBehaviorAssociationDelete.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **410** | Gone. An attempt to connect to the database for the snapshot specified by the Snapshot-Identifier header was unsuccessful (indicating the snapshot may have been removed). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstudentdisciplineincidentbehaviorassociations"></a>
# **GetStudentDisciplineIncidentBehaviorAssociations**
> List&lt;EdFiStudentDisciplineIncidentBehaviorAssociation&gt; GetStudentDisciplineIncidentBehaviorAssociations (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? behaviorDescriptor = null, string? incidentIdentifier = null, int? schoolId = null, string? studentUniqueId = null, string? behaviorDetailedDescription = null, string? id = null, string? snapshotIdentifier = null)

Retrieves specific resources using the resource's property values (using the \"Get\" pattern).

This GET operation provides access to resources using the \"Get\" search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v62.Apis.All;
using EdFi.OdsApi.Sdk.v62.Client;
using EdFi.OdsApi.Sdk.v62.Models.All;

namespace Example
{
    public class GetStudentDisciplineIncidentBehaviorAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v6.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentBehaviorAssociationsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var behaviorDescriptor = "behaviorDescriptor_example";  // string? | Describes behavior by category. (optional) 
            var incidentIdentifier = "incidentIdentifier_example";  // string? | A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire discipline incident even if it included multiple offenses and multiple offenders. (optional) 
            var schoolId = 56;  // int? | The identifier assigned to a school. (optional) 
            var studentUniqueId = "studentUniqueId_example";  // string? | A unique alphanumeric code assigned to a student. (optional) 
            var behaviorDetailedDescription = "behaviorDetailedDescription_example";  // string? | Specifies a more granular level of detail of a behavior involved in the incident. (optional) 
            var id = "id_example";  // string? |  (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
                List<EdFiStudentDisciplineIncidentBehaviorAssociation> result = apiInstance.GetStudentDisciplineIncidentBehaviorAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, behaviorDescriptor, incidentIdentifier, schoolId, studentUniqueId, behaviorDetailedDescription, id, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.GetStudentDisciplineIncidentBehaviorAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentDisciplineIncidentBehaviorAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves specific resources using the resource's property values (using the \"Get\" pattern).
    ApiResponse<List<EdFiStudentDisciplineIncidentBehaviorAssociation>> response = apiInstance.GetStudentDisciplineIncidentBehaviorAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, behaviorDescriptor, incidentIdentifier, schoolId, studentUniqueId, behaviorDetailedDescription, id, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.GetStudentDisciplineIncidentBehaviorAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long?** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long?** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool?** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **behaviorDescriptor** | **string?** | Describes behavior by category. | [optional]  |
| **incidentIdentifier** | **string?** | A locally assigned unique identifier (within the school or school district) to identify each specific DisciplineIncident or occurrence. The same identifier should be used to document the entire discipline incident even if it included multiple offenses and multiple offenders. | [optional]  |
| **schoolId** | **int?** | The identifier assigned to a school. | [optional]  |
| **studentUniqueId** | **string?** | A unique alphanumeric code assigned to a student. | [optional]  |
| **behaviorDetailedDescription** | **string?** | Specifies a more granular level of detail of a behavior involved in the incident. | [optional]  |
| **id** | **string?** |  | [optional]  |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;EdFiStudentDisciplineIncidentBehaviorAssociation&gt;**](EdFiStudentDisciplineIncidentBehaviorAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **410** | Gone. An attempt to connect to the database for the snapshot specified by the Snapshot-Identifier header was unsuccessful (indicating the snapshot may have been removed). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstudentdisciplineincidentbehaviorassociationsbyid"></a>
# **GetStudentDisciplineIncidentBehaviorAssociationsById**
> EdFiStudentDisciplineIncidentBehaviorAssociation GetStudentDisciplineIncidentBehaviorAssociationsById (string id, string? ifNoneMatch = null, string? snapshotIdentifier = null)

Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).

This GET operation retrieves a resource by the specified resource identifier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v62.Apis.All;
using EdFi.OdsApi.Sdk.v62.Client;
using EdFi.OdsApi.Sdk.v62.Models.All;

namespace Example
{
    public class GetStudentDisciplineIncidentBehaviorAssociationsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v6.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentBehaviorAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var ifNoneMatch = "ifNoneMatch_example";  // string? | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. (optional) 
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
                EdFiStudentDisciplineIncidentBehaviorAssociation result = apiInstance.GetStudentDisciplineIncidentBehaviorAssociationsById(id, ifNoneMatch, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.GetStudentDisciplineIncidentBehaviorAssociationsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStudentDisciplineIncidentBehaviorAssociationsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific resource using the resource's identifier (using the \"Get By Id\" pattern).
    ApiResponse<EdFiStudentDisciplineIncidentBehaviorAssociation> response = apiInstance.GetStudentDisciplineIncidentBehaviorAssociationsByIdWithHttpInfo(id, ifNoneMatch, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.GetStudentDisciplineIncidentBehaviorAssociationsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **ifNoneMatch** | **string?** | The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource. | [optional]  |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**EdFiStudentDisciplineIncidentBehaviorAssociation**](EdFiStudentDisciplineIncidentBehaviorAssociation.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **410** | Gone. An attempt to connect to the database for the snapshot specified by the Snapshot-Identifier header was unsuccessful (indicating the snapshot may have been removed). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="keychangesstudentdisciplineincidentbehaviorassociations"></a>
# **KeyChangesStudentDisciplineIncidentBehaviorAssociations**
> List&lt;TrackedChangesEdFiStudentDisciplineIncidentBehaviorAssociationKeyChange&gt; KeyChangesStudentDisciplineIncidentBehaviorAssociations (int? offset = null, int? limit = null, long? minChangeVersion = null, long? maxChangeVersion = null, bool? totalCount = null, string? snapshotIdentifier = null)

Retrieves resources key changes based on change version.

This operation is used to retrieve identifying information about resources whose key values have been changed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v62.Apis.All;
using EdFi.OdsApi.Sdk.v62.Client;
using EdFi.OdsApi.Sdk.v62.Models.All;

namespace Example
{
    public class KeyChangesStudentDisciplineIncidentBehaviorAssociationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v6.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentBehaviorAssociationsApi(config);
            var offset = 0;  // int? | Indicates how many items should be skipped before returning results. (optional)  (default to 0)
            var limit = 25;  // int? | Indicates the maximum number of items that should be returned in the results. (optional)  (default to 25)
            var minChangeVersion = 789L;  // long? | Used in synchronization to set sequence minimum ChangeVersion (optional) 
            var maxChangeVersion = 789L;  // long? | Used in synchronization to set sequence maximum ChangeVersion (optional) 
            var totalCount = false;  // bool? | Indicates if the total number of items available should be returned in the 'Total-Count' header of the response.  If set to false, 'Total-Count' header will not be provided. (optional)  (default to false)
            var snapshotIdentifier = "snapshotIdentifier_example";  // string? | Indicates the Snapshot-Identifier that should be used. (optional) 

            try
            {
                // Retrieves resources key changes based on change version.
                List<TrackedChangesEdFiStudentDisciplineIncidentBehaviorAssociationKeyChange> result = apiInstance.KeyChangesStudentDisciplineIncidentBehaviorAssociations(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.KeyChangesStudentDisciplineIncidentBehaviorAssociations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeyChangesStudentDisciplineIncidentBehaviorAssociationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves resources key changes based on change version.
    ApiResponse<List<TrackedChangesEdFiStudentDisciplineIncidentBehaviorAssociationKeyChange>> response = apiInstance.KeyChangesStudentDisciplineIncidentBehaviorAssociationsWithHttpInfo(offset, limit, minChangeVersion, maxChangeVersion, totalCount, snapshotIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.KeyChangesStudentDisciplineIncidentBehaviorAssociationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **int?** | Indicates how many items should be skipped before returning results. | [optional] [default to 0] |
| **limit** | **int?** | Indicates the maximum number of items that should be returned in the results. | [optional] [default to 25] |
| **minChangeVersion** | **long?** | Used in synchronization to set sequence minimum ChangeVersion | [optional]  |
| **maxChangeVersion** | **long?** | Used in synchronization to set sequence maximum ChangeVersion | [optional]  |
| **totalCount** | **bool?** | Indicates if the total number of items available should be returned in the &#39;Total-Count&#39; header of the response.  If set to false, &#39;Total-Count&#39; header will not be provided. | [optional] [default to false] |
| **snapshotIdentifier** | **string?** | Indicates the Snapshot-Identifier that should be used. | [optional]  |

### Return type

[**List&lt;TrackedChangesEdFiStudentDisciplineIncidentBehaviorAssociationKeyChange&gt;**](TrackedChangesEdFiStudentDisciplineIncidentBehaviorAssociationKeyChange.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested resource was successfully retrieved. |  -  |
| **304** | The resource&#39;s current server-side ETag value matched the If-None-Match header value supplied with the request indicating the resource has not been modified. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |
| **410** | Gone. An attempt to connect to the database for the snapshot specified by the Snapshot-Identifier header was unsuccessful (indicating the snapshot may have been removed). |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="poststudentdisciplineincidentbehaviorassociation"></a>
# **PostStudentDisciplineIncidentBehaviorAssociation**
> void PostStudentDisciplineIncidentBehaviorAssociation (EdFiStudentDisciplineIncidentBehaviorAssociation studentDisciplineIncidentBehaviorAssociation)

Creates or updates resources based on the natural key values of the supplied resource.

The POST operation can be used to create or update resources. In database terms, this is often referred to as an \"upsert\" operation (insert + update). Clients should NOT include the resource \"id\" in the JSON body because it will result in an error. The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately. It is recommended to use POST for both create and update except while updating natural key of a resource in which case PUT operation must be used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v62.Apis.All;
using EdFi.OdsApi.Sdk.v62.Client;
using EdFi.OdsApi.Sdk.v62.Models.All;

namespace Example
{
    public class PostStudentDisciplineIncidentBehaviorAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v6.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentBehaviorAssociationsApi(config);
            var studentDisciplineIncidentBehaviorAssociation = new EdFiStudentDisciplineIncidentBehaviorAssociation(); // EdFiStudentDisciplineIncidentBehaviorAssociation | The JSON representation of the \"studentDisciplineIncidentBehaviorAssociation\" resource to be created or updated.

            try
            {
                // Creates or updates resources based on the natural key values of the supplied resource.
                apiInstance.PostStudentDisciplineIncidentBehaviorAssociation(studentDisciplineIncidentBehaviorAssociation);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.PostStudentDisciplineIncidentBehaviorAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostStudentDisciplineIncidentBehaviorAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or updates resources based on the natural key values of the supplied resource.
    apiInstance.PostStudentDisciplineIncidentBehaviorAssociationWithHttpInfo(studentDisciplineIncidentBehaviorAssociation);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.PostStudentDisciplineIncidentBehaviorAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **studentDisciplineIncidentBehaviorAssociation** | [**EdFiStudentDisciplineIncidentBehaviorAssociation**](EdFiStudentDisciplineIncidentBehaviorAssociation.md) | The JSON representation of the \&quot;studentDisciplineIncidentBehaviorAssociation\&quot; resource to be created or updated. |  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The resource was updated.  An updated ETag value is available in the ETag header of the response. |  -  |
| **201** | The resource was created.  An ETag value is available in the ETag header, and the location of the resource is available in the Location header of the response. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **405** | Method Is Not Allowed. When the Snapshot-Identifier header is present the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putstudentdisciplineincidentbehaviorassociation"></a>
# **PutStudentDisciplineIncidentBehaviorAssociation**
> void PutStudentDisciplineIncidentBehaviorAssociation (string id, EdFiStudentDisciplineIncidentBehaviorAssociation studentDisciplineIncidentBehaviorAssociation, string? ifMatch = null)

Updates a resource based on the resource identifier.

The PUT operation is used to update a resource by identifier. If the resource identifier (\"id\") is provided in the JSON body, it will be ignored. Additionally, this API resource is not configured for cascading natural key updates. Natural key values for this resource cannot be changed using PUT operation and will not be modified in the database, and so recommendation is to use POST as that supports upsert behavior.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdFi.OdsApi.Sdk.v62.Apis.All;
using EdFi.OdsApi.Sdk.v62.Client;
using EdFi.OdsApi.Sdk.v62.Models.All;

namespace Example
{
    public class PutStudentDisciplineIncidentBehaviorAssociationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.ed-fi.org:443/v6.2/api/data/v3";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StudentDisciplineIncidentBehaviorAssociationsApi(config);
            var id = "id_example";  // string | A resource identifier that uniquely identifies the resource.
            var studentDisciplineIncidentBehaviorAssociation = new EdFiStudentDisciplineIncidentBehaviorAssociation(); // EdFiStudentDisciplineIncidentBehaviorAssociation | The JSON representation of the \"studentDisciplineIncidentBehaviorAssociation\" resource to be created or updated.
            var ifMatch = "ifMatch_example";  // string? | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. (optional) 

            try
            {
                // Updates a resource based on the resource identifier.
                apiInstance.PutStudentDisciplineIncidentBehaviorAssociation(id, studentDisciplineIncidentBehaviorAssociation, ifMatch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.PutStudentDisciplineIncidentBehaviorAssociation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutStudentDisciplineIncidentBehaviorAssociationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a resource based on the resource identifier.
    apiInstance.PutStudentDisciplineIncidentBehaviorAssociationWithHttpInfo(id, studentDisciplineIncidentBehaviorAssociation, ifMatch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StudentDisciplineIncidentBehaviorAssociationsApi.PutStudentDisciplineIncidentBehaviorAssociationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | A resource identifier that uniquely identifies the resource. |  |
| **studentDisciplineIncidentBehaviorAssociation** | [**EdFiStudentDisciplineIncidentBehaviorAssociation**](EdFiStudentDisciplineIncidentBehaviorAssociation.md) | The JSON representation of the \&quot;studentDisciplineIncidentBehaviorAssociation\&quot; resource to be created or updated. |  |
| **ifMatch** | **string?** | The ETag header value used to prevent the PUT from updating a resource modified by another consumer. | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | The resource was updated.  An updated ETag value is available in the ETag header of the response. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or their values. |  -  |
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **404** | The resource could not be found. |  -  |
| **405** | Method Is Not Allowed. When the Snapshot-Identifier header is present the method is not allowed. |  -  |
| **409** | Conflict.  The request cannot be completed because it would result in an invalid state.  See the response body for details. |  -  |
| **412** | The resource&#39;s current server-side ETag value does not match the supplied If-Match header value in the request. This indicates the resource has been modified by another consumer. |  -  |
| **500** | An unhandled error occurred on the server. See the response body for details. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

