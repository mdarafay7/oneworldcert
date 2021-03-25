using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using oneworldcert.Data;
using oneworldcert.Models;
using oneworldcert.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace oneworldcert.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly oneworldcert.Data.ApplicationDbContext _context;

        private readonly UserManager<oneworldcertUser> _userManager;
        private readonly SignInManager<oneworldcertUser> _signInManager;

        public CreateModel(oneworldcert.Data.ApplicationDbContext context,
            UserManager<oneworldcertUser> userManager,
            SignInManager<oneworldcertUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(oneworldcertUser user)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            var userID = await _userManager.GetUserIdAsync(user);
            Candidate.OwnerID = userID;
            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
