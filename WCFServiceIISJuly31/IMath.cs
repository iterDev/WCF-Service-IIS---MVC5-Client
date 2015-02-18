using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceIISJuly31
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMath
    {

        [OperationContract]
        [WebInvoke(Method = "GET" , ResponseFormat = WebMessageFormat.Json)]
        string GetData();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle=WebMessageBodyStyle.Bare)]
        double Add(double x, double y);

    }


   
   
}
