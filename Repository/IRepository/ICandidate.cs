using DataAccessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface ICandidate
    {
        IEnumerable<CandidateProfile> GetCandidateProfiles();
        IQueryable<CandidateProfile> GetCandidateAsQueryable();
        IQueryable<CandidateProfile> SearchCandidatesAsQueryable(string name, DateTime? date);
        CandidateProfile GetCandidate(string id);
        void AddCandidate(CandidateProfile candidateProfile);
        void UpdateCandidate(CandidateProfile candidateProfile);
        void DeleteCandidate(string id);
    }
}
