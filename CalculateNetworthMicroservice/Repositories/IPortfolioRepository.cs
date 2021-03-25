using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculateNetworthMicroservice.Models;
namespace CalculateNetworthMicroservice.Repositories
{
    public interface IPortfolioRepository
    {
        public PortfolioDetails GetPortfolio(int portfolioId);
    }
}
