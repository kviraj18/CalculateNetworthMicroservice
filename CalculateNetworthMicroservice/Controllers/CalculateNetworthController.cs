using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculateNetworthMicroservice.Models;
using System.Net.Http;
using CalculateNetworthMicroservice.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculateNetworthMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateNetworthController : ControllerBase
    {
        private IPortfolioService _PortfolioService;

        public CalculateNetworthController(IPortfolioService portfolioService)
        {
            _PortfolioService = portfolioService;
        }

        // GET: api/<CalculateNetworthController>
        [HttpGet("{portfolioId}")]
        public ActionResult<double> CalculateNetworth(int portfolioId)
        {
            if (portfolioId < 0)
                return this.BadRequest("Incorect ID");

            PortfolioDetails portfolioDetails = _PortfolioService.GetPortfolio(portfolioId);

            if (portfolioDetails == null)
                return this.BadRequest("Empty Portfolio");
            
            double result =  _PortfolioService.CalculateNetworth(portfolioDetails).Result;
            return result;        
        }

        // POST api/<CalculateNetworthController>
        [HttpPost]
        public ActionResult<AssetSaleResponse> SellAssets([FromBody] PortfolioDetails portfolioDetails )
        {
            if (portfolioDetails == null)
                return this.BadRequest("Empty Input");

            AssetSaleResponse assetSaleResponse = new AssetSaleResponse
            {
                Networth = _PortfolioService.CalculateNetworth(portfolioDetails).Result,
                SaleStatus = true
            };

            return assetSaleResponse;
        }
    }
}
