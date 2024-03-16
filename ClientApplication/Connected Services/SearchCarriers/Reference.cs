﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApplication.SearchCarriers
{
    using System.Runtime.Serialization;
    using System;
    using System.Threading.Tasks;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Carrier", Namespace = "http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Carrier : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string iataField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                if ((object.ReferenceEquals(this.nameField, value) != true))
                {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public string iata
        {
            get
            {
                return this.iataField;
            }
            set
            {
                if ((object.ReferenceEquals(this.iataField, value) != true))
                {
                    this.iataField = value;
                    this.RaisePropertyChanged("iata");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "SearchCarriers.AirCarriersSearchServiceSoap")]
    public interface AirCarriersSearchServiceSoap
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/SearchCarriers", ReplyAction = "*")]
        ClientApplication.SearchCarriers.SearchCarriersResponse SearchCarriers(ClientApplication.SearchCarriers.SearchCarriersRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/SearchCarriers", ReplyAction = "*")]
        System.Threading.Tasks.Task<ClientApplication.SearchCarriers.SearchCarriersResponse> SearchCarriersAsync(ClientApplication.SearchCarriers.SearchCarriersRequest request);
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class SearchCarriersRequest
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "SearchCarriers", Namespace = "http://tempuri.org/", Order = 0)]
        public ClientApplication.SearchCarriers.SearchCarriersRequestBody Body;

        public SearchCarriersRequest()
        {
        }

        public SearchCarriersRequest(ClientApplication.SearchCarriers.SearchCarriersRequestBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://tempuri.org/")]
    public partial class SearchCarriersRequestBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string key;

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public string value;

        public SearchCarriersRequestBody()
        {
        }

        public SearchCarriersRequestBody(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class SearchCarriersResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Name = "SearchCarriersResponse", Namespace = "http://tempuri.org/", Order = 0)]
        public ClientApplication.SearchCarriers.SearchCarriersResponseBody Body;

        public SearchCarriersResponse()
        {
        }

        public SearchCarriersResponse(ClientApplication.SearchCarriers.SearchCarriersResponseBody Body)
        {
            this.Body = Body;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://tempuri.org/")]
    public partial class SearchCarriersResponseBody
    {

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public ClientApplication.SearchCarriers.Carrier[] SearchCarriersResult;

        public SearchCarriersResponseBody()
        {
        }

        public SearchCarriersResponseBody(ClientApplication.SearchCarriers.Carrier[] SearchCarriersResult)
        {
            this.SearchCarriersResult = SearchCarriersResult;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AirCarriersSearchServiceSoapChannel : ClientApplication.SearchCarriers.AirCarriersSearchServiceSoap, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AirCarriersSearchServiceSoapClient : System.ServiceModel.ClientBase<ClientApplication.SearchCarriers.AirCarriersSearchServiceSoap>, ClientApplication.SearchCarriers.AirCarriersSearchServiceSoap
    {

        public AirCarriersSearchServiceSoapClient()
        {
        }

        public AirCarriersSearchServiceSoapClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public AirCarriersSearchServiceSoapClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public AirCarriersSearchServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public AirCarriersSearchServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public ClientApplication.SearchCarriers.SearchCarriersResponse SearchCarriers(ClientApplication.SearchCarriers.SearchCarriersRequest request)
        {
            return base.Channel.SearchCarriers(request);
        }

        public System.Threading.Tasks.Task<ClientApplication.SearchCarriers.SearchCarriersResponse> SearchCarriersAsync(string key, ClientApplication.SearchCarriers.SearchCarriersRequest request)
        {
            return base.Channel.SearchCarriersAsync(request);
        }

        public async Task<SearchCarriersResponse> SearchCarriersAsync(SearchCarriersRequest request)
        {
            return await base.Channel.SearchCarriersAsync(request);
        }

    }
}