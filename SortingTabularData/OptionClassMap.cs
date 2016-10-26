using CsvHelper.Configuration;
using System;
using System.Linq;

namespace SortingTabularData
{
    public sealed class OptionClassMap : CsvClassMap<Option>
    {
        public OptionClassMap()
        {
            Map(m => m.Book).Index((int)ColumnPropertyName.Book);
            Map(m => m.BuySell).Index((int)ColumnPropertyName.BuySell);
            Map(m => m.BuySellQuantity).Index((int)ColumnPropertyName.BuySellQuantity); 
            Map(m => m.CallPut).Index((int)ColumnPropertyName.CallPut);
            Map(m => m.Counterparty).Index((int)ColumnPropertyName.Counterparty);
            Map(m => m.Currency).Index((int)ColumnPropertyName.Currency);
            Map(m => m.Entity).Index((int)ColumnPropertyName.Entity);
            Map(m => m.Maturity).Index((int)ColumnPropertyName.Maturity);
            Map(m => m.OptionCode).Index((int)ColumnPropertyName.OptionCode);
            Map(m => m.OptionType).Index((int)ColumnPropertyName.OptionType);
            Map(m => m.SpotPrice).Index((int)ColumnPropertyName.SpotPrice);
            Map(m => m.Strike).Index((int)ColumnPropertyName.Strike);
            Map(m => m.TradeDate).Index((int)ColumnPropertyName.TradeDate);
            Map(m => m.TradePricePerOption).Index((int)ColumnPropertyName.TradePricePerOption);
            Map(m => m.Underlying).Index((int)ColumnPropertyName.Underlying);
            Map(m => m.Volatility).Index((int)ColumnPropertyName.Volatility);
            Map(m => m.Volume).Index((int)ColumnPropertyName.Volume);
        }
    }
}
