using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using oneworldcert.Data;
using oneworldcert.Models;

namespace oneworldcert.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly oneworldcert.Data.ApplicationDbContext _context;

        public DetailsModel(oneworldcert.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidate = await _context.Candidate.FirstOrDefaultAsync(m => m.ID == id);

            if (Candidate == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
