using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlannerApp.Data;
using SacramentMeetingPlannerApp.Models;

namespace SacramentMeetingPlannerApp.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly SacramentMeetingPlannerApp.Data.SacramentMeetingPlannerAppContext _context;

        public DetailsModel(SacramentMeetingPlannerApp.Data.SacramentMeetingPlannerAppContext context)
        {
            _context = context;
        }

      public SacramentMeeting SacramentMeeting { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.SacramentMeeting == null)
            {
                return NotFound();
            }

            var sacramentmeeting = await _context.SacramentMeeting.FirstOrDefaultAsync(m => m.Id == id);
            if (sacramentmeeting == null)
            {
                return NotFound();
            }
            else 
            {
                SacramentMeeting = sacramentmeeting;
            }
            return Page();
        }
    }
}
