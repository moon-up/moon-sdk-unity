# Org.OpenAPITools.Api.CosmosApi

All URIs are relative to *https://vault-api.usemoon.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCosmosAccount**](CosmosApi.md#createcosmosaccount) | **POST** /cosmos |  |
| [**GetCosmosAccount**](CosmosApi.md#getcosmosaccount) | **GET** /cosmos/{accountName} |  |
| [**ListCosmosAccounts**](CosmosApi.md#listcosmosaccounts) | **GET** /cosmos |  |
| [**SignCosmosTransaction**](CosmosApi.md#signcosmostransaction) | **POST** /cosmos/{accountName}/sign-tx |  |

<a id="createcosmosaccount"></a>
# **CreateCosmosAccount**
> AccountControllerResponse CreateCosmosAccount (string authorization, CosmosInput cosmosInput)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCosmosAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vault-api.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CosmosApi(config);
            var authorization = "authorization_example";  // string | 
            var cosmosInput = new CosmosInput(); // CosmosInput | 

            try
            {
                AccountControllerResponse result = apiInstance.CreateCosmosAccount(authorization, cosmosInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CosmosApi.CreateCosmosAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCosmosAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountControllerResponse> response = apiInstance.CreateCosmosAccountWithHttpInfo(authorization, cosmosInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CosmosApi.CreateCosmosAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **cosmosInput** | [**CosmosInput**](CosmosInput.md) |  |  |

### Return type

[**AccountControllerResponse**](AccountControllerResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcosmosaccount"></a>
# **GetCosmosAccount**
> AccountControllerResponse GetCosmosAccount (string authorization, string accountName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetCosmosAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vault-api.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CosmosApi(config);
            var authorization = "authorization_example";  // string | 
            var accountName = "accountName_example";  // string | 

            try
            {
                AccountControllerResponse result = apiInstance.GetCosmosAccount(authorization, accountName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CosmosApi.GetCosmosAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCosmosAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountControllerResponse> response = apiInstance.GetCosmosAccountWithHttpInfo(authorization, accountName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CosmosApi.GetCosmosAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **accountName** | **string** |  |  |

### Return type

[**AccountControllerResponse**](AccountControllerResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcosmosaccounts"></a>
# **ListCosmosAccounts**
> AccountControllerResponse ListCosmosAccounts (string authorization)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCosmosAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vault-api.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CosmosApi(config);
            var authorization = "authorization_example";  // string | 

            try
            {
                AccountControllerResponse result = apiInstance.ListCosmosAccounts(authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CosmosApi.ListCosmosAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCosmosAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountControllerResponse> response = apiInstance.ListCosmosAccountsWithHttpInfo(authorization);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CosmosApi.ListCosmosAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |

### Return type

[**AccountControllerResponse**](AccountControllerResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="signcosmostransaction"></a>
# **SignCosmosTransaction**
> AccountControllerResponse SignCosmosTransaction (string authorization, string accountName, CosmosTransactionInput cosmosTransactionInput)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SignCosmosTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://vault-api.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CosmosApi(config);
            var authorization = "authorization_example";  // string | 
            var accountName = "accountName_example";  // string | 
            var cosmosTransactionInput = new CosmosTransactionInput(); // CosmosTransactionInput | 

            try
            {
                AccountControllerResponse result = apiInstance.SignCosmosTransaction(authorization, accountName, cosmosTransactionInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CosmosApi.SignCosmosTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignCosmosTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountControllerResponse> response = apiInstance.SignCosmosTransactionWithHttpInfo(authorization, accountName, cosmosTransactionInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CosmosApi.SignCosmosTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **accountName** | **string** |  |  |
| **cosmosTransactionInput** | [**CosmosTransactionInput**](CosmosTransactionInput.md) |  |  |

### Return type

[**AccountControllerResponse**](AccountControllerResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth), [BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

