﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceEscenas
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Escena", Namespace="http://schemas.datacontract.org/2004/07/WCFLogicaEscenasPelis.Models")]
    public partial class Escena : object
    {
        
        private string DescripcionField;
        
        private int IdPeliculaField;
        
        private string ImagenField;
        
        private string TituloEscenaField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion
        {
            get
            {
                return this.DescripcionField;
            }
            set
            {
                this.DescripcionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPelicula
        {
            get
            {
                return this.IdPeliculaField;
            }
            set
            {
                this.IdPeliculaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Imagen
        {
            get
            {
                return this.ImagenField;
            }
            set
            {
                this.ImagenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TituloEscena
        {
            get
            {
                return this.TituloEscenaField;
            }
            set
            {
                this.TituloEscenaField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceEscenas.IEscenasContract")]
    public interface IEscenasContract
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEscenasContract/GetEscenas", ReplyAction="http://tempuri.org/IEscenasContract/GetEscenasResponse")]
        System.Threading.Tasks.Task<ServiceReferenceEscenas.Escena[]> GetEscenasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEscenasContract/FindEscenaByIdPelicula", ReplyAction="http://tempuri.org/IEscenasContract/FindEscenaByIdPeliculaResponse")]
        System.Threading.Tasks.Task<ServiceReferenceEscenas.Escena> FindEscenaByIdPeliculaAsync(int idpelicula);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface IEscenasContractChannel : ServiceReferenceEscenas.IEscenasContract, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class EscenasContractClient : System.ServiceModel.ClientBase<ServiceReferenceEscenas.IEscenasContract>, ServiceReferenceEscenas.IEscenasContract
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public EscenasContractClient() : 
                base(EscenasContractClient.GetDefaultBinding(), EscenasContractClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IEscenasContract.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EscenasContractClient(EndpointConfiguration endpointConfiguration) : 
                base(EscenasContractClient.GetBindingForEndpoint(endpointConfiguration), EscenasContractClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EscenasContractClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(EscenasContractClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EscenasContractClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(EscenasContractClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public EscenasContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceEscenas.Escena[]> GetEscenasAsync()
        {
            return base.Channel.GetEscenasAsync();
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceEscenas.Escena> FindEscenaByIdPeliculaAsync(int idpelicula)
        {
            return base.Channel.FindEscenaByIdPeliculaAsync(idpelicula);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IEscenasContract))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IEscenasContract))
            {
                return new System.ServiceModel.EndpointAddress("http://wcfhostescenaspelis2024apj.azurewebsites.net/ServiceWCFEscenas.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return EscenasContractClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IEscenasContract);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return EscenasContractClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IEscenasContract);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IEscenasContract,
        }
    }
}
