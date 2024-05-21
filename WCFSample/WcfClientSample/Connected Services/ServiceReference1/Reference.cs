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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Rectangle", Namespace="WCFService.Standard")]
    public partial class Rectangle : object
    {
        
        private double HeightField;
        
        private double WidthField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double Height
        {
            get
            {
                return this.HeightField;
            }
            set
            {
                this.HeightField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public double Width
        {
            get
            {
                return this.WidthField;
            }
            set
            {
                this.WidthField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomServiceException", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
    public partial class CustomServiceException : object
    {
        
        private string MessageField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="WCFService.Standard", ConfigurationName="ServiceReference1.ShapeTransformation")]
    public interface ShapeTransformation
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="WCFService.Standard/ShapeTransformation/GetRectangle", ReplyAction="WCFService.Standard/ShapeTransformation/GetRectangleResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReference1.CustomServiceException), Action="WCFService.Standard/ShapeTransformation/GetRectangleCustomServiceExceptionFault", Name="CustomServiceException", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        ServiceReference1.Rectangle GetRectangle(double width, double height);
        
        [System.ServiceModel.OperationContractAttribute(Action="WCFService.Standard/ShapeTransformation/GetRectangle", ReplyAction="WCFService.Standard/ShapeTransformation/GetRectangleResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Rectangle> GetRectangleAsync(double width, double height);
        
        [System.ServiceModel.OperationContractAttribute(Action="WCFService.Standard/ShapeTransformation/ChangeSize", ReplyAction="WCFService.Standard/ShapeTransformation/ChangeSizeResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServiceReference1.CustomServiceException), Action="WCFService.Standard/ShapeTransformation/ChangeSizeCustomServiceExceptionFault", Name="CustomServiceException", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
        ServiceReference1.Rectangle ChangeSize(ServiceReference1.Rectangle rect, double factor);
        
        [System.ServiceModel.OperationContractAttribute(Action="WCFService.Standard/ShapeTransformation/ChangeSize", ReplyAction="WCFService.Standard/ShapeTransformation/ChangeSizeResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Rectangle> ChangeSizeAsync(ServiceReference1.Rectangle rect, double factor);
        
        [System.ServiceModel.OperationContractAttribute(Action="WCFService.Standard/ShapeTransformation/GetSquare", ReplyAction="WCFService.Standard/ShapeTransformation/GetSquareResponse")]
        double GetSquare(ServiceReference1.Rectangle rect);
        
        [System.ServiceModel.OperationContractAttribute(Action="WCFService.Standard/ShapeTransformation/GetSquare", ReplyAction="WCFService.Standard/ShapeTransformation/GetSquareResponse")]
        System.Threading.Tasks.Task<double> GetSquareAsync(ServiceReference1.Rectangle rect);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface ShapeTransformationChannel : ServiceReference1.ShapeTransformation, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class ShapeTransformationClient : System.ServiceModel.ClientBase<ServiceReference1.ShapeTransformation>, ServiceReference1.ShapeTransformation
    {
        
        public ShapeTransformationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ServiceReference1.Rectangle GetRectangle(double width, double height)
        {
            return base.Channel.GetRectangle(width, height);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Rectangle> GetRectangleAsync(double width, double height)
        {
            return base.Channel.GetRectangleAsync(width, height);
        }
        
        public ServiceReference1.Rectangle ChangeSize(ServiceReference1.Rectangle rect, double factor)
        {
            return base.Channel.ChangeSize(rect, factor);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Rectangle> ChangeSizeAsync(ServiceReference1.Rectangle rect, double factor)
        {
            return base.Channel.ChangeSizeAsync(rect, factor);
        }
        
        public double GetSquare(ServiceReference1.Rectangle rect)
        {
            return base.Channel.GetSquare(rect);
        }
        
        public System.Threading.Tasks.Task<double> GetSquareAsync(ServiceReference1.Rectangle rect)
        {
            return base.Channel.GetSquareAsync(rect);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
    }
}
