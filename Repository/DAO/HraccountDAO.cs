using DataAccessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAO
{
    public class HraccountDAO
    {
        private static HraccountDAO instance = null;
        private static readonly object instanceLock = new object();
        public HraccountDAO() { }
        public static HraccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new HraccountDAO();
                    }
                    return instance;
                }
            }
        }
        public Hraccount GetHraccount(string email)
        {
            Hraccount hraccount = null;
            try
            {
                using var context = new CandidateManagementContext();
                hraccount = context.Hraccounts.SingleOrDefault(h => h.Email.Equals(email));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return hraccount;
        }

    }
}
