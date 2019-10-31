using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TokenAuthenticationInWebAPI.Repository
{
    public class UserMasterRepository
    {
        SECURITY_DBEntities context = new SECURITY_DBEntities();

        //This method is use to chck and validate the user and credentials
        public UserMaster ValidateUser(string username, string password)
        {
            return
                context.UserMasters.FirstOrDefault(
                    user =>
                        user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                        user.UserPassword == password);
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}