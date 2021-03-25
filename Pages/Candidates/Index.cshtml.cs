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
    public class IndexModel : PageModel
    {
        private readonly oneworldcert.Data.ApplicationDbContext _context;

        public IndexModel(oneworldcert.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; }

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate.ToListAsync();
        }
    }
}
