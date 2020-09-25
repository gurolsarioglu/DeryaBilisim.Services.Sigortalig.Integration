﻿using DeryaBilisim.Services.Sigortalig.Integration.Standart;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace MvcCoreSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SigortaligService _sigortaligService;

        public HomeController(ILogger<HomeController> logger, SigortaligService sigortaligService)
        {
            _logger = logger;
            _sigortaligService = sigortaligService;
        }

        public IActionResult Index()
        {
            // BES
            var response = _sigortaligService.NewBesInsuranceRequest(new NewBesInsuranceRequestModel
            {
                BirthDate = DateTime.Now.AddYears(-10),
                FirstName = "Andrew",
                LastName = "King",
                Mail = "kau31288@eoopy.com",
                PhoneNumber = "601-915-0841",
                TCKN = "32331135922"
            });


            Debug.WriteLine(response.StatusCode, "Sigortalig Request");
            Debug.WriteLine(response.Data?.message, "Sigortalig Request");
            Debug.WriteLine(response.Data?.data?.Message, "Sigortalig Request");
            Debug.WriteLine(response.Data?.data?.ReferanceCode, "Sigortalig Request");

            return View();
        }
    }
}