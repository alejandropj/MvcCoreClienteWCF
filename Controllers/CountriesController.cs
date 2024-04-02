using Microsoft.AspNetCore.Mvc;
using MvcCoreClienteWCF.Services;
using ServiceCountriesNameSpace;

namespace MvcCoreClienteWCF.Controllers
{
    public class CountriesController : Controller
    {
        private ServiceCountries service;
        public CountriesController(ServiceCountries service)
        {
            this.service = service;
        }
        public async Task<IActionResult> Index()
        {
            tCountryCodeAndName[] countries = await this.service.GetCountriesAsync();
            return View(countries);
        }
        public async Task<IActionResult> Details(string isoCode)
        {
            tCountryInfo country = await this.service.GetCountryInfoAsync(isoCode);
            return View(country);
        }
    }
}
