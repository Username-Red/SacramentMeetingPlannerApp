using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlannerApp.Models;

namespace SacramentMeetingPlannerApp.Data
{
    public class SacramentMeetingPlannerAppContext : DbContext
    {
        public SacramentMeetingPlannerAppContext (DbContextOptions<SacramentMeetingPlannerAppContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentMeetingPlannerApp.Models.SacramentMeeting> SacramentMeeting { get; set; } = default!;
    }
}
