using BusinessObject.Models;
using DataAccessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.IRepository;
using System;
using System.Threading.Tasks;

namespace CandidateManagement_NguyenTriCong.Pages
{
    public class CandidateModel : PageModel
    {
        private readonly ICandidate candidateRepository;
        private readonly IConfiguration Configuration;
        public CandidateModel(ICandidate candidateRepository, IConfiguration Configuration)
        {
            this.candidateRepository = candidateRepository;
            this.Configuration = Configuration;
        }
        public PaginatedList<CandidateProfile> CandidateProfiles { get; set; }

        [BindProperty(SupportsGet = true)]
        public string CandidateSearchName { get; set; }
        [BindProperty]
        public DateTime? CandidateSearchDate { get; set; }

        public async Task OnGetAsync(int? pageIndex)
        {
            try
            {
                int? role = HttpContext.Session.GetInt32("ROLE");
                if(role == 1)
                {
                    var pageSize = Configuration.GetValue("pageSize", 3);
                    var candidates = candidateRepository.GetCandidateAsQueryable();
                    CandidateProfiles = PaginatedList<CandidateProfile>.CreateAsync(candidates.AsNoTracking(), pageIndex ?? 1,pageSize);
                    if (CandidateSearchName != null || CandidateSearchDate != null)
                    {
                        var test = candidateRepository.SearchCandidatesAsQueryable(CandidateSearchName, CandidateSearchDate);
                        CandidateProfiles = PaginatedList<CandidateProfile>.CreateAsync(test.AsNoTracking(), pageIndex ?? 1, pageSize);
                    }
                }
                else
                {
                    ViewData["Message"] = "You are not allowed to access this function!";
                }
                
            }
            catch(Exception ex)
            {
                ViewData["Message"] = ex.Message;   
            }
        }

    }
}
