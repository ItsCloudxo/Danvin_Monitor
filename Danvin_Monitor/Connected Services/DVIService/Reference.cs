//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Danvin_Monitor.DVIService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://dvimonitor.pilotdrift.dk/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dvimonitor.pilotdrift.dk/", ConfigurationName="DVIService.monitorSoap")]
    public interface monitorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockTemp", ReplyAction="*")]
        double StockTemp();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<double> StockTempAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockHumidity", ReplyAction="*")]
        double StockHumidity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockHumidity", ReplyAction="*")]
        System.Threading.Tasks.Task<double> StockHumidityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/OutdoorTemp", ReplyAction="*")]
        double OutdoorTemp();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/OutdoorTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<double> OutdoorTempAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/OutdoorHumidity", ReplyAction="*")]
        double OutdoorHumidity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/OutdoorHumidity", ReplyAction="*")]
        System.Threading.Tasks.Task<double> OutdoorHumidityAsync();
        
        // CODEGEN: Generating message contract since element name StockItemsUnderMinResult from namespace http://dvimonitor.pilotdrift.dk/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockItemsUnderMin", ReplyAction="*")]
        Danvin_Monitor.DVIService.StockItemsUnderMinResponse StockItemsUnderMin(Danvin_Monitor.DVIService.StockItemsUnderMinRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockItemsUnderMin", ReplyAction="*")]
        System.Threading.Tasks.Task<Danvin_Monitor.DVIService.StockItemsUnderMinResponse> StockItemsUnderMinAsync(Danvin_Monitor.DVIService.StockItemsUnderMinRequest request);
        
        // CODEGEN: Generating message contract since element name StockItemsOverMaxResult from namespace http://dvimonitor.pilotdrift.dk/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockItemsOverMax", ReplyAction="*")]
        Danvin_Monitor.DVIService.StockItemsOverMaxResponse StockItemsOverMax(Danvin_Monitor.DVIService.StockItemsOverMaxRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockItemsOverMax", ReplyAction="*")]
        System.Threading.Tasks.Task<Danvin_Monitor.DVIService.StockItemsOverMaxResponse> StockItemsOverMaxAsync(Danvin_Monitor.DVIService.StockItemsOverMaxRequest request);
        
        // CODEGEN: Generating message contract since element name StockItemsMostSoldResult from namespace http://dvimonitor.pilotdrift.dk/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockItemsMostSold", ReplyAction="*")]
        Danvin_Monitor.DVIService.StockItemsMostSoldResponse StockItemsMostSold(Danvin_Monitor.DVIService.StockItemsMostSoldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.pilotdrift.dk/StockItemsMostSold", ReplyAction="*")]
        System.Threading.Tasks.Task<Danvin_Monitor.DVIService.StockItemsMostSoldResponse> StockItemsMostSoldAsync(Danvin_Monitor.DVIService.StockItemsMostSoldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsUnderMinRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsUnderMin", Namespace="http://dvimonitor.pilotdrift.dk/", Order=0)]
        public Danvin_Monitor.DVIService.StockItemsUnderMinRequestBody Body;
        
        public StockItemsUnderMinRequest() {
        }
        
        public StockItemsUnderMinRequest(Danvin_Monitor.DVIService.StockItemsUnderMinRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsUnderMinRequestBody {
        
        public StockItemsUnderMinRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsUnderMinResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsUnderMinResponse", Namespace="http://dvimonitor.pilotdrift.dk/", Order=0)]
        public Danvin_Monitor.DVIService.StockItemsUnderMinResponseBody Body;
        
        public StockItemsUnderMinResponse() {
        }
        
        public StockItemsUnderMinResponse(Danvin_Monitor.DVIService.StockItemsUnderMinResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.pilotdrift.dk/")]
    public partial class StockItemsUnderMinResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Danvin_Monitor.DVIService.ArrayOfString StockItemsUnderMinResult;
        
        public StockItemsUnderMinResponseBody() {
        }
        
        public StockItemsUnderMinResponseBody(Danvin_Monitor.DVIService.ArrayOfString StockItemsUnderMinResult) {
            this.StockItemsUnderMinResult = StockItemsUnderMinResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsOverMaxRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsOverMax", Namespace="http://dvimonitor.pilotdrift.dk/", Order=0)]
        public Danvin_Monitor.DVIService.StockItemsOverMaxRequestBody Body;
        
        public StockItemsOverMaxRequest() {
        }
        
        public StockItemsOverMaxRequest(Danvin_Monitor.DVIService.StockItemsOverMaxRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsOverMaxRequestBody {
        
        public StockItemsOverMaxRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsOverMaxResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsOverMaxResponse", Namespace="http://dvimonitor.pilotdrift.dk/", Order=0)]
        public Danvin_Monitor.DVIService.StockItemsOverMaxResponseBody Body;
        
        public StockItemsOverMaxResponse() {
        }
        
        public StockItemsOverMaxResponse(Danvin_Monitor.DVIService.StockItemsOverMaxResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.pilotdrift.dk/")]
    public partial class StockItemsOverMaxResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Danvin_Monitor.DVIService.ArrayOfString StockItemsOverMaxResult;
        
        public StockItemsOverMaxResponseBody() {
        }
        
        public StockItemsOverMaxResponseBody(Danvin_Monitor.DVIService.ArrayOfString StockItemsOverMaxResult) {
            this.StockItemsOverMaxResult = StockItemsOverMaxResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsMostSoldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsMostSold", Namespace="http://dvimonitor.pilotdrift.dk/", Order=0)]
        public Danvin_Monitor.DVIService.StockItemsMostSoldRequestBody Body;
        
        public StockItemsMostSoldRequest() {
        }
        
        public StockItemsMostSoldRequest(Danvin_Monitor.DVIService.StockItemsMostSoldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsMostSoldRequestBody {
        
        public StockItemsMostSoldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsMostSoldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsMostSoldResponse", Namespace="http://dvimonitor.pilotdrift.dk/", Order=0)]
        public Danvin_Monitor.DVIService.StockItemsMostSoldResponseBody Body;
        
        public StockItemsMostSoldResponse() {
        }
        
        public StockItemsMostSoldResponse(Danvin_Monitor.DVIService.StockItemsMostSoldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.pilotdrift.dk/")]
    public partial class StockItemsMostSoldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Danvin_Monitor.DVIService.ArrayOfString StockItemsMostSoldResult;
        
        public StockItemsMostSoldResponseBody() {
        }
        
        public StockItemsMostSoldResponseBody(Danvin_Monitor.DVIService.ArrayOfString StockItemsMostSoldResult) {
            this.StockItemsMostSoldResult = StockItemsMostSoldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface monitorSoapChannel : Danvin_Monitor.DVIService.monitorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class monitorSoapClient : System.ServiceModel.ClientBase<Danvin_Monitor.DVIService.monitorSoap>, Danvin_Monitor.DVIService.monitorSoap {
        
        public monitorSoapClient() {
        }
        
        public monitorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public monitorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public monitorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public monitorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double StockTemp() {
            return base.Channel.StockTemp();
        }
        
        public System.Threading.Tasks.Task<double> StockTempAsync() {
            return base.Channel.StockTempAsync();
        }
        
        public double StockHumidity() {
            return base.Channel.StockHumidity();
        }
        
        public System.Threading.Tasks.Task<double> StockHumidityAsync() {
            return base.Channel.StockHumidityAsync();
        }
        
        public double OutdoorTemp() {
            return base.Channel.OutdoorTemp();
        }
        
        public System.Threading.Tasks.Task<double> OutdoorTempAsync() {
            return base.Channel.OutdoorTempAsync();
        }
        
        public double OutdoorHumidity() {
            return base.Channel.OutdoorHumidity();
        }
        
        public System.Threading.Tasks.Task<double> OutdoorHumidityAsync() {
            return base.Channel.OutdoorHumidityAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Danvin_Monitor.DVIService.StockItemsUnderMinResponse Danvin_Monitor.DVIService.monitorSoap.StockItemsUnderMin(Danvin_Monitor.DVIService.StockItemsUnderMinRequest request) {
            return base.Channel.StockItemsUnderMin(request);
        }
        
        public Danvin_Monitor.DVIService.ArrayOfString StockItemsUnderMin() {
            Danvin_Monitor.DVIService.StockItemsUnderMinRequest inValue = new Danvin_Monitor.DVIService.StockItemsUnderMinRequest();
            inValue.Body = new Danvin_Monitor.DVIService.StockItemsUnderMinRequestBody();
            Danvin_Monitor.DVIService.StockItemsUnderMinResponse retVal = ((Danvin_Monitor.DVIService.monitorSoap)(this)).StockItemsUnderMin(inValue);
            return retVal.Body.StockItemsUnderMinResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Danvin_Monitor.DVIService.StockItemsUnderMinResponse> Danvin_Monitor.DVIService.monitorSoap.StockItemsUnderMinAsync(Danvin_Monitor.DVIService.StockItemsUnderMinRequest request) {
            return base.Channel.StockItemsUnderMinAsync(request);
        }
        
        public System.Threading.Tasks.Task<Danvin_Monitor.DVIService.StockItemsUnderMinResponse> StockItemsUnderMinAsync() {
            Danvin_Monitor.DVIService.StockItemsUnderMinRequest inValue = new Danvin_Monitor.DVIService.StockItemsUnderMinRequest();
            inValue.Body = new Danvin_Monitor.DVIService.StockItemsUnderMinRequestBody();
            return ((Danvin_Monitor.DVIService.monitorSoap)(this)).StockItemsUnderMinAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Danvin_Monitor.DVIService.StockItemsOverMaxResponse Danvin_Monitor.DVIService.monitorSoap.StockItemsOverMax(Danvin_Monitor.DVIService.StockItemsOverMaxRequest request) {
            return base.Channel.StockItemsOverMax(request);
        }
        
        public Danvin_Monitor.DVIService.ArrayOfString StockItemsOverMax() {
            Danvin_Monitor.DVIService.StockItemsOverMaxRequest inValue = new Danvin_Monitor.DVIService.StockItemsOverMaxRequest();
            inValue.Body = new Danvin_Monitor.DVIService.StockItemsOverMaxRequestBody();
            Danvin_Monitor.DVIService.StockItemsOverMaxResponse retVal = ((Danvin_Monitor.DVIService.monitorSoap)(this)).StockItemsOverMax(inValue);
            return retVal.Body.StockItemsOverMaxResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Danvin_Monitor.DVIService.StockItemsOverMaxResponse> Danvin_Monitor.DVIService.monitorSoap.StockItemsOverMaxAsync(Danvin_Monitor.DVIService.StockItemsOverMaxRequest request) {
            return base.Channel.StockItemsOverMaxAsync(request);
        }
        
        public System.Threading.Tasks.Task<Danvin_Monitor.DVIService.StockItemsOverMaxResponse> StockItemsOverMaxAsync() {
            Danvin_Monitor.DVIService.StockItemsOverMaxRequest inValue = new Danvin_Monitor.DVIService.StockItemsOverMaxRequest();
            inValue.Body = new Danvin_Monitor.DVIService.StockItemsOverMaxRequestBody();
            return ((Danvin_Monitor.DVIService.monitorSoap)(this)).StockItemsOverMaxAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Danvin_Monitor.DVIService.StockItemsMostSoldResponse Danvin_Monitor.DVIService.monitorSoap.StockItemsMostSold(Danvin_Monitor.DVIService.StockItemsMostSoldRequest request) {
            return base.Channel.StockItemsMostSold(request);
        }
        
        public Danvin_Monitor.DVIService.ArrayOfString StockItemsMostSold() {
            Danvin_Monitor.DVIService.StockItemsMostSoldRequest inValue = new Danvin_Monitor.DVIService.StockItemsMostSoldRequest();
            inValue.Body = new Danvin_Monitor.DVIService.StockItemsMostSoldRequestBody();
            Danvin_Monitor.DVIService.StockItemsMostSoldResponse retVal = ((Danvin_Monitor.DVIService.monitorSoap)(this)).StockItemsMostSold(inValue);
            return retVal.Body.StockItemsMostSoldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Danvin_Monitor.DVIService.StockItemsMostSoldResponse> Danvin_Monitor.DVIService.monitorSoap.StockItemsMostSoldAsync(Danvin_Monitor.DVIService.StockItemsMostSoldRequest request) {
            return base.Channel.StockItemsMostSoldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Danvin_Monitor.DVIService.StockItemsMostSoldResponse> StockItemsMostSoldAsync() {
            Danvin_Monitor.DVIService.StockItemsMostSoldRequest inValue = new Danvin_Monitor.DVIService.StockItemsMostSoldRequest();
            inValue.Body = new Danvin_Monitor.DVIService.StockItemsMostSoldRequestBody();
            return ((Danvin_Monitor.DVIService.monitorSoap)(this)).StockItemsMostSoldAsync(inValue);
        }
    }
}
