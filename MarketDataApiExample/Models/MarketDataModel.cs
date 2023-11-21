namespace MarketDataApiExample.Models;
using System;

public class MarketDataModel
{
  public int Id { get; set; }
  public string Symbol { get; set; }
  public decimal LastExecutedPrice { get; set; }
  public decimal LastPercentageChange { get; set; }
  public decimal LastVolume { get; set; }
  public decimal LastBidPrice { get; set; }
  public decimal LastOfferPrice { get; set; }
  public decimal BestLimitBid { get; set; }
  public decimal BestLimitOffer { get; set; }
  public decimal BestBidVolume { get; set; }
  public decimal BestOfferVolume { get; set; }
  public decimal TodaysVolume { get; set; }

  public int TodaysTrades { get; set; }
  public decimal TodaysHigh { get; set; }
  public decimal TodaysLow { get; set; }
  public decimal TodaysVwap { get; set; }
  public decimal TodaysOpen { get; set; }
  public decimal PreviousClose { get; set; }
  public DateTime CreateTime { get; set; }
  public DateTime ModifiedTime { get; set; }
  public DateTime ExpiryTime { get; set; }
  public decimal Low52Week { get; set; }
  public decimal High52Week { get; set; }
  public decimal Low24Hour { get; set; }
  public decimal High24Hour { get; set; }
  public decimal MidPointCashVolume { get; set; }
  public decimal MidPointShareVolume { get; set; }
  public decimal MidPointPrice { get; set; }
  public decimal MidPointPriceMax { get; set; }
  public decimal MidPointPriceMin { get; set; }
  public decimal SharesIssued { get; set; }
  public decimal Float { get; set; }

}

