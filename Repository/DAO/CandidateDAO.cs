using DataAccessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAO
{
    public class CandidateDAO
    {
        private static CandidateDAO instance = null;
        private static readonly object instanceLock = new object();
        private CandidateDAO() { }
        public static CandidateDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CandidateDAO();
                    }
                    return instance;
                }
            }
        }

        public void AddCandidate(CandidateProfile candidateProfile)
        {

            try
            {
                CandidateProfile candidate = GetCandidate(candidateProfile.CandidateId);
                if (candidate == null)
                {
                    using var context = new CandidateManagementContext();
                    context.CandidateProfiles.Add(candidateProfile);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This CandidateID is exist!");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCandidate(string id)
        {
            try
            {
                CandidateProfile candidate = GetCandidate(id);
                if (candidate != null)
                {
                    using var context = new CandidateManagementContext();
                    context.CandidateProfiles.Remove(candidate);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CandidateProfile GetCandidate(string id)
        {
            CandidateProfile candidate = null;
            try
            {
                using var context = new CandidateManagementContext();
                candidate = context.CandidateProfiles.Include(c => c.Posting).SingleOrDefault(a => a.CandidateId.Equals(id));


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return candidate;
        }

        internal IQueryable<CandidateProfile> GetCandidateAsQueryable()
        {
            IQueryable<CandidateProfile> candidates;
            try
            {
                using var context = new CandidateManagementContext();
                candidates = context.CandidateProfiles.Include(c => c.Posting).ToList().AsQueryable();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return candidates;
        }

        public IEnumerable<CandidateProfile> GetCandidateProfiles()
        {
            var cadidate = new List<CandidateProfile>();
            try
            {
                using var context = new CandidateManagementContext();
                cadidate = context.CandidateProfiles.Include(c => c.Posting).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cadidate;
        }

        public IQueryable<CandidateProfile> SearchCandidatesAsQueryable(string name, DateTime? date)
        {
            IQueryable<CandidateProfile> candidateProfiles;
            try
            {
                using var context = new CandidateManagementContext();
                candidateProfiles = context.CandidateProfiles.Where(c => c.Fullname.ToLower().Contains(name) || c.Birthday == date).ToList().AsQueryable();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return candidateProfiles;

        }

        public void UpdateCandidate(CandidateProfile candidateProfile)
        {
            try
            {
                CandidateProfile candidate = GetCandidate(candidateProfile.CandidateId);
                if (candidate != null)
                {
                    using var context = new CandidateManagementContext();
                    context.CandidateProfiles.Update(candidateProfile);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This CandidateID not exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
