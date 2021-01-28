using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class MyloggerRepository
    {
      private FirstDbContext firstDbContext;

        public MyloggerRepository()
        {
            firstDbContext = new FirstDbContext();
        }


        public Log Addlog(string UserName, string ActionName, string ActionDate, string Description)
        {
            Log mylogger = new Log()
            {
                UserName = UserName,
                ActionName = ActionName,
                ActionDate = ActionDate,
                Description = Description,

                 

    };
            firstDbContext.Log.Add(mylogger);
            firstDbContext.SaveChanges();
            return mylogger;
        }

      

        internal bool UserInRole(string username, string rolename)
        {
            throw new NotImplementedException();
        }
    }
}
