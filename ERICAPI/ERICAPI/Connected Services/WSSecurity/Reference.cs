﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSSecurity
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSSecurity.WSSecuritySoap")]
    public interface WSSecuritySoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSEncrptionForMRO", ReplyAction="*")]
        System.Threading.Tasks.Task<WSSecurity.WSEncrptionForMROResponse> WSEncrptionForMROAsync(WSSecurity.WSEncrptionForMRORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSDecrptionForMRO", ReplyAction="*")]
        System.Threading.Tasks.Task<WSSecurity.WSDecrptionForMROResponse> WSDecrptionForMROAsync(WSSecurity.WSDecrptionForMRORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSEncrptionForOuterRedirection", ReplyAction="*")]
        System.Threading.Tasks.Task<WSSecurity.WSEncrptionForOuterRedirectionResponse> WSEncrptionForOuterRedirectionAsync(WSSecurity.WSEncrptionForOuterRedirectionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/WSDecrptionForOuterRedirection", ReplyAction="*")]
        System.Threading.Tasks.Task<WSSecurity.WSDecrptionForOuterRedirectionResponse> WSDecrptionForOuterRedirectionAsync(WSSecurity.WSDecrptionForOuterRedirectionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WSEncrptionForMRORequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSEncrptionForMRO", Namespace="http://tempuri.org/", Order=0)]
        public WSSecurity.WSEncrptionForMRORequestBody Body;
        
        public WSEncrptionForMRORequest()
        {
        }
        
        public WSEncrptionForMRORequest(WSSecurity.WSEncrptionForMRORequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WSEncrptionForMRORequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int varDBType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strDBCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string InputString;
        
        public WSEncrptionForMRORequestBody()
        {
        }
        
        public WSEncrptionForMRORequestBody(int varDBType, string strDBCode, string InputString)
        {
            this.varDBType = varDBType;
            this.strDBCode = strDBCode;
            this.InputString = InputString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WSEncrptionForMROResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSEncrptionForMROResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSSecurity.WSEncrptionForMROResponseBody Body;
        
        public WSEncrptionForMROResponse()
        {
        }
        
        public WSEncrptionForMROResponse(WSSecurity.WSEncrptionForMROResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WSEncrptionForMROResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string WSEncrptionForMROResult;
        
        public WSEncrptionForMROResponseBody()
        {
        }
        
        public WSEncrptionForMROResponseBody(string WSEncrptionForMROResult)
        {
            this.WSEncrptionForMROResult = WSEncrptionForMROResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WSDecrptionForMRORequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSDecrptionForMRO", Namespace="http://tempuri.org/", Order=0)]
        public WSSecurity.WSDecrptionForMRORequestBody Body;
        
        public WSDecrptionForMRORequest()
        {
        }
        
        public WSDecrptionForMRORequest(WSSecurity.WSDecrptionForMRORequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WSDecrptionForMRORequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int varDBType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strDBCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string InputString;
        
        public WSDecrptionForMRORequestBody()
        {
        }
        
        public WSDecrptionForMRORequestBody(int varDBType, string strDBCode, string InputString)
        {
            this.varDBType = varDBType;
            this.strDBCode = strDBCode;
            this.InputString = InputString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WSDecrptionForMROResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSDecrptionForMROResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSSecurity.WSDecrptionForMROResponseBody Body;
        
        public WSDecrptionForMROResponse()
        {
        }
        
        public WSDecrptionForMROResponse(WSSecurity.WSDecrptionForMROResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WSDecrptionForMROResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string WSDecrptionForMROResult;
        
        public WSDecrptionForMROResponseBody()
        {
        }
        
        public WSDecrptionForMROResponseBody(string WSDecrptionForMROResult)
        {
            this.WSDecrptionForMROResult = WSDecrptionForMROResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WSEncrptionForOuterRedirectionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSEncrptionForOuterRedirection", Namespace="http://tempuri.org/", Order=0)]
        public WSSecurity.WSEncrptionForOuterRedirectionRequestBody Body;
        
        public WSEncrptionForOuterRedirectionRequest()
        {
        }
        
        public WSEncrptionForOuterRedirectionRequest(WSSecurity.WSEncrptionForOuterRedirectionRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WSEncrptionForOuterRedirectionRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Syscod;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string strComcod;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string strEmplid;
        
        public WSEncrptionForOuterRedirectionRequestBody()
        {
        }
        
        public WSEncrptionForOuterRedirectionRequestBody(string Syscod, string strComcod, string strEmplid)
        {
            this.Syscod = Syscod;
            this.strComcod = strComcod;
            this.strEmplid = strEmplid;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WSEncrptionForOuterRedirectionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSEncrptionForOuterRedirectionResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSSecurity.WSEncrptionForOuterRedirectionResponseBody Body;
        
        public WSEncrptionForOuterRedirectionResponse()
        {
        }
        
        public WSEncrptionForOuterRedirectionResponse(WSSecurity.WSEncrptionForOuterRedirectionResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WSEncrptionForOuterRedirectionResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string WSEncrptionForOuterRedirectionResult;
        
        public WSEncrptionForOuterRedirectionResponseBody()
        {
        }
        
        public WSEncrptionForOuterRedirectionResponseBody(string WSEncrptionForOuterRedirectionResult)
        {
            this.WSEncrptionForOuterRedirectionResult = WSEncrptionForOuterRedirectionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WSDecrptionForOuterRedirectionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSDecrptionForOuterRedirection", Namespace="http://tempuri.org/", Order=0)]
        public WSSecurity.WSDecrptionForOuterRedirectionRequestBody Body;
        
        public WSDecrptionForOuterRedirectionRequest()
        {
        }
        
        public WSDecrptionForOuterRedirectionRequest(WSSecurity.WSDecrptionForOuterRedirectionRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WSDecrptionForOuterRedirectionRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InputString;
        
        public WSDecrptionForOuterRedirectionRequestBody()
        {
        }
        
        public WSDecrptionForOuterRedirectionRequestBody(string InputString)
        {
            this.InputString = InputString;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class WSDecrptionForOuterRedirectionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSDecrptionForOuterRedirectionResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSSecurity.WSDecrptionForOuterRedirectionResponseBody Body;
        
        public WSDecrptionForOuterRedirectionResponse()
        {
        }
        
        public WSDecrptionForOuterRedirectionResponse(WSSecurity.WSDecrptionForOuterRedirectionResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class WSDecrptionForOuterRedirectionResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string WSDecrptionForOuterRedirectionResult;
        
        public WSDecrptionForOuterRedirectionResponseBody()
        {
        }
        
        public WSDecrptionForOuterRedirectionResponseBody(string WSDecrptionForOuterRedirectionResult)
        {
            this.WSDecrptionForOuterRedirectionResult = WSDecrptionForOuterRedirectionResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    public interface WSSecuritySoapChannel : WSSecurity.WSSecuritySoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    public partial class WSSecuritySoapClient : System.ServiceModel.ClientBase<WSSecurity.WSSecuritySoap>, WSSecurity.WSSecuritySoap
    {
        
        /// <summary>
        /// 实现此分部方法，配置服务终结点。
        /// </summary>
        /// <param name="serviceEndpoint">要配置的终结点</param>
        /// <param name="clientCredentials">客户端凭据</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WSSecuritySoapClient(EndpointConfiguration endpointConfiguration) : 
                base(WSSecuritySoapClient.GetBindingForEndpoint(endpointConfiguration), WSSecuritySoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSSecuritySoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WSSecuritySoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSSecuritySoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WSSecuritySoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WSSecuritySoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSSecurity.WSEncrptionForMROResponse> WSSecurity.WSSecuritySoap.WSEncrptionForMROAsync(WSSecurity.WSEncrptionForMRORequest request)
        {
            return base.Channel.WSEncrptionForMROAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSSecurity.WSEncrptionForMROResponse> WSEncrptionForMROAsync(int varDBType, string strDBCode, string InputString)
        {
            WSSecurity.WSEncrptionForMRORequest inValue = new WSSecurity.WSEncrptionForMRORequest();
            inValue.Body = new WSSecurity.WSEncrptionForMRORequestBody();
            inValue.Body.varDBType = varDBType;
            inValue.Body.strDBCode = strDBCode;
            inValue.Body.InputString = InputString;
            return ((WSSecurity.WSSecuritySoap)(this)).WSEncrptionForMROAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSSecurity.WSDecrptionForMROResponse> WSSecurity.WSSecuritySoap.WSDecrptionForMROAsync(WSSecurity.WSDecrptionForMRORequest request)
        {
            return base.Channel.WSDecrptionForMROAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSSecurity.WSDecrptionForMROResponse> WSDecrptionForMROAsync(int varDBType, string strDBCode, string InputString)
        {
            WSSecurity.WSDecrptionForMRORequest inValue = new WSSecurity.WSDecrptionForMRORequest();
            inValue.Body = new WSSecurity.WSDecrptionForMRORequestBody();
            inValue.Body.varDBType = varDBType;
            inValue.Body.strDBCode = strDBCode;
            inValue.Body.InputString = InputString;
            return ((WSSecurity.WSSecuritySoap)(this)).WSDecrptionForMROAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSSecurity.WSEncrptionForOuterRedirectionResponse> WSSecurity.WSSecuritySoap.WSEncrptionForOuterRedirectionAsync(WSSecurity.WSEncrptionForOuterRedirectionRequest request)
        {
            return base.Channel.WSEncrptionForOuterRedirectionAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSSecurity.WSEncrptionForOuterRedirectionResponse> WSEncrptionForOuterRedirectionAsync(string Syscod, string strComcod, string strEmplid)
        {
            WSSecurity.WSEncrptionForOuterRedirectionRequest inValue = new WSSecurity.WSEncrptionForOuterRedirectionRequest();
            inValue.Body = new WSSecurity.WSEncrptionForOuterRedirectionRequestBody();
            inValue.Body.Syscod = Syscod;
            inValue.Body.strComcod = strComcod;
            inValue.Body.strEmplid = strEmplid;
            return ((WSSecurity.WSSecuritySoap)(this)).WSEncrptionForOuterRedirectionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSSecurity.WSDecrptionForOuterRedirectionResponse> WSSecurity.WSSecuritySoap.WSDecrptionForOuterRedirectionAsync(WSSecurity.WSDecrptionForOuterRedirectionRequest request)
        {
            return base.Channel.WSDecrptionForOuterRedirectionAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSSecurity.WSDecrptionForOuterRedirectionResponse> WSDecrptionForOuterRedirectionAsync(string InputString)
        {
            WSSecurity.WSDecrptionForOuterRedirectionRequest inValue = new WSSecurity.WSDecrptionForOuterRedirectionRequest();
            inValue.Body = new WSSecurity.WSDecrptionForOuterRedirectionRequestBody();
            inValue.Body.InputString = InputString;
            return ((WSSecurity.WSSecuritySoap)(this)).WSDecrptionForOuterRedirectionAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.WSSecuritySoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WSSecuritySoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WSSecuritySoap))
            {
                return new System.ServiceModel.EndpointAddress("http://10.243.19.83/INTRA2008/BPM/ADMIN/SECURITY/WSSecurity.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.WSSecuritySoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://10.243.19.83/INTRA2008/BPM/ADMIN/SECURITY/WSSecurity.asmx");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            WSSecuritySoap,
            
            WSSecuritySoap12,
        }
    }
}
