using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPICalculator.Models;

namespace WebAPICalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculator;
        public CalculatorController(ICalculator calculator)
        {
            _calculator = calculator;
        }
        [HttpGet("Add")]
        public async Task<ActionResult<int>> AddAsync(int a, int b)
        {
            try
            {
                return Ok(await _calculator.AddAsync(a,b));
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }
        [HttpGet("Sub")]
        public async Task<ActionResult<int>> SubtractAsync(int a, int b)
        {
            try
            {
                return Ok(await _calculator.SubtractAsync(a, b));
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }
        [HttpGet("Mul")]
        public async Task<ActionResult<int>> MultiplyAsync(int a, int b)
        {
            try
            {
                return Ok(await _calculator.MultiplyAsync(a, b));
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }
        [HttpGet("Div")]
        public async Task<ActionResult<int>> DivideAsync(int a, int b)
        {
            try
            {
                return Ok(await _calculator.DivideAsync(a, b));
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }
    }
}