using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFexample
{
   
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPairArihmeticService
    {

        [OperationContract]
        Pair Add(Pair p1, Pair p2);

        [OperationContract]
        Pair Subtract(Pair p1, Pair p2);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Pair
    {
        int m_first;
        int m_second;
        public Pair()
        {
            m_first = 0;
            m_second = 0;
        }
        public Pair(int first, int second)
        {
            m_first = first;
            m_second = second;
        }

        [DataMember]
        public int Second
        {
            get { return m_second; }
            set { m_second = value; }
        }

        [DataMember]
        public int First
        {
            get { return m_first; }
            set { m_first = value; }
        }
    }
}
