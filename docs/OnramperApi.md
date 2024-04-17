# com.usemoon.MoonSDK.Api.OnramperApi

All URIs are relative to *https://beta.usemoon.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OnRamperCheckout**](OnramperApi.md#onrampercheckout) | **POST** /onramper/fund/${accountName} |  |
| [**OnRamperGetQuotesBuy**](OnramperApi.md#onrampergetquotesbuy) | **GET** /onramper/quotes/buy |  |
| [**OnRamperGetQuotesSell**](OnramperApi.md#onrampergetquotessell) | **GET** /onramper/quotes/sell |  |
| [**OnRamperGetSupportedAssets**](OnramperApi.md#onrampergetsupportedassets) | **GET** /onramper/assets |  |
| [**OnRamperGetSupportedCurrencies**](OnramperApi.md#onrampergetsupportedcurrencies) | **GET** /onramper/currencies |  |
| [**OnRamperGetSupportedDefaultsAll**](OnramperApi.md#onrampergetsupporteddefaultsall) | **GET** /onramper/defaults |  |
| [**OnRamperGetSupportedOnRampsAll**](OnramperApi.md#onrampergetsupportedonrampsall) | **GET** /onramper/onramps |  |
| [**OnRamperGetSupportedPaymentTypes**](OnramperApi.md#onrampergetsupportedpaymenttypes) | **GET** /onramper/payment-types |  |
| [**OnRamperGetSupportedPaymentTypesFiat**](OnramperApi.md#onrampergetsupportedpaymenttypesfiat) | **GET** /onramper/payment-types/fiat |  |

<a id="onrampercheckout"></a>
# **OnRamperCheckout**
> Object OnRamperCheckout (string authorization, string accountName, TransactionInput transactionInput)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class OnRamperCheckoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://beta.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OnramperApi(config);
            var authorization = "authorization_example";  // string | 
            var accountName = "accountName_example";  // string | 
            var transactionInput = new TransactionInput(); // TransactionInput | 

            try
            {
                Object result = apiInstance.OnRamperCheckout(authorization, accountName, transactionInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnramperApi.OnRamperCheckout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnRamperCheckoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.OnRamperCheckoutWithHttpInfo(authorization, accountName, transactionInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnramperApi.OnRamperCheckoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **accountName** | **string** |  |  |
| **transactionInput** | [**TransactionInput**](TransactionInput.md) |  |  |

### Return type

**Object**

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

<a id="onrampergetquotesbuy"></a>
# **OnRamperGetQuotesBuy**
> List&lt;Quote&gt; OnRamperGetQuotesBuy (string authorization, string fiat, string crypto, double amount, string? paymentMethod = null, string? uuid = null, string? clientName = null, string? country = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class OnRamperGetQuotesBuyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://beta.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OnramperApi(config);
            var authorization = "authorization_example";  // string | 
            var fiat = "fiat_example";  // string | 
            var crypto = "crypto_example";  // string | 
            var amount = 1.2D;  // double | 
            var paymentMethod = "\"creditcard\"";  // string? |  (optional)  (default to "creditcard")
            var uuid = "\"\"";  // string? |  (optional)  (default to "")
            var clientName = "\"\"";  // string? |  (optional)  (default to "")
            var country = "\"\"";  // string? |  (optional)  (default to "")

            try
            {
                List<Quote> result = apiInstance.OnRamperGetQuotesBuy(authorization, fiat, crypto, amount, paymentMethod, uuid, clientName, country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnramperApi.OnRamperGetQuotesBuy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnRamperGetQuotesBuyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Quote>> response = apiInstance.OnRamperGetQuotesBuyWithHttpInfo(authorization, fiat, crypto, amount, paymentMethod, uuid, clientName, country);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnramperApi.OnRamperGetQuotesBuyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **fiat** | **string** |  |  |
| **crypto** | **string** |  |  |
| **amount** | **double** |  |  |
| **paymentMethod** | **string?** |  | [optional] [default to &quot;creditcard&quot;] |
| **uuid** | **string?** |  | [optional] [default to &quot;&quot;] |
| **clientName** | **string?** |  | [optional] [default to &quot;&quot;] |
| **country** | **string?** |  | [optional] [default to &quot;&quot;] |

### Return type

[**List&lt;Quote&gt;**](Quote.md)

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

<a id="onrampergetquotessell"></a>
# **OnRamperGetQuotesSell**
> List&lt;SellQuote&gt; OnRamperGetQuotesSell (string authorization, string fiat, string crypto, double amount, string? paymentMethod = null, string? uuid = null, string? clientName = null, string? country = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class OnRamperGetQuotesSellExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://beta.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OnramperApi(config);
            var authorization = "authorization_example";  // string | 
            var fiat = "fiat_example";  // string | 
            var crypto = "crypto_example";  // string | 
            var amount = 1.2D;  // double | 
            var paymentMethod = "\"creditcard\"";  // string? |  (optional)  (default to "creditcard")
            var uuid = "\"\"";  // string? |  (optional)  (default to "")
            var clientName = "\"\"";  // string? |  (optional)  (default to "")
            var country = "\"\"";  // string? |  (optional)  (default to "")

            try
            {
                List<SellQuote> result = apiInstance.OnRamperGetQuotesSell(authorization, fiat, crypto, amount, paymentMethod, uuid, clientName, country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnramperApi.OnRamperGetQuotesSell: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnRamperGetQuotesSellWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<SellQuote>> response = apiInstance.OnRamperGetQuotesSellWithHttpInfo(authorization, fiat, crypto, amount, paymentMethod, uuid, clientName, country);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnramperApi.OnRamperGetQuotesSellWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **fiat** | **string** |  |  |
| **crypto** | **string** |  |  |
| **amount** | **double** |  |  |
| **paymentMethod** | **string?** |  | [optional] [default to &quot;creditcard&quot;] |
| **uuid** | **string?** |  | [optional] [default to &quot;&quot;] |
| **clientName** | **string?** |  | [optional] [default to &quot;&quot;] |
| **country** | **string?** |  | [optional] [default to &quot;&quot;] |

### Return type

[**List&lt;SellQuote&gt;**](SellQuote.md)

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

<a id="onrampergetsupportedassets"></a>
# **OnRamperGetSupportedAssets**
> SupportedAssetResponse OnRamperGetSupportedAssets (string authorization, string source, string country)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class OnRamperGetSupportedAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://beta.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OnramperApi(config);
            var authorization = "authorization_example";  // string | 
            var source = "source_example";  // string | 
            var country = "country_example";  // string | 

            try
            {
                SupportedAssetResponse result = apiInstance.OnRamperGetSupportedAssets(authorization, source, country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnramperApi.OnRamperGetSupportedAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnRamperGetSupportedAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SupportedAssetResponse> response = apiInstance.OnRamperGetSupportedAssetsWithHttpInfo(authorization, source, country);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnramperApi.OnRamperGetSupportedAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **source** | **string** |  |  |
| **country** | **string** |  |  |

### Return type

[**SupportedAssetResponse**](SupportedAssetResponse.md)

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

<a id="onrampergetsupportedcurrencies"></a>
# **OnRamperGetSupportedCurrencies**
> SupportedCurrenciesResponse OnRamperGetSupportedCurrencies (string authorization, string type)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class OnRamperGetSupportedCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://beta.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OnramperApi(config);
            var authorization = "authorization_example";  // string | 
            var type = "type_example";  // string | 

            try
            {
                SupportedCurrenciesResponse result = apiInstance.OnRamperGetSupportedCurrencies(authorization, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnramperApi.OnRamperGetSupportedCurrencies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnRamperGetSupportedCurrenciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SupportedCurrenciesResponse> response = apiInstance.OnRamperGetSupportedCurrenciesWithHttpInfo(authorization, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnramperApi.OnRamperGetSupportedCurrenciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **type** | **string** |  |  |

### Return type

[**SupportedCurrenciesResponse**](SupportedCurrenciesResponse.md)

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

<a id="onrampergetsupporteddefaultsall"></a>
# **OnRamperGetSupportedDefaultsAll**
> SupportedDefaultResponse OnRamperGetSupportedDefaultsAll (string authorization, string country, string type)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class OnRamperGetSupportedDefaultsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://beta.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OnramperApi(config);
            var authorization = "authorization_example";  // string | 
            var country = "country_example";  // string | 
            var type = "type_example";  // string | 

            try
            {
                SupportedDefaultResponse result = apiInstance.OnRamperGetSupportedDefaultsAll(authorization, country, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnramperApi.OnRamperGetSupportedDefaultsAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnRamperGetSupportedDefaultsAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SupportedDefaultResponse> response = apiInstance.OnRamperGetSupportedDefaultsAllWithHttpInfo(authorization, country, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnramperApi.OnRamperGetSupportedDefaultsAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **country** | **string** |  |  |
| **type** | **string** |  |  |

### Return type

[**SupportedDefaultResponse**](SupportedDefaultResponse.md)

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

<a id="onrampergetsupportedonrampsall"></a>
# **OnRamperGetSupportedOnRampsAll**
> GetSupportedOnRampsResponse OnRamperGetSupportedOnRampsAll (string authorization)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class OnRamperGetSupportedOnRampsAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://beta.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OnramperApi(config);
            var authorization = "authorization_example";  // string | 

            try
            {
                GetSupportedOnRampsResponse result = apiInstance.OnRamperGetSupportedOnRampsAll(authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnramperApi.OnRamperGetSupportedOnRampsAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnRamperGetSupportedOnRampsAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GetSupportedOnRampsResponse> response = apiInstance.OnRamperGetSupportedOnRampsAllWithHttpInfo(authorization);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnramperApi.OnRamperGetSupportedOnRampsAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |

### Return type

[**GetSupportedOnRampsResponse**](GetSupportedOnRampsResponse.md)

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

<a id="onrampergetsupportedpaymenttypes"></a>
# **OnRamperGetSupportedPaymentTypes**
> SupportedPaymentTypesCurrencyResponse OnRamperGetSupportedPaymentTypes (string authorization, string fiat, string country, string type)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class OnRamperGetSupportedPaymentTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://beta.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OnramperApi(config);
            var authorization = "authorization_example";  // string | 
            var fiat = "fiat_example";  // string | 
            var country = "country_example";  // string | 
            var type = "type_example";  // string | 

            try
            {
                SupportedPaymentTypesCurrencyResponse result = apiInstance.OnRamperGetSupportedPaymentTypes(authorization, fiat, country, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnramperApi.OnRamperGetSupportedPaymentTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnRamperGetSupportedPaymentTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SupportedPaymentTypesCurrencyResponse> response = apiInstance.OnRamperGetSupportedPaymentTypesWithHttpInfo(authorization, fiat, country, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnramperApi.OnRamperGetSupportedPaymentTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **fiat** | **string** |  |  |
| **country** | **string** |  |  |
| **type** | **string** |  |  |

### Return type

[**SupportedPaymentTypesCurrencyResponse**](SupportedPaymentTypesCurrencyResponse.md)

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

<a id="onrampergetsupportedpaymenttypesfiat"></a>
# **OnRamperGetSupportedPaymentTypesFiat**
> SupportedPaymentTypesCurrencyResponse OnRamperGetSupportedPaymentTypesFiat (string authorization, string fiat, string country)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.usemoon.MoonSDK.Api;
using com.usemoon.MoonSDK.Client;
using com.usemoon.MoonSDK.Model;

namespace Example
{
    public class OnRamperGetSupportedPaymentTypesFiatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://beta.usemoon.ai";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OnramperApi(config);
            var authorization = "authorization_example";  // string | 
            var fiat = "fiat_example";  // string | 
            var country = "country_example";  // string | 

            try
            {
                SupportedPaymentTypesCurrencyResponse result = apiInstance.OnRamperGetSupportedPaymentTypesFiat(authorization, fiat, country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnramperApi.OnRamperGetSupportedPaymentTypesFiat: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OnRamperGetSupportedPaymentTypesFiatWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SupportedPaymentTypesCurrencyResponse> response = apiInstance.OnRamperGetSupportedPaymentTypesFiatWithHttpInfo(authorization, fiat, country);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OnramperApi.OnRamperGetSupportedPaymentTypesFiatWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** |  |  |
| **fiat** | **string** |  |  |
| **country** | **string** |  |  |

### Return type

[**SupportedPaymentTypesCurrencyResponse**](SupportedPaymentTypesCurrencyResponse.md)

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

