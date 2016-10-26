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

    }
}
