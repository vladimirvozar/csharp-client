# IO.Swagger.Model.AccountDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Internal, technical account identifier | 
**Links** | [**List&lt;Link&gt;**](Link.md) | HATEOAS inspired links | [optional] 
**AccountName** | **string** | Account name | 
**AccountNumbers** | [**List&lt;AccountNumber&gt;**](AccountNumber.md) | Account numbers | 
**AccountType** | **string** | Account type | 
**AvailableBalance** | **decimal?** | Available balance indicates the funds which are available to the account holder at the time of the query | 
**Bank** | [**BankInfo**](BankInfo.md) | Details of bank servicing account | 
**BookedBalance** | **decimal?** | Booked balance includes all transactions entered on the account at the time of the query | 
**Country** | **string** | Country code where the account is held according to ISO ALPHA-2 | [optional] 
**CreditLimit** | **decimal?** | Amount of credit extended to account holder beyond account booked balance | [optional] 
**Currency** | **string** | Currency code according to ISO 4217 | 
**LatestTransactionBookingDate** | **DateTime?** | Date of last transaction booked to the account | [optional] 
**Product** | **string** | Name of the banking product delivered by this account | 
**Status** | **string** | Status of account | 
**ValueDatedBalance** | **decimal?** | Value dated balance is the balance on the basis of which interest is calculated on the account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

