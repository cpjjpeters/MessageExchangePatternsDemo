﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormsClient.MathServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MyNumbers", Namespace="http://schemas.datacontract.org/2004/07/MathServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class MyNumbers : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Number1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Number2Field;
        
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
        public int Number1 {
            get {
                return this.Number1Field;
            }
            set {
                if ((this.Number1Field.Equals(value) != true)) {
                    this.Number1Field = value;
                    this.RaisePropertyChanged("Number1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number2 {
            get {
                return this.Number2Field;
            }
            set {
                if ((this.Number2Field.Equals(value) != true)) {
                    this.Number2Field = value;
                    this.RaisePropertyChanged("Number2");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MathServiceReference.IMathService", CallbackContract=typeof(WinFormsClient.MathServiceReference.IMathServiceCallback))]
    public interface IMathService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        int Add(WinFormsClient.MathServiceReference.MyNumbers obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Add", ReplyAction="http://tempuri.org/IMathService/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(WinFormsClient.MathServiceReference.MyNumbers obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Subtract", ReplyAction="http://tempuri.org/IMathService/SubtractResponse")]
        int Subtract(WinFormsClient.MathServiceReference.MyNumbers obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathService/Subtract", ReplyAction="http://tempuri.org/IMathService/SubtractResponse")]
        System.Threading.Tasks.Task<int> SubtractAsync(WinFormsClient.MathServiceReference.MyNumbers obj);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMathService/SignIn")]
        void SignIn(string UserName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMathService/SignIn")]
        System.Threading.Tasks.Task SignInAsync(string UserName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMathService/SignOut")]
        void SignOut(string UserName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMathService/SignOut")]
        System.Threading.Tasks.Task SignOutAsync(string UserName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMathService/StartPrintingLogFiles")]
        void StartPrintingLogFiles(string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMathService/StartPrintingLogFiles")]
        System.Threading.Tasks.Task StartPrintingLogFilesAsync(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMathService/NotifyClientWhenPrintingIsDone")]
        void NotifyClientWhenPrintingIsDone(string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathServiceChannel : WinFormsClient.MathServiceReference.IMathService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathServiceClient : System.ServiceModel.DuplexClientBase<WinFormsClient.MathServiceReference.IMathService>, WinFormsClient.MathServiceReference.IMathService {
        
        public MathServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MathServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MathServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MathServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int Add(WinFormsClient.MathServiceReference.MyNumbers obj) {
            return base.Channel.Add(obj);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(WinFormsClient.MathServiceReference.MyNumbers obj) {
            return base.Channel.AddAsync(obj);
        }
        
        public int Subtract(WinFormsClient.MathServiceReference.MyNumbers obj) {
            return base.Channel.Subtract(obj);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(WinFormsClient.MathServiceReference.MyNumbers obj) {
            return base.Channel.SubtractAsync(obj);
        }
        
        public void SignIn(string UserName) {
            base.Channel.SignIn(UserName);
        }
        
        public System.Threading.Tasks.Task SignInAsync(string UserName) {
            return base.Channel.SignInAsync(UserName);
        }
        
        public void SignOut(string UserName) {
            base.Channel.SignOut(UserName);
        }
        
        public System.Threading.Tasks.Task SignOutAsync(string UserName) {
            return base.Channel.SignOutAsync(UserName);
        }
        
        public void StartPrintingLogFiles(string message) {
            base.Channel.StartPrintingLogFiles(message);
        }
        
        public System.Threading.Tasks.Task StartPrintingLogFilesAsync(string message) {
            return base.Channel.StartPrintingLogFilesAsync(message);
        }
    }
}
