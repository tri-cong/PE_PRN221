﻿using DataAccessObject.Models;
using Repository.DAO;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class JobRepository : IJob
    {
        public IEnumerable<JobPosting> GetJobs()
        => JobDAO.Instance.GetJobs();
    }
}
