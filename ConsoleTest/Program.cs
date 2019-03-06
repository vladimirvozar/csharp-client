using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure API key authorization: clientId
            // Configuration.Default.ApiKey.Add("X-IBM-Client-Id", "YOUR_API_KEY");
            Configuration.Default.ApiKey.Add("X-IBM-Client-Id", "YOUR_API_KEY");
            
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-IBM-Client-Id", "Bearer");

            // Configure API key authorization: client secret
            Configuration.Default.ApiKey.Add("X-IBM-Client-Secret", "YOUR_CLIENT_SECRET");


            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "AUTH_TOKEN";

            var apiInstance = new AccountsV3Api();
            var id = "FI7473834510057469-EUR";  // string | Internal, technical account identifier

            try
            {
                // Get account details by account id
                // AccountDetailsResponse result = apiInstance.AccountDetailsUsingGET1(id);
                // Debug.WriteLine(result);

                // Get account list
                AccountListResponse result = apiInstance.AccountListUsingGET1WithHttpInfo().Data;
                foreach(var account in result.Response.Accounts)
                {
                    Debug.WriteLine(account);
                }
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsV2Api.AccountDetailsUsingGET: " + e.Message);
            }
        }
    }
}
