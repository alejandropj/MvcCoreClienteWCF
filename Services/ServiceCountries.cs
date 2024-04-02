using ServiceCountriesNameSpace;

namespace MvcCoreClienteWCF.Services
{
    public class ServiceCountries
    {
        CountryInfoServiceSoapTypeClient client;
        public ServiceCountries()
        {
            this.client = new CountryInfoServiceSoapTypeClient
                (CountryInfoServiceSoapTypeClient.EndpointConfiguration
                .CountryInfoServiceSoap);
        }
    }
}
