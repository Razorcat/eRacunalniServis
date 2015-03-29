using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRacunalniServis_Servis.Util
{
    class ExceptionHandler
    {
        public static void HandleException(EntityException e){
            SqlException greska = (SqlException)e.InnerException;
            switch(greska.Number){
                case 2627:
                    throw throwNewConstrainException(greska);
                    break;                    
                default:
                    throw new Exception(greska.Message);
            }
        }

        private static ConstraintException throwNewConstrainException(SqlException greska)
        {
            int poc = greska.Message.IndexOf("'");
            int kraj = greska.Message.IndexOf("'",poc+1);
            string newMessage = greska.Message;
            if (poc > 0 && kraj > 0)
            {
                string csName = greska.Message.Substring(poc + 1, kraj - poc-1);
                if (csName == "CS_KorisnickoIme")
                    newMessage = "username_con";
                else if (csName == "CS_Email")
                    newMessage = "email_con";
                else if(csName=="CS_Dobavljaci_Naziv")
                    newMessage = "dobavljaci_con";
            }
            return new ConstraintException(newMessage);
        }
    }
}
