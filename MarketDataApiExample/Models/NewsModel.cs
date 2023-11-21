namespace MarketDataApiExample.Models;
public record NewsModel(DateTime CreateTime, DateTime Modifiedtime, string Symbol, string Title, string Summary, string Url)
{
  public override string ToString()
  {
    return $"CreateTime: {CreateTime}, Modifiedtime: {Modifiedtime}, Symbol: {Symbol}, Title: {Title}, Summary: {Summary}, Url: {Url}";
  }
}
