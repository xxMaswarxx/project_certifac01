﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageRequest", Namespace="http://schemas.datacontract.org/2004/07/Cer.WsFactService.Request")]
    public partial class MessageRequest : object
    {
        
        private string apiKeyField;
        
        private ServiceReference1.Operacion operacionField;
        
        private string rfcEmisorField;
        
        private ServiceReference1.TipoEmisor tipoEmisorField;
        
        private string xmlBase64Field;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string apiKey
        {
            get
            {
                return this.apiKeyField;
            }
            set
            {
                this.apiKeyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.Operacion operacion
        {
            get
            {
                return this.operacionField;
            }
            set
            {
                this.operacionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string rfcEmisor
        {
            get
            {
                return this.rfcEmisorField;
            }
            set
            {
                this.rfcEmisorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReference1.TipoEmisor tipoEmisor
        {
            get
            {
                return this.tipoEmisorField;
            }
            set
            {
                this.tipoEmisorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string xmlBase64
        {
            get
            {
                return this.xmlBase64Field;
            }
            set
            {
                this.xmlBase64Field = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Operacion", Namespace="http://schemas.datacontract.org/2004/07/Cer.WsFactService.Request")]
    public enum Operacion : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Emision = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Cancelacion = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EmisionRetencion = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CancelacionRetencion = 12,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoEmisor", Namespace="http://schemas.datacontract.org/2004/07/Cer.WsFactService.Request")]
    public enum TipoEmisor : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Direct = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Provider = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageResponse", Namespace="http://schemas.datacontract.org/2004/07/Cer.WsFactService.Response")]
    public partial class MessageResponse : object
    {
        
        private string CodeField;
        
        private string ErrorField;
        
        private bool HaveErrorField;
        
        private string MessageField;
        
        private string XmlBase64Field;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Error
        {
            get
            {
                return this.ErrorField;
            }
            set
            {
                this.ErrorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HaveError
        {
            get
            {
                return this.HaveErrorField;
            }
            set
            {
                this.HaveErrorField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                this.MessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlBase64
        {
            get
            {
                return this.XmlBase64Field;
            }
            set
            {
                this.XmlBase64Field = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IWsFact")]
    public interface IWsFact
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWsFact/ProcessDocument", ReplyAction="http://tempuri.org/IWsFact/ProcessDocumentResponse")]
        System.Threading.Tasks.Task<ServiceReference1.MessageResponse> ProcessDocumentAsync(ServiceReference1.MessageRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface IWsFactChannel : ServiceReference1.IWsFact, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class WsFactClient : System.ServiceModel.ClientBase<ServiceReference1.IWsFact>, ServiceReference1.IWsFact
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WsFactClient() : 
                base(WsFactClient.GetDefaultBinding(), WsFactClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpsBinding_IWsFact.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsFactClient(EndpointConfiguration endpointConfiguration) : 
                base(WsFactClient.GetBindingForEndpoint(endpointConfiguration), WsFactClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsFactClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WsFactClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsFactClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WsFactClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WsFactClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.MessageResponse> ProcessDocumentAsync(ServiceReference1.MessageRequest request)
        {
            return base.Channel.ProcessDocumentAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IWsFact))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IWsFact))
            {
                return new System.ServiceModel.EndpointAddress("https://int.certifac.mx:9006/Cer.WsFactService.WsFact.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return WsFactClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpsBinding_IWsFact);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return WsFactClient.GetEndpointAddress(EndpointConfiguration.BasicHttpsBinding_IWsFact);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpsBinding_IWsFact,
        }
    }
}
