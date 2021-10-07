# Lusid.Sdk.Model.OrderGraphBlock

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Block** | [**Block**](Block.md) |  | 
**OrderIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Identifiers for all the orders in this block. | 
**PlacementIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Identifiers of all placements for the block. | 
**AllocationIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Identifiers for all allocations of placements to orders in the block. | 
**ExecutionIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Identifiers of all executions against placements in the block. | 
**Ordered** | **decimal** | Total number of units of the instrument across all orders in the block. | 
**Placed** | **decimal** | Number of units of the instrument across all placements in the block. | 
**Allocated** | **decimal** | Number of units of the instrument across all allocations in the block. | 
**Executed** | **decimal** | How many of the quantity ordered for this block have been executed in the market. | 
**DerivedState** | **string** | A simple description of the overall state of a block. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
