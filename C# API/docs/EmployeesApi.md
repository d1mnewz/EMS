# IO.Swagger.Api.EmployeesApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1EmployeesByIdDelete**](EmployeesApi.md#v1employeesbyiddelete) | **DELETE** /v1/Employees/{id} | 
[**V1EmployeesByIdGet**](EmployeesApi.md#v1employeesbyidget) | **GET** /v1/Employees/{id} | 
[**V1EmployeesByIdPut**](EmployeesApi.md#v1employeesbyidput) | **PUT** /v1/Employees/{id} | 
[**V1EmployeesGet**](EmployeesApi.md#v1employeesget) | **GET** /v1/Employees | 
[**V1EmployeesPost**](EmployeesApi.md#v1employeespost) | **POST** /v1/Employees | 


<a name="v1employeesbyiddelete"></a>
# **V1EmployeesByIdDelete**
> void V1EmployeesByIdDelete (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1EmployeesByIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new EmployeesApi();
            var id = id_example;  // Guid? | 

            try
            {
                apiInstance.V1EmployeesByIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1EmployeesByIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Guid?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1employeesbyidget"></a>
# **V1EmployeesByIdGet**
> Employee V1EmployeesByIdGet (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1EmployeesByIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new EmployeesApi();
            var id = id_example;  // Guid? | 

            try
            {
                Employee result = apiInstance.V1EmployeesByIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1EmployeesByIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Guid?**|  | 

### Return type

[**Employee**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1employeesbyidput"></a>
# **V1EmployeesByIdPut**
> void V1EmployeesByIdPut (Guid? id, Employee value = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1EmployeesByIdPutExample
    {
        public void main()
        {
            
            var apiInstance = new EmployeesApi();
            var id = id_example;  // Guid? | 
            var value = new Employee(); // Employee |  (optional) 

            try
            {
                apiInstance.V1EmployeesByIdPut(id, value);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1EmployeesByIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Guid?**|  | 
 **value** | [**Employee**](Employee.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1employeesget"></a>
# **V1EmployeesGet**
> List<Employee> V1EmployeesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1EmployeesGetExample
    {
        public void main()
        {
            
            var apiInstance = new EmployeesApi();

            try
            {
                List&lt;Employee&gt; result = apiInstance.V1EmployeesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1EmployeesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Employee>**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1employeespost"></a>
# **V1EmployeesPost**
> void V1EmployeesPost (Employee value = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1EmployeesPostExample
    {
        public void main()
        {
            
            var apiInstance = new EmployeesApi();
            var value = new Employee(); // Employee |  (optional) 

            try
            {
                apiInstance.V1EmployeesPost(value);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.V1EmployeesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | [**Employee**](Employee.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

