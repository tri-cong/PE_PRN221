using DataAccessObject.Models;
using Repository.DAO;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class HraccountRepository : IHraccount
    {
        public Hraccount GetHraccount(string email)
        => HraccountDAO.Instance.GetHraccount(email);
    }
}
