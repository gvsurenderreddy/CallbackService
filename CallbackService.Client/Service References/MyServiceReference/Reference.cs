﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CallbackService.Client.MyServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyServiceReference.IMyService", CallbackContract=typeof(CallbackService.Client.MyServiceReference.IMyServiceCallback))]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/OpenSession", ReplyAction="http://tempuri.org/IMyService/OpenSessionResponse")]
        void OpenSession();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/OnCallback", ReplyAction="http://tempuri.org/IMyService/OnCallbackResponse")]
        void OnCallback();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : CallbackService.Client.MyServiceReference.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.DuplexClientBase<CallbackService.Client.MyServiceReference.IMyService>, CallbackService.Client.MyServiceReference.IMyService {
        
        public MyServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MyServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MyServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void OpenSession() {
            base.Channel.OpenSession();
        }
    }
}
