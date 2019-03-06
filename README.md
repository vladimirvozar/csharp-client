# IO.Swagger - the C# library for the Nordea Account Information Services API v3

Open Banking API

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.2.0-SNAPSHOT
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://nordeaopenbanking.com](https://nordeaopenbanking.com)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: clientId
            Configuration.Default.ApiKey.Add("X-IBM-Client-Id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-IBM-Client-Id", "Bearer");
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost:8080*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountsV3Api* | [**AccountDetailsUsingGET1**](docs/AccountsV3Api.md#accountdetailsusingget1) | **GET** /v3/accounts/{id} | Get account details by account id
*AccountsV3Api* | [**AccountListUsingGET1**](docs/AccountsV3Api.md#accountlistusingget1) | **GET** /v3/accounts | Get list of accounts
*AccountsV3Api* | [**TransactionListUsingGET1**](docs/AccountsV3Api.md#transactionlistusingget1) | **GET** /v3/accounts/{id}/transactions | Get account transactions


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountDetails](docs/AccountDetails.md)
 - [Model.AccountDetailsResponse](docs/AccountDetailsResponse.md)
 - [Model.AccountInfo](docs/AccountInfo.md)
 - [Model.AccountList](docs/AccountList.md)
 - [Model.AccountListResponse](docs/AccountListResponse.md)
 - [Model.AccountNumber](docs/AccountNumber.md)
 - [Model.BankInfo](docs/BankInfo.md)
 - [Model.CreditTransaction](docs/CreditTransaction.md)
 - [Model.DebitTransaction](docs/DebitTransaction.md)
 - [Model.ExternalErrorResponse](docs/ExternalErrorResponse.md)
 - [Model.ExternalErrorResponseV2](docs/ExternalErrorResponseV2.md)
 - [Model.ExternalErrorResponseV3](docs/ExternalErrorResponseV3.md)
 - [Model.ExternalErrorV2](docs/ExternalErrorV2.md)
 - [Model.ExternalErrorV3](docs/ExternalErrorV3.md)
 - [Model.ExternalFailure](docs/ExternalFailure.md)
 - [Model.ExternalRequestEchoV2](docs/ExternalRequestEchoV2.md)
 - [Model.ExternalRequestEchoV3](docs/ExternalRequestEchoV3.md)
 - [Model.ExternalResponseHeaderV3](docs/ExternalResponseHeaderV3.md)
 - [Model.Link](docs/Link.md)
 - [Model.PaginationV2](docs/PaginationV2.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionList](docs/TransactionList.md)
 - [Model.TransactionListResponse](docs/TransactionListResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="clientId"></a>
### clientId

- **Type**: API key
- **API key parameter name**: X-IBM-Client-Id
- **Location**: HTTP header

<a name="oauth2"></a>
### oauth2

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: /v3/authorize
- **Scopes**: 
  - ACCOUNTS_BASIC: Account information
  - ACCOUNTS_BALANCES: Account information with balances
  - ACCOUNTS_DETAILS: Account information with details
  - ACCOUNTS_TRANSACTIONS: Account&#39;s transactions
  - PAYMENTS_ONETIME: Payments Onetime
  - PAYMENTS_MULTIPLE: Payments Multiple
