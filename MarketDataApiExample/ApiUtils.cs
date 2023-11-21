using MarketDataApiExample.Models;
using Newtonsoft.Json;

namespace MarketDataApiExample
{
  public class ApiUtils
  {

    private const string Domain = "https://apidev.upstream.exchange";
    public const string SubscriptionKey = ""; // contact the Upstream customer support team to get a subscription key
    public const string Symbol = "TOX";

    public async Task<MarketDataModel> GetMarketData(string symbol)
    {
      var marketDataJson = await ApiRequest($"/marketdata/v1/GetBySymbol/symbol/{symbol}");

      try
      {
        var marketData = JsonConvert.DeserializeObject<MarketDataModel>(marketDataJson);
        return marketData;
      }
      catch (Exception ex)
      {
        return new MarketDataModel();
      }
    }

    public async Task<List<TimeAndSalesModel>> TimeAndSales(string symbol, string pageStart)
    {
      var timeAndSalesJson = await ApiRequest($"/marketdata/v1/timeAndSales/symbol/{symbol}/pageStart/{pageStart}");

      try
      {
        var timeAndSales = JsonConvert.DeserializeObject<List<TimeAndSalesModel>>(timeAndSalesJson);
        return timeAndSales;
      }
      catch (Exception ex)
      {
        return new List<TimeAndSalesModel>();
      }
    }

    public async Task<List<OrderbookModel>> GetOrderbookBySymbol(string symbol)
    {
      var orderbookJson = await ApiRequest($"/marketdata/v1/GetOrderbookBySymbol/symbol/{symbol}");

      try
      {
        var orderbook = JsonConvert.DeserializeObject<List<OrderbookModel>>(orderbookJson);
        return orderbook;
      }
      catch (Exception ex)
      {
        return new List<OrderbookModel>();
      }
    }

    public async Task<List<NewsModel>> GetNews(string symbol)
    {
      var newsJson = await ApiRequest($"/marketdata/v1/GetNews/symbol/{symbol}");

      try
      {
        var news = JsonConvert.DeserializeObject<List<NewsModel>>(newsJson);
        return news;
      }
      catch (Exception ex)
      {
        return new List<NewsModel>();
      }
    }

    private async Task<string> ApiRequest(string requestPath)
    {
      try
      {
        var requestUri = $"{Domain}{requestPath}";
        // Set up the http client to send the request
        var client = new HttpClient();

        client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", $"{SubscriptionKey}"); // add the header Ocp-Apim-Subscription-Key

        var response = await client.GetAsync(requestUri, HttpCompletionOption.ResponseHeadersRead);

        // Store the response content in a string variable
        string jsonResponse = await response.Content.ReadAsStringAsync();
        // Stream the response content
        return jsonResponse;
      }
      catch (Exception ex)
      {
        return $@"{{ ""error"":""Exception: {ex.Message}"" }}";
      }
    }

  }
}
