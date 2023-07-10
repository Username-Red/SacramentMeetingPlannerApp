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
    public class IndexModel : PageModel
    {
        private readonly SacramentMeetingPlannerApp.Data.SacramentMeetingPlannerAppContext _context;

        public IndexModel(SacramentMeetingPlannerApp.Data.SacramentMeetingPlannerAppContext context)
        {
            _context = context;
        }

        public IList<SacramentMeeting> SacramentMeeting { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.SacramentMeeting != null)
            {
                SacramentMeeting = await _context.SacramentMeeting.ToListAsync();
            }
        }
    }
}
