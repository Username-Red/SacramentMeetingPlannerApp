using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacramentMeetingPlannerApp.Data;
using SacramentMeetingPlannerApp.Models;

namespace SacramentMeetingPlannerApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly SacramentMeetingPlannerApp.Data.SacramentMeetingPlannerAppContext _context;

        public CreateModel(SacramentMeetingPlannerApp.Data.SacramentMeetingPlannerAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SacramentMeeting SacramentMeeting { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.SacramentMeeting == null || SacramentMeeting == null)
            {
                return Page();
            }

            _context.SacramentMeeting.Add(SacramentMeeting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
