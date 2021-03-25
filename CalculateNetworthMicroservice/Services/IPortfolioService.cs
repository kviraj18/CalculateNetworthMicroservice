using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculateNetworthMicroservice.Models;

namespace CalculateNetworthMicroservice.Services
{
    public interface IPortfolioService
    {
        public PortfolioDetails GetPortfolio(int portfolioId);

        public Task<double> CalculateNetworth(PortfolioDetails portfolioDetails);
    }
}
