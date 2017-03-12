using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace InsertSqlServerWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    
    [ServiceContract]
    public interface IService1
    {             

        // TODO: Add your service operations here

      
        [OperationContract]
        void InsertUserDetails(UserDetails userInfo);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    public class UserDetails

    {
        
        string username = string.Empty;
        DateTime timeStamp;
        int mode=0;
        int clockstatus=0;

        //[DataMember]
        //public int ID
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        [DataMember]
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        [DataMember]
        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }
        [DataMember]
        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }
        [DataMember]
        public int ClockStatus
        {
            get { return clockstatus; }
            set { clockstatus = value; }
        }

                
    }
    
   
}
