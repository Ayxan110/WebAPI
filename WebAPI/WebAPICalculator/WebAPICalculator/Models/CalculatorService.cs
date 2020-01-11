using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorService;
using Microsoft.AspNetCore.Mvc;

namespace WebAPICalculator.Models
{
    public class CalService : ICalculator
    {
        private readonly CalculatorSoapClient _calculator;
        public CalService()
        {
            _calculator = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap12);
        }
        public async Task<int> AddAsync(int a, int b)
        {
            return await _calculator.AddAsync(a, b);
        }

        public async Task<int> DivideAsync(int a, int b)
        {
            return await _calculator.DivideAsync(a, b);
        }

        public async Task<int> MultiplyAsync(int a, int b)
        {
            return await _calculator.MultiplyAsync(a, b);
        }

        public async Task<int> SubtractAsync(int a, int b)
        {
            return await _calculator.SubtractAsync(a, b);
        }
    }
}
