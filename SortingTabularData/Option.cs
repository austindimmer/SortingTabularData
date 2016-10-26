using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTabularData
{
    public class Option
    {
        public string Entity { get; set; }
        public string Counterparty { get; set; }
        public string Book { get; set; }
        public string Underlying { get; set; }
        public string OptionType { get; set; }
        public string Currency { get; set; }
        public string TradeDate { get; set; }
        public string OptionCode { get; set; }
        public int Volume { get; set; }
        public string BuySell { get; set; }
        public decimal SpotPrice { get; set; }
        public decimal Strike { get; set; }
        public string CallPut { get; set; }
        public string Maturity { get; set; }
        public int Volatility { get; set; }
        public decimal TradePricePerOption { get; set; }
        public int BuySellQuantity { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Option;
            if (other != null)
                return this.Book == other.Book
                    && this.BuySell == other.BuySell
                    && this.BuySellQuantity == other.BuySellQuantity
                    && this.CallPut == other.CallPut
                    && this.Counterparty == other.Counterparty
                    && this.Currency == other.Currency
                    && this.Entity == other.Entity
                    && this.Maturity == other.Maturity
                    && this.OptionCode == other.OptionCode
                    && this.OptionType == other.OptionType
                    && this.SpotPrice == other.SpotPrice
                    && this.Strike == other.Strike
                    && this.TradeDate == other.TradeDate
                    && this.TradePricePerOption == other.TradePricePerOption
                    && this.Underlying == other.Underlying
                    && this.Volatility == other.Volatility
                    && this.Volume == other.Volume;

            return base.Equals(obj);
        }

    }
}
