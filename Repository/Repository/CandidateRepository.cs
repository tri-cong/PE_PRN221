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
    public class CandidateRepository : ICandidate
    {
        public void AddCandidate(CandidateProfile candidateProfile)
        => CandidateDAO.Instance.AddCandidate(candidateProfile);

        public void DeleteCandidate(string id)
        => CandidateDAO.Instance.DeleteCandidate(id);

        public CandidateProfile GetCandidate(string id)
        => CandidateDAO.Instance.GetCandidate(id);

        public IQueryable<CandidateProfile> GetCandidateAsQueryable()
        => CandidateDAO.Instance.GetCandidateAsQueryable();

        public IEnumerable<CandidateProfile> GetCandidateProfiles()
        => CandidateDAO.Instance.GetCandidateProfiles();

        public IQueryable<CandidateProfile> SearchCandidatesAsQueryable(string name, DateTime? date)
        => CandidateDAO.Instance.SearchCandidatesAsQueryable(name, date);

        public void UpdateCandidate(CandidateProfile candidateProfile)
        => CandidateDAO.Instance.UpdateCandidate(candidateProfile);
    }
}
