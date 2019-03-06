# IO.Swagger.Model.TransactionList
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**List&lt;Link&gt;**](Link.md) | HATEOAS inspired links | [optional] 
**ContinuationKey** | **string** | Resource listing may return a continuationKey if there&#39;s more results available. Request may be retried with the continuationKey, but otherwise same parameters, in order to get more results. | [optional] 
**Transactions** | [**List&lt;Transaction&gt;**](Transaction.md) | Listed transactions | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

