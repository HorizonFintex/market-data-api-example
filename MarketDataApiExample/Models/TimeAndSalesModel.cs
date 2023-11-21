namespace MarketDataApiExample.Models;
public record TimeAndSalesModel(int Id, DateTime ExecutionTime, decimal Price, decimal Quantity, string Transaction)
{
  public override string ToString()
  {
    return $"Execution Time: Id: {Id}, {ExecutionTime}, Price: {Price}, Quantity: {Quantity}, Transaction: {Transaction}";
  }
}

