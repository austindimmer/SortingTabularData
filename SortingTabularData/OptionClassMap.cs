using CsvHelper.Configuration;
using System;
using System.Linq;

namespace SortingTabularData
{
    public sealed class OptionClassMap : CsvClassMap<Option>
    {
        public OptionClassMap()
        {
            Map(m => m.Book);
            Map(m => m.BuySell);
            Map(m => m.BuySellQuantity); ;
            Map(m => m.CallPut);
            Map(m => m.Counterparty);
            Map(m => m.Currency);
            Map(m => m.Entity);
            Map(m => m.Maturity);
            Map(m => m.OptionCode);
            Map(m => m.OptionType);
            Map(m => m.SpotPrice);
            Map(m => m.Strike);
            Map(m => m.TradeDate);
            Map(m => m.TradePricePerOption);
            Map(m => m.Underlying);
            Map(m => m.Volatility);
            Map(m => m.Volume);
        }
    }
}
