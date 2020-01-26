using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using stormtestmvc.Data;
using stormtestmvc.filters;
using stormtestmvc.helpers;
using stormtestmvc.Models;

namespace stormtestmvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly int _pageSize;
        public HomeController(
            ApplicationDbContext context,
            IConfiguration configuration
            )
        {
            _context = context;
            _configuration =     configuration;
            _pageSize = int.Parse(_configuration["PAGE_SIZE"]);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View(new LoginModel
            {
                Username = "Development.Team@storm-technologies.com",
                Password = "-!NmmQR2pbmJSQ7"
            });
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Employee()
        {
            return View();
        }

        public async Task<IActionResult> ViewEmployees(int? pageNumber)
        {
            return View(pageNumber);
        }

        [Authorize("has:token")]
        public async Task<IActionResult> Employees(int? pageNumber)
        {
            return Ok(await PaginatedList<Employee>.CreateAsync(_context.Employees, pageNumber ?? 1, _pageSize));
        }

        public async Task<IActionResult> Departments(int? pageNumber)
        {
            return Ok(await PaginatedList<Department>.CreateAsync(_context.Departments, pageNumber ?? 1, _pageSize));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
