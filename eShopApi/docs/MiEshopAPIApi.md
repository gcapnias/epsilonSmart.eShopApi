# epsilonSmart.eShopApi.Api.MiEshopAPIApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiEshopGetItemsGet**](MiEshopAPIApi.md#apieshopgetitemsget) | **GET** /api/Eshop/GetItems | 
[**ApiEshopInsertDocumentsPost**](MiEshopAPIApi.md#apieshopinsertdocumentspost) | **POST** /api/Eshop/InsertDocuments | 

<a name="apieshopgetitemsget"></a>
# **ApiEshopGetItemsGet**
> List<EshopItem> ApiEshopGetItemsGet (long? revisionNumber)



### Example
```csharp
using System;
using System.Diagnostics;
using epsilonSmart.eShopApi.Api;
using epsilonSmart.eShopApi.Client;
using epsilonSmart.eShopApi.Models;

namespace Example
{
    public class ApiEshopGetItemsGetExample
    {
        public void main()
        {

            var apiInstance = new MiEshopAPIApi();
            var revisionNumber = 789;  // long? | 

            try
            {
                List&lt;EshopItem&gt; result = apiInstance.ApiEshopGetItemsGet(revisionNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MiEshopAPIApi.ApiEshopGetItemsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **revisionNumber** | **long?**|  | 

### Return type

[**List<EshopItem>**](EshopItem.md)

### Authorization

[jwt_auth](../README.md#jwt_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apieshopinsertdocumentspost"></a>
# **ApiEshopInsertDocumentsPost**
> void ApiEshopInsertDocumentsPost (List<EshopSale> body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using epsilonSmart.eShopApi.Api;
using epsilonSmart.eShopApi.Client;
using epsilonSmart.eShopApi.Models;

namespace Example
{
    public class ApiEshopInsertDocumentsPostExample
    {
        public void main()
        {

            var apiInstance = new MiEshopAPIApi();
            var body = new List<EshopSale>(); // List<EshopSale> |  (optional) 

            try
            {
                apiInstance.ApiEshopInsertDocumentsPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MiEshopAPIApi.ApiEshopInsertDocumentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;EshopSale&gt;**](EshopSale.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[jwt_auth](../README.md#jwt_auth)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
