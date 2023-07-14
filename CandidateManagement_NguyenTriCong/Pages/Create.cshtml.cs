using DataAccessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository.IRepository;
using System;
using System.Threading.Tasks;

namespace CandidateManagement_NguyenTriCong.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ICandidate candidateRepository;
        private readonly IJob jobRepository;
        public CreateModel(ICandidate candidateRepository, IJob jobRepository)
        {
            this.candidateRepository = candidateRepository;
            this.jobRepository = jobRepository;
        }


        public async Task<IActionResult> OnGet()
        {
            try
            {
                int? role = HttpContext.Session.GetInt32("ROLE");
                if(role == 1)
                {
                    ViewData["PostingId"] = new SelectList(jobRepository.GetJobs(), "PostingId", "JobPostingTitle");
                    return Page();
                }
                else
                {
                    ViewData["Message"] = "You are not allowed to access this function!";
                }
            }catch(Exception ex)
            {
                ViewData["Message"] = ex.Message;
                return Page();
            }
            return RedirectToPage("./Candidate");
        }

        [BindProperty]
        public CandidateProfile CandidateProfile { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                ViewData["PostingId"] = new SelectList(jobRepository.GetJobs(), "PostingId", "JobPostingTitle");
                return Page();
            }
            try
            {

                candidateRepository.AddCandidate(CandidateProfile);
            }catch( Exception ex)
            {
                ViewData["Message"] = ex.Message;
                ViewData["PostingId"] = new SelectList(jobRepository.GetJobs(), "PostingId", "JobPostingTitle");
                return Page();
            }
            return RedirectToPage("./Candidate");
        }
    }
}
