namespace MarketDataApiExample.Models;
public record OrderbookModel(int Level, string Side, DateTime Time, decimal Price, decimal Volume)
{
  public override string ToString()
  {
    return $"Level: {Level}, Side: {Side}, Time: {Time}, Price: {Price}, Volume: {Volume}";
  }
}
