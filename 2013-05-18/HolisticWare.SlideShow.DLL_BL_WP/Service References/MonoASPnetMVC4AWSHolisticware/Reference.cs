﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://holisticware.net/", ConfigurationName="MonoASPnetMVC4AWSHolisticware.WebServiceFileUploaderSoap")]
    public interface WebServiceFileUploaderSoap {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://holisticware.net/UploadFile", ReplyAction="*")]
        System.IAsyncResult BeginUploadFile(HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileRequest request, System.AsyncCallback callback, object asyncState);
        
        HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileResponse EndUploadFile(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadFile", Namespace="http://holisticware.net/", Order=0)]
        public HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileRequestBody Body;
        
        public UploadFileRequest() {
        }
        
        public UploadFileRequest(HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://holisticware.net/")]
    public partial class UploadFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] f;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fileName;
        
        public UploadFileRequestBody() {
        }
        
        public UploadFileRequestBody(byte[] f, string fileName) {
            this.f = f;
            this.fileName = fileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadFileResponse", Namespace="http://holisticware.net/", Order=0)]
        public HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileResponseBody Body;
        
        public UploadFileResponse() {
        }
        
        public UploadFileResponse(HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://holisticware.net/")]
    public partial class UploadFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UploadFileResult;
        
        public UploadFileResponseBody() {
        }
        
        public UploadFileResponseBody(string UploadFileResult) {
            this.UploadFileResult = UploadFileResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceFileUploaderSoapChannel : HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.WebServiceFileUploaderSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UploadFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UploadFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceFileUploaderSoapClient : System.ServiceModel.ClientBase<HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.WebServiceFileUploaderSoap>, HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.WebServiceFileUploaderSoap {
        
        private BeginOperationDelegate onBeginUploadFileDelegate;
        
        private EndOperationDelegate onEndUploadFileDelegate;
        
        private System.Threading.SendOrPostCallback onUploadFileCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public WebServiceFileUploaderSoapClient() {
        }
        
        public WebServiceFileUploaderSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceFileUploaderSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFileUploaderSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFileUploaderSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<UploadFileCompletedEventArgs> UploadFileCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.WebServiceFileUploaderSoap.BeginUploadFile(HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUploadFile(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginUploadFile(byte[] f, string fileName, System.AsyncCallback callback, object asyncState) {
            HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileRequest inValue = new HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileRequest();
            inValue.Body = new HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileRequestBody();
            inValue.Body.f = f;
            inValue.Body.fileName = fileName;
            return ((HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.WebServiceFileUploaderSoap)(this)).BeginUploadFile(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileResponse HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.WebServiceFileUploaderSoap.EndUploadFile(System.IAsyncResult result) {
            return base.Channel.EndUploadFile(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private string EndUploadFile(System.IAsyncResult result) {
            HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileResponse retVal = ((HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.WebServiceFileUploaderSoap)(this)).EndUploadFile(result);
            return retVal.Body.UploadFileResult;
        }
        
        private System.IAsyncResult OnBeginUploadFile(object[] inValues, System.AsyncCallback callback, object asyncState) {
            byte[] f = ((byte[])(inValues[0]));
            string fileName = ((string)(inValues[1]));
            return this.BeginUploadFile(f, fileName, callback, asyncState);
        }
        
        private object[] OnEndUploadFile(System.IAsyncResult result) {
            string retVal = this.EndUploadFile(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUploadFileCompleted(object state) {
            if ((this.UploadFileCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UploadFileCompleted(this, new UploadFileCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UploadFileAsync(byte[] f, string fileName) {
            this.UploadFileAsync(f, fileName, null);
        }
        
        public void UploadFileAsync(byte[] f, string fileName, object userState) {
            if ((this.onBeginUploadFileDelegate == null)) {
                this.onBeginUploadFileDelegate = new BeginOperationDelegate(this.OnBeginUploadFile);
            }
            if ((this.onEndUploadFileDelegate == null)) {
                this.onEndUploadFileDelegate = new EndOperationDelegate(this.OnEndUploadFile);
            }
            if ((this.onUploadFileCompletedDelegate == null)) {
                this.onUploadFileCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUploadFileCompleted);
            }
            base.InvokeAsync(this.onBeginUploadFileDelegate, new object[] {
                        f,
                        fileName}, this.onEndUploadFileDelegate, this.onUploadFileCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.WebServiceFileUploaderSoap CreateChannel() {
            return new WebServiceFileUploaderSoapClientChannel(this);
        }
        
        private class WebServiceFileUploaderSoapClientChannel : ChannelBase<HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.WebServiceFileUploaderSoap>, HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.WebServiceFileUploaderSoap {
            
            public WebServiceFileUploaderSoapClientChannel(System.ServiceModel.ClientBase<HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.WebServiceFileUploaderSoap> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginUploadFile(HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("UploadFile", _args, callback, asyncState);
                return _result;
            }
            
            public HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileResponse EndUploadFile(System.IAsyncResult result) {
                object[] _args = new object[0];
                HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileResponse _result = ((HolisticWare.SlideShow.BusinessLogic.MonoASPnetMVC4AWSHolisticware.UploadFileResponse)(base.EndInvoke("UploadFile", _args, result)));
                return _result;
            }
        }
    }
}
