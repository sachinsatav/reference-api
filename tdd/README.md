# **T**est **D**riven **D**evelopment (**TDD**)

## Requirements

As a user, I want to be able to create a new invoice with the following schema:

```javascript
{
  "customer": "string",
  "amount": 0,
  "payments": [
    {
      "amount": 0
    }
  ]
}
```

The invoice, before being persisted to the backend, will set a new property called `AmountDue`.

To find the amount due: subtract the sum of all the payments from the initial amount.

- Example: if the initial amount is 10£ and the payments contains 2 items (3£ and 3£), the resulting amount due will be 4£.
