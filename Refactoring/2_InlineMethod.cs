class PizzaDelivery
{
    //...
    int GetRating()
    {
        return MoreThanFiveLateDeliveries() ? 2 : 1;
    }
    bool MoreThanFiveLateDeliveries()
    {
        return numberOfLateDeliveries > 5;
    }
}



class PizzaDelivery
{
    //...
    int GetRating()
    {
        return numberOfLateDeliveries > 5 ? 2 : 1;
    }
}