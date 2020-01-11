using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICalculator.Models
{
    public interface ICalculator
    {
        Task<int> AddAsync(int a, int b);
        Task<int> SubtractAsync(int a, int b);
        Task<int> MultiplyAsync(int a, int b);
        Task<int> DivideAsync(int a, int b);
    }
}
