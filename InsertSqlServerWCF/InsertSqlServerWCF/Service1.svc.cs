using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.IO;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace InsertSqlServerWCF
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)] 
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    
    public class Service1 : IService1
    {
        public void InsertUserDetails(UserDetails userInfo)
        {
            try
            {
                
                //string Message;
                SqlConnection con = new SqlConnection(@"Data Source=.\TIMEMANAGER;Database=MutexSS;Integrated security = sspi;Trusted_Connection=True;");
                //& vAccountId & ";Uid=camsUser;Pwd=p0w3rp4ck;");
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into tblMutexSS(UserName,TimeStamp,Mode,Clockstatus) values(@UserName,@TimeStamp,@Mode,@ClockStatus)", con);

                    //SqlCommand cmd = new SqlCommand("insert into RegistrationTable(UserName,Password,Country,Email) values(@UserName,@Password,@Country,@Email)", con);
                    //cmd.Parameters.AddWithValue("@ID", userInfo.ID);
                    cmd.Parameters.AddWithValue("@UserName", userInfo.UserName);
                    cmd.Parameters.AddWithValue("@TimeStamp", userInfo.TimeStamp);
                    cmd.Parameters.AddWithValue("@Mode", userInfo.Mode);
                    cmd.Parameters.AddWithValue("@ClockStatus", userInfo.ClockStatus);
                    int result = cmd.ExecuteNonQuery();
                    
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            catch (Exception t)
            {
                throw t;
            }
        }
    }
}
