﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_elso_host.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Eloado", Namespace="http://schemas.datacontract.org/2004/07/WCF_elso_server")]
    [System.SerializableAttribute()]
    public partial class Eloado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int eloadoAzField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string eloadoNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int eloadoAz {
            get {
                return this.eloadoAzField;
            }
            set {
                if ((this.eloadoAzField.Equals(value) != true)) {
                    this.eloadoAzField = value;
                    this.RaisePropertyChanged("eloadoAz");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string eloadoName {
            get {
                return this.eloadoNameField;
            }
            set {
                if ((object.ReferenceEquals(this.eloadoNameField, value) != true)) {
                    this.eloadoNameField = value;
                    this.RaisePropertyChanged("eloadoName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEloado", ReplyAction="http://tempuri.org/IService1/GetEloadoResponse")]
        WCF_elso_host.ServiceReference1.Eloado GetEloado();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEloado", ReplyAction="http://tempuri.org/IService1/GetEloadoResponse")]
        System.Threading.Tasks.Task<WCF_elso_host.ServiceReference1.Eloado> GetEloadoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WCF_elso_host.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WCF_elso_host.ServiceReference1.IService1>, WCF_elso_host.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCF_elso_host.ServiceReference1.Eloado GetEloado() {
            return base.Channel.GetEloado();
        }
        
        public System.Threading.Tasks.Task<WCF_elso_host.ServiceReference1.Eloado> GetEloadoAsync() {
            return base.Channel.GetEloadoAsync();
        }
    }
}
