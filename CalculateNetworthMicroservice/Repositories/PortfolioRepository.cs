using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculateNetworthMicroservice.Models;
using CalculateNetworthMicroservice.DBHelpers;

namespace CalculateNetworthMicroservice.Repositories
{
    public class PortfolioRepository : IPortfolioRepository
    {
        private List<PortfolioDetails> PortfolioDetails;

        public PortfolioRepository()
        {
            PortfolioDetails = DBHelper.PortfolioDetails;        
        }

        public PortfolioDetails GetPortfolio(int portfolioId)
        {
            foreach (var portFolioDetail in PortfolioDetails)
            {
                if (portFolioDetail.PortfolioId == portfolioId)
                {
                    return portFolioDetail;
                }
            }
            return null;
        }
    }
}
