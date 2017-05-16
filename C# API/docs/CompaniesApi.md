# IO.Swagger.Api.CompaniesApi

All URIs are relative to *https://localhost/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1CompaniesByIdDelete**](CompaniesApi.md#v1companiesbyiddelete) | **DELETE** /v1/Companies/{id} | 
[**V1CompaniesByIdGet**](CompaniesApi.md#v1companiesbyidget) | **GET** /v1/Companies/{id} | 
[**V1CompaniesByIdPut**](CompaniesApi.md#v1companiesbyidput) | **PUT** /v1/Companies/{id} | 
[**V1CompaniesGet**](CompaniesApi.md#v1companiesget) | **GET** /v1/Companies | 
[**V1CompaniesPost**](CompaniesApi.md#v1companiespost) | **POST** /v1/Companies | 


<a name="v1companiesbyiddelete"></a>
# **V1CompaniesByIdDelete**
> void V1CompaniesByIdDelete (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CompaniesByIdDeleteExample
    {
        public void main()
        {
            
            var apiInstance = new CompaniesApi();
            var id = id_example;  // Guid? | 

            try
            {
                apiInstance.V1CompaniesByIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.V1CompaniesByIdDelete: " + e.Message );
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

<a name="v1companiesbyidget"></a>
# **V1CompaniesByIdGet**
> Company V1CompaniesByIdGet (Guid? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CompaniesByIdGetExample
    {
        public void main()
        {
            
            var apiInstance = new CompaniesApi();
            var id = id_example;  // Guid? | 

            try
            {
                Company result = apiInstance.V1CompaniesByIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.V1CompaniesByIdGet: " + e.Message );
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

[**Company**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1companiesbyidput"></a>
# **V1CompaniesByIdPut**
> void V1CompaniesByIdPut (Guid? id, Company value = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CompaniesByIdPutExample
    {
        public void main()
        {
            
            var apiInstance = new CompaniesApi();
            var id = id_example;  // Guid? | 
            var value = new Company(); // Company |  (optional) 

            try
            {
                apiInstance.V1CompaniesByIdPut(id, value);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.V1CompaniesByIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **Guid?**|  | 
 **value** | [**Company**](Company.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1companiesget"></a>
# **V1CompaniesGet**
> List<Company> V1CompaniesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CompaniesGetExample
    {
        public void main()
        {
            
            var apiInstance = new CompaniesApi();

            try
            {
                List&lt;Company&gt; result = apiInstance.V1CompaniesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.V1CompaniesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Company>**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1companiespost"></a>
# **V1CompaniesPost**
> void V1CompaniesPost (Company value = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CompaniesPostExample
    {
        public void main()
        {
            
            var apiInstance = new CompaniesApi();
            var value = new Company(); // Company |  (optional) 

            try
            {
                apiInstance.V1CompaniesPost(value);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.V1CompaniesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | [**Company**](Company.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/json-patch+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

