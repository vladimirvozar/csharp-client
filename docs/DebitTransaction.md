# IO.Swagger.Model.DebitTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal?** | Transaction value | 
**BalanceAfterTransaction** | **decimal?** | Balance after transaction | [optional] 
**BookingDate** | **DateTime?** | Date transaction was booked to the account ledger | 
**CardNumber** | **string** | 4 digits of card number of the transaction | [optional] 
**CounterpartyAccount** | **string** | Counterparty account details | [optional] 
**CounterpartyName** | **string** | Counterparty name | [optional] 
**Currency** | **string** | Currency code according to ISO 4217 | 
**CurrencyRate** | **decimal?** | Currency code according to ISO 4217 | [optional] 
**Message** | **string** | Message from remitter to beneficiary. In Finland this may alternatively include a short description of the transaction e.g. &#39;Automaattiotto&#39; | [optional] 
**Narrative** | **string** | Transaction narrative (customer custom message) | [optional] 
**OriginalCurrency** | **string** | Currency code according to ISO 4217 | [optional] 
**OriginalCurrencyAmount** | **decimal?** | Foreign transaction amount in original currency | [optional] 
**OwnMessage** | **string** | Text message for the account holder&#39;s own use | [optional] 
**PaymentDate** | **DateTime?** | Payment date of the transaction | [optional] 
**Reference** | **string** | Reference number | [optional] 
**Status** | **string** | Status of the transaction | 
**TransactionDate** | **DateTime?** | Date on which transaction was enacted | [optional] 
**TransactionId** | **string** | Unique transaction identifier as defined by the bank | 
**TypeDescription** | **string** | Description of the type of transaction, e.g. Cash withdrawal, Account transfer, etc. (localized) | [optional] 
**ValueDate** | **DateTime?** | Value date of the transaction, used for interest calculation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

