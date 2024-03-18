# com.usemoon.MoonSDK.Api.Erc4337Api

All URIs are relative to *https://moon-vault-api-git-ew-supabase-migration-moonup.vercel.app*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAddress**](Erc4337Api.md#getaddress) | **POST** /erc4337/{accountName}/address |  |
| [**SignBroadcastUserOpTx**](Erc4337Api.md#signbroadcastuseroptx) | **POST** /erc4337/{accountName}/sign-broadcast-userop-tx |  |

<a id="getaddress"></a>
# **GetAddress**
> AccountAPIResponse GetAddress (string authorization, string accountName, InputBody inputBody)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class GetAddressExample
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

            var apiInstance = new Erc4337Api(config);
            var authorization = "authorization_example";  // string | 
            var accountName = "accountName_example";  // string | 
            var inputBody = new InputBody(); // InputBody | 

            try
            {
                AccountAPIResponse result = apiInstance.GetAddress(authorization, accountName, inputBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Erc4337Api.GetAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountAPIResponse> response = apiInstance.GetAddressWithHttpInfo(authorization, accountName, inputBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Erc4337Api.GetAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **accountName** | **string** |  |  |
| **inputBody** | [**InputBody**](InputBody.md) |  |  |

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

<a id="signbroadcastuseroptx"></a>
# **SignBroadcastUserOpTx**
> TransactionAPIResponse SignBroadcastUserOpTx (string authorization, string accountName, InputBody inputBody)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class SignBroadcastUserOpTxExample
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

            var apiInstance = new Erc4337Api(config);
            var authorization = "authorization_example";  // string | 
            var accountName = "accountName_example";  // string | 
            var inputBody = new InputBody(); // InputBody | 

            try
            {
                TransactionAPIResponse result = apiInstance.SignBroadcastUserOpTx(authorization, accountName, inputBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling Erc4337Api.SignBroadcastUserOpTx: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignBroadcastUserOpTxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TransactionAPIResponse> response = apiInstance.SignBroadcastUserOpTxWithHttpInfo(authorization, accountName, inputBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling Erc4337Api.SignBroadcastUserOpTxWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **accountName** | **string** |  |  |
| **inputBody** | [**InputBody**](InputBody.md) |  |  |

### Return type

[**TransactionAPIResponse**](TransactionAPIResponse.md)

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

