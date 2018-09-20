public bool SubmitCreditCardOrder(string firstName, string lastName, string zipcode, string streetAddress1,
string streetAddress2, string city, string state, string country, string phoneNumber,
string creditCardNumber, int expirationMonth, int expirationYear, decimal saleAmount)
{
    // … submit order
}



public bool SubmitCreditCardOrder(ContactInformation customerInfo, CreditCard card, decimal saleAmount)
{
    // … submit order
}