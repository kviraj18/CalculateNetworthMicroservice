using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CalculateNetworthMicroservice.Models;
using CalculateNetworthMicroservice.Repositories;

namespace CalculateNetworthMicroservice.Services
{
    public class PortfolioService : IPortfolioService
    {
        private IPortfolioRepository Repository;
        private IHttpClientFactory _httpClientFactory;

        public PortfolioService(IPortfolioRepository _repository, IHttpClientFactory httpClientFactory)
        {
            Repository = _repository;
            _httpClientFactory = httpClientFactory;
        }

        public PortfolioDetails GetPortfolio(int portfolioId)
        {
            return Repository.GetPortfolio(portfolioId);       
        }

        public async Task<double> CalculateNetworth(PortfolioDetails portfolioDetails)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("http://localhost:44357");

            double totalFundNav = 0;
            foreach (var fundDetails in portfolioDetails.MutualFundList)
            {
                //http://52.152.90.186/
                //HttpResponseMessage mutualFundResponse = httpClient.GetAsync("https://localhost:44325/api/mutualFund/" + fundDetails.MutualFundName).Result;
                HttpResponseMessage mutualFundResponse = httpClient.GetAsync("http://52.152.90.186/api/mutualFund/" + fundDetails.MutualFundName).Result;
                double fundNav = await mutualFundResponse.Content.ReadAsAsync<double>();
                totalFundNav += fundNav * fundDetails.MutualFundUnits;
            }

            double totalStock = 0;
            foreach (var stockDetails in portfolioDetails.StockList)
            {
                //http://13.85.189.110/
                //HttpResponseMessage stockResponse = httpClient.GetAsync("https://localhost:44377/api/DailySharePrice/" + stockDetails.StockName).Result;
                HttpResponseMessage stockResponse = httpClient.GetAsync("http://13.85.189.110/api/DailySharePrice/" + stockDetails.StockName).Result;
                double currentStockPrice = await stockResponse.Content.ReadAsAsync<double>();
                totalStock += currentStockPrice * stockDetails.StockCount;
            }

            return totalFundNav + totalStock;
        }
    }
}
