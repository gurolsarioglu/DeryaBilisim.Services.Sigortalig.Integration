# DeryaBilisim.Services.Sigortalig.Integration
Sigortalig API servisi ile iletişim kuracak olan nuget pack

## Gereksinimler
API sistemi, Sigortalig sisteminde sigorta acentası şirket hesapları içindir. Acentaların websitesi ya da başka kaynaktan taleplerini sigortalig portalında toplamalarını sağlamak içindir. Sigortalig yönetiminden, sisteminizin API ile konuşabilmesi için gerekli **Erişim Anahtar Kodunu kodunu** talep edebilirsiniz. Bu erişim anahtarı ile [nuget paketini](https://www.nuget.org/packages/DeryaBilisim.Services.Sigortalig.Integration.Standart) projenize ekleyerek entegre olabilirsiniz.


## Endpoints

Test Endpoint : https://sigortaligapi-test.azurewebsites.net/api

Prod Endpoint : https://sigortaligapi.azurewebsites.net/api


## .NET Core MVC/API App Entegrasyonu

[DeryaBilisim.Services.Sigortalig.Integration.Standart](https://www.nuget.org/packages/DeryaBilisim.Services.Sigortalig.Integration.Standart) nuget paketini uygulamanıza ekleyiniz. 

### Örnek BES Talep Gönderimi;

#### **appsettings.json**
appsettings.json içerisinde aşağıdaki section ı açarak gerekli endpoint ve token kodunu(şirket hesabı ile test ya da prod ortamda kayıt olarak oluşturabilirsiniz) giriniz.

```javascript
{
  "SigortaligIntegration": {
    "Endpoint": "https://sigortaligapi-test.azurewebsites.net/api",
    "Token": "<<Your-Access-Token>>"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

#### **Startup.cs**
Startup dosyasında gerekli servis entegrasyonunu sağlayınız. appsettings.json değerlerini kullanınız. Sigortalig Servisi singleton olarak üretilecek şekilde tanımlanacaktır.

```csharp
using DeryaBilisim.Services.Sigortalig.Integration.Standart;

public void ConfigureServices(IServiceCollection services)
{
    var sigortaligServiceSettingsSection = Configuration.GetSection("SigortaligIntegration");
    var sigortaligServiceEndpoint = sigortaligServiceSettingsSection.GetValue<string>("Endpoint");
    var sigortaligServiceToken = sigortaligServiceSettingsSection.GetValue<string>("Token");
    services.AddSigortaligService(sigortaligServiceEndpoint, sigortaligServiceToken);
    
    services.AddControllersWithViews();
}
```


#### **HomeController.cs**

> Sigortalig servisini kullanmak istediğiniz yerde aşağıdaki şekilde Dependency Injection yaparak kullanımını sağlayabilirsiniz. Aynı zamanda BiBayim sistemini de kullanmak için [BiBayim Entegrasyonunu](https://github.com/muratbaseren/DeryaBilisim.Services.BiBayim.Integration) yapabilirsiniz. **Sigortalig, BiBayim sistemine zaten entegredir**.

Gönderdiğiniz talepte bayi ye komisyon kazanımını sağlamanız için bayinin sizin websiteniz ya da uygulamanıza müşteriyi yönlendirdiği link'teki **ReferalCode ve ProductId değerlerini** talep bilgisi ile ilgili alanlara yazarak gönderebilirsiniz. Poliçe kesiminde poliçe tutarı üzerinden gerekli komisyon kazanımı Sigortalig Portalı tarafından otomatik yapılarak BiBayim Portalı üzerinden görülebilecektir.

```csharp
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
```
