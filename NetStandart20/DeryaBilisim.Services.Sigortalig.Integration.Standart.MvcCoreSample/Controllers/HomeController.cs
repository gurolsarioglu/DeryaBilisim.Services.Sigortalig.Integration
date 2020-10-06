using DeryaBilisim.Services.Sigortalig.Integration.Standart;
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
            // Get All Insurance Type and API EndPoints
            //(tr:Poliçe tiplerini ve API uç adreslerini verir.)
            var getAllInsuranceTypes = _sigortaligService.GetAllInsuranceTypes();



            // Sample Individual Pension Policy Request Registration 
            // (tr:BES poliçe talebi kaydı)
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



            // Create Other New Insurance Request.
            // This method is used for the use of policy types that do not have any method. 
            // (tr:Bu metot, metodu olmayan poliçe tiplerinin kullanımı içindir.)
            var response2 = _sigortaligService.NewOtherInsuranceRequest(new NewOtherInsuranceRequestModel
            {
                FirstName = "Andrew",
                LastName = "King",
                Mail = "kau31288@eoopy.com",
                PhoneNumber = "601-915-0841",
                TCKN = "32331135922"
            }, InsuranceType.AgricultureInsurance);

            Debug.WriteLine(response2.StatusCode, "Sigortalig Request");
            Debug.WriteLine(response2.Data?.message, "Sigortalig Request");
            Debug.WriteLine(response2.Data?.data?.Message, "Sigortalig Request");
            Debug.WriteLine(response2.Data?.data?.ReferanceCode, "Sigortalig Request");

            return View();
        }
    }
}