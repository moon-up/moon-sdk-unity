# com.usemoon.MoonSDK.Api.RippleApi

All URIs are relative to *https://moon-vault-api-git-ew-supabase-migration-moonup.vercel.app*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateRippleAccount**](RippleApi.md#createrippleaccount) | **POST** /ripple |  |
| [**GetRippleAccount**](RippleApi.md#getrippleaccount) | **GET** /ripple/{accountName} |  |
| [**ListRippleAccounts**](RippleApi.md#listrippleaccounts) | **GET** /ripple |  |
| [**SignRippleTransaction**](RippleApi.md#signrippletransaction) | **POST** /ripple/{accountName}/sign-tx |  |

<a id="createrippleaccount"></a>
# **CreateRippleAccount**
> AccountAPIResponse CreateRippleAccount (string authorization, RippleInput rippleInput)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class CreateRippleAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://moon-vault-api-git-ew-supabase-migration-moonup.vercel.app";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RippleApi(config);
            var authorization = "authorization_example";  // string | 
            var rippleInput = new RippleInput(); // RippleInput | 

            try
            {
                AccountAPIResponse result = apiInstance.CreateRippleAccount(authorization, rippleInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RippleApi.CreateRippleAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRippleAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountAPIResponse> response = apiInstance.CreateRippleAccountWithHttpInfo(authorization, rippleInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RippleApi.CreateRippleAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **rippleInput** | [**RippleInput**](RippleInput.md) |  |  |

### Return type

[**AccountAPIResponse**](AccountAPIResponse.md)

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

<a id="getrippleaccount"></a>
# **GetRippleAccount**
> AccountAPIResponse GetRippleAccount (string authorization, string accountName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class GetRippleAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://moon-vault-api-git-ew-supabase-migration-moonup.vercel.app";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RippleApi(config);
            var authorization = "authorization_example";  // string | 
            var accountName = "accountName_example";  // string | 

            try
            {
                AccountAPIResponse result = apiInstance.GetRippleAccount(authorization, accountName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RippleApi.GetRippleAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRippleAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountAPIResponse> response = apiInstance.GetRippleAccountWithHttpInfo(authorization, accountName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RippleApi.GetRippleAccountWithHttpInfo: " + e.Message);
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

[**AccountAPIResponse**](AccountAPIResponse.md)

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

<a id="listrippleaccounts"></a>
# **ListRippleAccounts**
> AccountAPIResponse ListRippleAccounts (string authorization)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class ListRippleAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://moon-vault-api-git-ew-supabase-migration-moonup.vercel.app";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RippleApi(config);
            var authorization = "authorization_example";  // string | 

            try
            {
                AccountAPIResponse result = apiInstance.ListRippleAccounts(authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RippleApi.ListRippleAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRippleAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountAPIResponse> response = apiInstance.ListRippleAccountsWithHttpInfo(authorization);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RippleApi.ListRippleAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |

### Return type

[**AccountAPIResponse**](AccountAPIResponse.md)

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

<a id="signrippletransaction"></a>
# **SignRippleTransaction**
> RippleAPIResponse SignRippleTransaction (string authorization, string accountName, RippleTransactionInput rippleTransactionInput)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class SignRippleTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://moon-vault-api-git-ew-supabase-migration-moonup.vercel.app";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RippleApi(config);
            var authorization = "authorization_example";  // string | 
            var accountName = "accountName_example";  // string | 
            var rippleTransactionInput = new RippleTransactionInput(); // RippleTransactionInput | 

            try
            {
                RippleAPIResponse result = apiInstance.SignRippleTransaction(authorization, accountName, rippleTransactionInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RippleApi.SignRippleTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignRippleTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RippleAPIResponse> response = apiInstance.SignRippleTransactionWithHttpInfo(authorization, accountName, rippleTransactionInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RippleApi.SignRippleTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **accountName** | **string** |  |  |
| **rippleTransactionInput** | [**RippleTransactionInput**](RippleTransactionInput.md) |  |  |

### Return type

[**RippleAPIResponse**](RippleAPIResponse.md)

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

