using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel.Description;
using System.ServiceModel.Web;


namespace POS.Server.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAppService" in both code and config file together.
    [ServiceContract]
    public interface IPOSService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
     UriTemplate = "/POSService/{Item}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int Add(Item item);

        [WebInvoke(Method = "POST",
    UriTemplate = "/POSService/{Item}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        int Save(List<Item> items);

        [OperationContract]
        [WebInvoke(Method = "GET",
UriTemplate = "/POSService/{GetItems}",
BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Item> Get();

    }

 
}
