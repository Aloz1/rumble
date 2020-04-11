using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using carbon.api.Models;
using carbon.core.domain.model;
using carbon.core.dtos.model;
using carbon.core.dtos.ui;
using carbon.persistence.interfaces;
using Microsoft.AspNetCore.Authorization;

namespace carbon.api.Controllers
{
    [Authorize]
    [Route("/")]
    [Controller]
    public class HomeController : CarbonController
    {
        private readonly IReadOnlyRepository _readOnlyRepository;
        
        public HomeController(IReadOnlyRepository readOnlyRepository)
        {
            _readOnlyRepository = readOnlyRepository;
        }
        
        [AllowAnonymous]
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("privacy")]
        public IActionResult Privacy()
        {   
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            
            var vm = new ErrorViewModel
            {
                RequestId = requestId
            };
            
            Debug.WriteLine("Error: " + requestId);
            
            return View(vm);
        }
    }
}