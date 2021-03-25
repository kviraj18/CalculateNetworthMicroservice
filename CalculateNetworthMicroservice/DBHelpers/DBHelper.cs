using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculateNetworthMicroservice.Models;
namespace CalculateNetworthMicroservice.DBHelpers
{
    static class DBHelper
    {
        public static List<PortfolioDetails> PortfolioDetails = new List<PortfolioDetails>()

        {
            new PortfolioDetails() { PortfolioId = 1001, 
                                     StockList = new List<StockDetails>() {  
                                                        new StockDetails() { StockName = "Cognizant", StockCount = 5},
                                                        new StockDetails() { StockName = "TATA", StockCount = 4}
                                                                        },
                                     MutualFundList = new List<MutualFundDetails>() { 
                                                        new MutualFundDetails() { MutualFundName = "Liquid Funds", MutualFundUnits = 5},
                                                        new MutualFundDetails() { MutualFundName = "Equity Funds", MutualFundUnits = 4}
                                     }
            
            },
            new PortfolioDetails() { PortfolioId = 1002,
                                     StockList = new List<StockDetails>() {
                                                        new StockDetails() { StockName = "Tesla", StockCount = 2},
                                                        new StockDetails() { StockName = "Facebook", StockCount = 7}
                                                                        },
                                     MutualFundList = new List<MutualFundDetails>() {
                                                        new MutualFundDetails() { MutualFundName = "Liquid Funds", MutualFundUnits = 4},
                                                        new MutualFundDetails() { MutualFundName = "Balanced Funds", MutualFundUnits = 8}
                                     }
            },
            new PortfolioDetails() { PortfolioId = 1003,
                                     StockList = new List<StockDetails>() {
                                                        new StockDetails() { StockName = "Apple", StockCount = 5},
                                                        new StockDetails() { StockName = "Facebook", StockCount = 7}
                                                                        },
                                     MutualFundList = new List<MutualFundDetails>() {
                                                        new MutualFundDetails() { MutualFundName = "Liquid Funds", MutualFundUnits = 4},
                                                        new MutualFundDetails() { MutualFundName = "Balanced Funds", MutualFundUnits = 8}
                                     }
            },
            new PortfolioDetails() { PortfolioId = 1004,
                                     StockList = new List<StockDetails>() {
                                                        new StockDetails() { StockName = "Tesla", StockCount = 2},
                                                        new StockDetails() { StockName = "Apple", StockCount = 5}
                                                                        },
                                     MutualFundList = new List<MutualFundDetails>() {
                                                        new MutualFundDetails() { MutualFundName = "Liquid Funds", MutualFundUnits = 4},
                                                        new MutualFundDetails() { MutualFundName = "Balanced Funds", MutualFundUnits = 8}
                                     }
            },
        };
    }
}
