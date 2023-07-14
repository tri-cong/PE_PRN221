using DataAccessObject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository.IRepository;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace CandidateManagement_NguyenTriCong.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IHraccount hraccountRepository;

        public LoginModel(IHraccount hraccount)
        {
            this.hraccountRepository = hraccount;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        [Required]
        public string Email { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                Hraccount hraccount = hraccountRepository.GetHraccount(Email);
                if (hraccount == null || hraccount.Password!=Password) 
                {
                    ViewData["Message"] = "Email or password incorrect!";
                    return Page();
                }
                else
                {
                    HttpContext.Session.SetInt32("ROLE", (int)hraccount.MemberRole);
                    return RedirectToPage("Candidate");
                }
            }
            catch (Exception ex)
            {
                ViewData["Message"] = ex.Message;
                return Page();
            }

        }
    }
}
