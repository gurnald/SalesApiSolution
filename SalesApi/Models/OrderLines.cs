namespace SalesApi.Models;

public class OrderLines {

    public int Id { get; set; }
    public int Quantity { get; set; } = 1;
    public int OrderId { get; set; }
    public int ItemId { get; set; }

}
