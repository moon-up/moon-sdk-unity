# com.usemoon.MoonSDK.Api.BitcoincashApi

All URIs are relative to *https://moon-vault-api-git-ew-supabase-migration-moonup.vercel.app*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBitcoinCashAccount**](BitcoincashApi.md#createbitcoincashaccount) | **POST** /bitcoincash |  |
| [**GetBitcoinCashAccount**](BitcoincashApi.md#getbitcoincashaccount) | **GET** /bitcoincash/{accountName} |  |
| [**ListBitcoinCashAccounts**](BitcoincashApi.md#listbitcoincashaccounts) | **GET** /bitcoincash |  |
| [**SignBitcoinCashTransaction**](BitcoincashApi.md#signbitcoincashtransaction) | **POST** /bitcoincash/{accountName}/sign-tx |  |

<a id="createbitcoincashaccount"></a>
# **CreateBitcoinCashAccount**
> AccountAPIResponse CreateBitcoinCashAccount (string authorization, BitcoinCashInput bitcoinCashInput)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class CreateBitcoinCashAccountExample
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

            var apiInstance = new BitcoincashApi(config);
            var authorization = "authorization_example";  // string | 
            var bitcoinCashInput = new BitcoinCashInput(); // BitcoinCashInput | 

            try
            {
                AccountAPIResponse result = apiInstance.CreateBitcoinCashAccount(authorization, bitcoinCashInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BitcoincashApi.CreateBitcoinCashAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBitcoinCashAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountAPIResponse> response = apiInstance.CreateBitcoinCashAccountWithHttpInfo(authorization, bitcoinCashInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BitcoincashApi.CreateBitcoinCashAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **bitcoinCashInput** | [**BitcoinCashInput**](BitcoinCashInput.md) |  |  |

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

<a id="getbitcoincashaccount"></a>
# **GetBitcoinCashAccount**
> AccountAPIResponse GetBitcoinCashAccount (string authorization, string accountName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class GetBitcoinCashAccountExample
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

            var apiInstance = new BitcoincashApi(config);
            var authorization = "authorization_example";  // string | 
            var accountName = "accountName_example";  // string | 

            try
            {
                AccountAPIResponse result = apiInstance.GetBitcoinCashAccount(authorization, accountName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BitcoincashApi.GetBitcoinCashAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBitcoinCashAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountAPIResponse> response = apiInstance.GetBitcoinCashAccountWithHttpInfo(authorization, accountName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BitcoincashApi.GetBitcoinCashAccountWithHttpInfo: " + e.Message);
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

<a id="listbitcoincashaccounts"></a>
# **ListBitcoinCashAccounts**
> AccountAPIResponse ListBitcoinCashAccounts (string authorization)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class ListBitcoinCashAccountsExample
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

            var apiInstance = new BitcoincashApi(config);
            var authorization = "authorization_example";  // string | 

            try
            {
                AccountAPIResponse result = apiInstance.ListBitcoinCashAccounts(authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BitcoincashApi.ListBitcoinCashAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListBitcoinCashAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccountAPIResponse> response = apiInstance.ListBitcoinCashAccountsWithHttpInfo(authorization);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BitcoincashApi.ListBitcoinCashAccountsWithHttpInfo: " + e.Message);
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

<a id="signbitcoincashtransaction"></a>
# **SignBitcoinCashTransaction**
> BitcoinCashAPIResponse SignBitcoinCashTransaction (string authorization, string accountName, BitcoinCashTransactionInput bitcoinCashTransactionInput)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class SignBitcoinCashTransactionExample
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

            var apiInstance = new BitcoincashApi(config);
            var authorization = "authorization_example";  // string | 
            var accountName = "accountName_example";  // string | 
            var bitcoinCashTransactionInput = new BitcoinCashTransactionInput(); // BitcoinCashTransactionInput | 

            try
            {
                BitcoinCashAPIResponse result = apiInstance.SignBitcoinCashTransaction(authorization, accountName, bitcoinCashTransactionInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BitcoincashApi.SignBitcoinCashTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignBitcoinCashTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BitcoinCashAPIResponse> response = apiInstance.SignBitcoinCashTransactionWithHttpInfo(authorization, accountName, bitcoinCashTransactionInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BitcoincashApi.SignBitcoinCashTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **accountName** | **string** |  |  |
| **bitcoinCashTransactionInput** | [**BitcoinCashTransactionInput**](BitcoinCashTransactionInput.md) |  |  |

### Return type

[**BitcoinCashAPIResponse**](BitcoinCashAPIResponse.md)

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

