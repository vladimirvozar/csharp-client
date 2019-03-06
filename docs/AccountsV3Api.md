# IO.Swagger.Api.AccountsV3Api

All URIs are relative to *http://localhost:8080*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountDetailsUsingGET1**](AccountsV3Api.md#accountdetailsusingget1) | **GET** /v3/accounts/{id} | Get account details by account id
[**AccountListUsingGET1**](AccountsV3Api.md#accountlistusingget1) | **GET** /v3/accounts | Get list of accounts
[**TransactionListUsingGET1**](AccountsV3Api.md#transactionlistusingget1) | **GET** /v3/accounts/{id}/transactions | Get account transactions


<a name="accountdetailsusingget1"></a>
# **AccountDetailsUsingGET1**
> AccountDetailsResponse AccountDetailsUsingGET1 (string id)

Get account details by account id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountDetailsUsingGET1Example
    {
        public void main()
        {
            // Configure API key authorization: clientId
            Configuration.Default.AddApiKey("X-IBM-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-IBM-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsV3Api();
            var id = id_example;  // string | Internal, technical account identifier

            try
            {
                // Get account details by account id
                AccountDetailsResponse result = apiInstance.AccountDetailsUsingGET1(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsV3Api.AccountDetailsUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Internal, technical account identifier | 

### Return type

[**AccountDetailsResponse**](AccountDetailsResponse.md)

### Authorization

[clientId](../README.md#clientId), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountlistusingget1"></a>
# **AccountListUsingGET1**
> AccountListResponse AccountListUsingGET1 ()

Get list of accounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountListUsingGET1Example
    {
        public void main()
        {
            // Configure API key authorization: clientId
            Configuration.Default.AddApiKey("X-IBM-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-IBM-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsV3Api();

            try
            {
                // Get list of accounts
                AccountListResponse result = apiInstance.AccountListUsingGET1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsV3Api.AccountListUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AccountListResponse**](AccountListResponse.md)

### Authorization

[clientId](../README.md#clientId), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionlistusingget1"></a>
# **TransactionListUsingGET1**
> TransactionListResponse TransactionListUsingGET1 (string id, string continuationKey = null, DateTime? fromDate = null, string language = null, DateTime? toDate = null)

Get account transactions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TransactionListUsingGET1Example
    {
        public void main()
        {
            // Configure API key authorization: clientId
            Configuration.Default.AddApiKey("X-IBM-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-IBM-Client-Id", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccountsV3Api();
            var id = id_example;  // string | Internal, technical account identifier
            var continuationKey = continuationKey_example;  // string | Key to subsequent page of transaction history (optional) 
            var fromDate = 2013-10-20;  // DateTime? | List transactions starting from and including this date (optional) 
            var language = language_example;  // string | Preferred language for textual values (optional) 
            var toDate = 2013-10-20;  // DateTime? | List transactions until and including this date (optional) 

            try
            {
                // Get account transactions
                TransactionListResponse result = apiInstance.TransactionListUsingGET1(id, continuationKey, fromDate, language, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsV3Api.TransactionListUsingGET1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Internal, technical account identifier | 
 **continuationKey** | **string**| Key to subsequent page of transaction history | [optional] 
 **fromDate** | **DateTime?**| List transactions starting from and including this date | [optional] 
 **language** | **string**| Preferred language for textual values | [optional] 
 **toDate** | **DateTime?**| List transactions until and including this date | [optional] 

### Return type

[**TransactionListResponse**](TransactionListResponse.md)

### Authorization

[clientId](../README.md#clientId), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

