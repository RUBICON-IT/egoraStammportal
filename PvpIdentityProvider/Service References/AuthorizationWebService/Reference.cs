﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomAuthorization", Namespace="http://www.egora.at/Stammportal/AuthorizationWebService/1.0")]
    [System.SerializableAttribute()]
    public partial class CustomAuthorization : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.HttpHeader[] HttpHeadersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Xml.Linq.XElement SoapHeaderXmlFragmentField;
        
        private int TimeToLiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PvpVersionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.HttpHeader[] HttpHeaders {
            get {
                return this.HttpHeadersField;
            }
            set {
                if ((object.ReferenceEquals(this.HttpHeadersField, value) != true)) {
                    this.HttpHeadersField = value;
                    this.RaisePropertyChanged("HttpHeaders");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public System.Xml.Linq.XElement SoapHeaderXmlFragment {
            get {
                return this.SoapHeaderXmlFragmentField;
            }
            set {
                if ((object.ReferenceEquals(this.SoapHeaderXmlFragmentField, value) != true)) {
                    this.SoapHeaderXmlFragmentField = value;
                    this.RaisePropertyChanged("SoapHeaderXmlFragment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int TimeToLive {
            get {
                return this.TimeToLiveField;
            }
            set {
                if ((this.TimeToLiveField.Equals(value) != true)) {
                    this.TimeToLiveField = value;
                    this.RaisePropertyChanged("TimeToLive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string PvpVersion {
            get {
                return this.PvpVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.PvpVersionField, value) != true)) {
                    this.PvpVersionField = value;
                    this.RaisePropertyChanged("PvpVersion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HttpHeader", Namespace="http://www.egora.at/Stammportal/AuthorizationWebService/1.0")]
    [System.SerializableAttribute()]
    public partial class HttpHeader : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.egora.at/Stammportal/AuthorizationWebService/1.0", ConfigurationName="AuthorizationWebService.PvpAuthorizerSoap")]
    public interface PvpAuthorizerSoap {
        
        // CODEGEN: Generating message contract since element name rootUrl from namespace http://www.egora.at/Stammportal/AuthorizationWebService/1.0 is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.egora.at/Stammportal/AuthorizationWebService/1.0/GetAuthorization", ReplyAction="*")]
        Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.GetAuthorizationResponse GetAuthorization(Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.GetAuthorizationRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAuthorizationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAuthorization", Namespace="http://www.egora.at/Stammportal/AuthorizationWebService/1.0", Order=0)]
        public Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.GetAuthorizationRequestBody Body;
        
        public GetAuthorizationRequest() {
        }
        
        public GetAuthorizationRequest(Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.GetAuthorizationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.egora.at/Stammportal/AuthorizationWebService/1.0")]
    public partial class GetAuthorizationRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string rootUrl;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string userId;
        
        public GetAuthorizationRequestBody() {
        }
        
        public GetAuthorizationRequestBody(string rootUrl, string userId) {
            this.rootUrl = rootUrl;
            this.userId = userId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAuthorizationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAuthorizationResponse", Namespace="http://www.egora.at/Stammportal/AuthorizationWebService/1.0", Order=0)]
        public Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.GetAuthorizationResponseBody Body;
        
        public GetAuthorizationResponse() {
        }
        
        public GetAuthorizationResponse(Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.GetAuthorizationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.egora.at/Stammportal/AuthorizationWebService/1.0")]
    public partial class GetAuthorizationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.CustomAuthorization GetAuthorizationResult;
        
        public GetAuthorizationResponseBody() {
        }
        
        public GetAuthorizationResponseBody(Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.CustomAuthorization GetAuthorizationResult) {
            this.GetAuthorizationResult = GetAuthorizationResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PvpAuthorizerSoapChannel : Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.PvpAuthorizerSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PvpAuthorizerSoapClient : System.ServiceModel.ClientBase<Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.PvpAuthorizerSoap>, Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.PvpAuthorizerSoap {
        
        public PvpAuthorizerSoapClient() {
        }
        
        public PvpAuthorizerSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PvpAuthorizerSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PvpAuthorizerSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PvpAuthorizerSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.GetAuthorizationResponse Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.PvpAuthorizerSoap.GetAuthorization(Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.GetAuthorizationRequest request) {
            return base.Channel.GetAuthorization(request);
        }
        
        public Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.CustomAuthorization GetAuthorization(string rootUrl, string userId) {
            Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.GetAuthorizationRequest inValue = new Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.GetAuthorizationRequest();
            inValue.Body = new Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.GetAuthorizationRequestBody();
            inValue.Body.rootUrl = rootUrl;
            inValue.Body.userId = userId;
            Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.GetAuthorizationResponse retVal = ((Egora.Stammportal.PvpIdentityProvider.AuthorizationWebService.PvpAuthorizerSoap)(this)).GetAuthorization(inValue);
            return retVal.Body.GetAuthorizationResult;
        }
    }
}