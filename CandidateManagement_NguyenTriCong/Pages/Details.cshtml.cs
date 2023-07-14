using DataAccessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository.IRepository;
using System.Threading.Tasks;

namespace CandidateManagement_NguyenTriCong.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ICandidate candidateRepository;
        public DetailsModel(ICandidate candidateRepository)
        {
            this.candidateRepository = candidateRepository;
        }
        public CandidateProfile CandidateProfile { get; set; }

        public async Task<IActionResult> OnGet(string id)
        {
            int? role = HttpContext.Session.GetInt32("ROLE");
            if (role != 1)
            {
                ViewData["Message"] = "You are not allowed to access this function!";
            }
            if (id == null)
            {
                return NotFound();
            }
            CandidateProfile = candidateRepository.GetCandidate(id);
            if (CandidateProfile == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
