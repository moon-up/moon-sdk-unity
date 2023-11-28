# Org.OpenAPITools.Api.YearnApi

All URIs are relative to *https://vault-api.usemoon.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddLiquidity**](YearnApi.md#addliquidity) | **POST** /yearn/{name}/add-liquidity |  |
| [**AddLiquidityWeth**](YearnApi.md#addliquidityweth) | **POST** /yearn/{name}/add-liquidity-weth |  |
| [**RemoveLiquidity**](YearnApi.md#removeliquidity) | **POST** /yearn/{name}/remove-liquidity |  |
| [**RemoveLiquidityWeth**](YearnApi.md#removeliquidityweth) | **POST** /yearn/{name}/remove-liquidity-weth |  |

<a id="addliquidity"></a>
# **AddLiquidity**
> AccountControllerResponse AddLiquidity (string authorization, string name, InputBody inputBody)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddLiquidityExample
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

            var apiInstance = new YearnApi(config);
            var authorization = "authorization_example";  // string | 
            var name = "name_example";  // string | 
            var inputBody = new InputBody(); // InputBody | 

            try
            {
                AccountControllerResponse result = apiInstance.AddLiquidity(authorization, name, inputBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling YearnApi.AddLiquidity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddLiquidityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountControllerResponse> response = apiInstance.AddLiquidityWithHttpInfo(authorization, name, inputBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling YearnApi.AddLiquidityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **name** | **string** |  |  |
| **inputBody** | [**InputBody**](InputBody.md) |  |  |

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

<a id="addliquidityweth"></a>
# **AddLiquidityWeth**
> AccountControllerResponse AddLiquidityWeth (string authorization, string name, InputBody inputBody)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddLiquidityWethExample
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

            var apiInstance = new YearnApi(config);
            var authorization = "authorization_example";  // string | 
            var name = "name_example";  // string | 
            var inputBody = new InputBody(); // InputBody | 

            try
            {
                AccountControllerResponse result = apiInstance.AddLiquidityWeth(authorization, name, inputBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling YearnApi.AddLiquidityWeth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddLiquidityWethWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountControllerResponse> response = apiInstance.AddLiquidityWethWithHttpInfo(authorization, name, inputBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling YearnApi.AddLiquidityWethWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **name** | **string** |  |  |
| **inputBody** | [**InputBody**](InputBody.md) |  |  |

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

<a id="removeliquidity"></a>
# **RemoveLiquidity**
> AccountControllerResponse RemoveLiquidity (string authorization, string name, InputBody inputBody)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RemoveLiquidityExample
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

            var apiInstance = new YearnApi(config);
            var authorization = "authorization_example";  // string | 
            var name = "name_example";  // string | 
            var inputBody = new InputBody(); // InputBody | 

            try
            {
                AccountControllerResponse result = apiInstance.RemoveLiquidity(authorization, name, inputBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling YearnApi.RemoveLiquidity: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveLiquidityWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountControllerResponse> response = apiInstance.RemoveLiquidityWithHttpInfo(authorization, name, inputBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling YearnApi.RemoveLiquidityWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **name** | **string** |  |  |
| **inputBody** | [**InputBody**](InputBody.md) |  |  |

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

<a id="removeliquidityweth"></a>
# **RemoveLiquidityWeth**
> AccountControllerResponse RemoveLiquidityWeth (string authorization, string name, InputBody inputBody)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RemoveLiquidityWethExample
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

            var apiInstance = new YearnApi(config);
            var authorization = "authorization_example";  // string | 
            var name = "name_example";  // string | 
            var inputBody = new InputBody(); // InputBody | 

            try
            {
                AccountControllerResponse result = apiInstance.RemoveLiquidityWeth(authorization, name, inputBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling YearnApi.RemoveLiquidityWeth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveLiquidityWethWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountControllerResponse> response = apiInstance.RemoveLiquidityWethWithHttpInfo(authorization, name, inputBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling YearnApi.RemoveLiquidityWethWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **name** | **string** |  |  |
| **inputBody** | [**InputBody**](InputBody.md) |  |  |

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

