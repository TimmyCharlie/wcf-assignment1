using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Prime(int num);

        [OperationContract]
        int SumDigit(int num);

        [OperationContract]
        string ReverseString(string str);

        [OperationContract]
        string PrintHtml(string tag, string data);

        [OperationContract]
        int[] Sort5(int[] ints, int order);
    }
}
