using ServiceReferenceEscenas;

namespace MvcCoreClienteWCF.Services
{
    public class ServiceEscenas
    {
        EscenasContractClient client;

        public ServiceEscenas(EscenasContractClient client)
        {
            this.client = client;
        }

        public async Task<Escena[]> GetEscenasAsync()
        {
            Escena[] escenas = await this.client.GetEscenasAsync();
            return escenas;
        }
        public async Task<Escena> GetEscenasPelis(int idpelicula)
        {

            Escena escenas = await this.client.FindEscenaByIdPeliculaAsync(idpelicula);
            return escenas;
        }
    }
}
