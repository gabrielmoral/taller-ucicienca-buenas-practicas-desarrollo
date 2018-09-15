public class Order
{
    private List<OrderLine> _orderLines;
    private decimal _orderTotal;

    public IEnumerable<OrderLine> OrderLines
    {
        get { return _orderLines; }
    }

    public void AddOrderLine(OrderLine orderLine)
    {
        _orderTotal += orderLine.Total;
        _orderLines.Add(orderLine);
    }

    public void RemoveOrderLine(OrderLine orderLine)
    {
        orderLine = _orderLines.Find(o => o == orderLine);
        if (orderLine == null) return;

        _orderTotal -= orderLine.Total;
        _orderLines.Remove(orderLine);
    }
}

//encapsulating the collection

public class Order
{
    private OrderLines _orderLines;

    public OrderLines OrderLines
    {
        get { return _orderLines; }
    }

    public void AddOrderLine(OrderLine orderLine)
    {
        _orderLines.Add(orderLine);
    }

    public void RemoveOrderLine(OrderLine orderLine)
    {
        _orderLines.Remove(orderLine);
    }
}

public class OrderLines
{
    private List<OrderLine> _orderLines;

    public decimal Total { get; private set; }

    public void AddO(OrderLine orderLine)
    {
        Total += orderLine.Total;
        _orderLines.Add(orderLine);
    }

    public void Remove(OrderLine orderLine)
    {
        _orderLines.Find(o => o == orderLine);
        if (orderLine == null) return;

        Total -= orderLine.Total;
        _orderLines.Remove(orderLine);
    }
}