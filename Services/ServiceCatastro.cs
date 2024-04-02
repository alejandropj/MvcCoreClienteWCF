using MvcCoreClienteWCF.Models;
using ServiceReferenceCatastro;
using System.Xml;
using System.Xml.Linq;

namespace MvcCoreClienteWCF.Services
{
    public class ServiceCatastro
    {
        CallejerodelasedeelectrónicadelcatastroSoapClient client;
        public ServiceCatastro (CallejerodelasedeelectrónicadelcatastroSoapClient client)
        {
            this.client = client;
        }

        public async Task<List<Provincia>> GetProvinciasAsync()
        {
            ConsultaProvincia1 response=
            await this.client.ObtenerProvinciasAsync();

            XmlNode nodoProvincias = response.Provincias;
            string dataXml = nodoProvincias.OuterXml;
            XDocument document = XDocument.Parse(dataXml);
            XNamespace ns = "http://www.catastro.meh.es/";
            var consulta = from datos in document.Descendants(ns+"prov")
                           select new Provincia()
                           {
                               IdProvincia = int.Parse(datos.Element(ns+"cpine").Value),
                               Nombre = datos.Element(ns+"np").Value
                           };
            return consulta.ToList();
        }        
        public async Task<List<string>> GetMunicipiosAsync(string provincia)
        {
            ConsultaMunicipio1 response=
            await this.client.ObtenerMunicipiosAsync(provincia,null);

            XmlNode nodoProvincias = response.Municipios;
            string dataXml = nodoProvincias.OuterXml;
            XDocument document = XDocument.Parse(dataXml);
            XNamespace ns = "http://www.catastro.meh.es/";
            var consulta = from datos in document.Descendants(ns + "muni")
                           select datos.Element(ns + "nm").Value;
            return consulta.ToList();
        }
    }
}

