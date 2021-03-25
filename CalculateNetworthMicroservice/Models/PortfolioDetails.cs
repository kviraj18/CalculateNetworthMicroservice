using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateNetworthMicroservice.Models
{
    public class PortfolioDetails
    {
        public int PortfolioId { get; set; }
        public List<StockDetails> StockList { get; set; }
        public List<MutualFundDetails> MutualFundList { get; set; }

    }
}
