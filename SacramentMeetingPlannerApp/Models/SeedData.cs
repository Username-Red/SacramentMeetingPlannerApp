using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlannerApp.Data;

namespace SacramentMeetingPlannerApp.Models {
    public static class SeedData {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new SacramentMeetingPlannerAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentMeetingPlannerAppContext>>())) {
                if (context == null || context.SacramentMeeting == null) {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.SacramentMeeting.Any()) {
                    return;   // DB has been seeded
                }

                context.SacramentMeeting.AddRange(
                    new SacramentMeeting {
                        MeetingDate = DateTime.Parse("2023-6-16"),
                        ConductingLeader = "Bro. Willis",
                        OpeningHymn = "The Spirit of God",
                        SacramentHymn = "There is a Green Hill Far Away",
                        ClosingHymn = "Love One Another",
                        IntermediateHymn = "How Firm a Foundation",
                        OpeningPrayer = "Sis. Hubbard",
                        ClosingPrayer = "Bro. Kovalchic",
                        SpeakerSubjects = "First Vision, Ongoing Restoration"
                    },
                    new SacramentMeeting {
                        MeetingDate = DateTime.Parse("2023-6-23"),
                        ConductingLeader = "Bro. Krikava",
                        OpeningHymn = "Come, Come, Ye Saints",
                        SacramentHymn = "As Now We Take the Sacrament",
                        ClosingHymn = "God Be with You Till We Meet Again",
                        IntermediateHymn = "Shoulder to the Wheel",
                        OpeningPrayer = "Sis. Baxter",
                        ClosingPrayer = "Bro. Stratton",
                        SpeakerSubjects = "Enduring to the End, Ministering"
                    },
                    new SacramentMeeting {
                        MeetingDate = DateTime.Parse("2023-6-30"),
                        ConductingLeader = "Bro. Pease",
                        OpeningHymn = "Come unto Jesus",
                        SacramentHymn = "I Stand All Amazed",
                        ClosingHymn = "Love One Another",
                        IntermediateHymn = "With Humble Heart",
                        OpeningPrayer = "Sis. Sarpong",
                        ClosingPrayer = "Bro. Denison",
                        SpeakerSubjects = "Repentance, Forgiveness"
                    },
                    new SacramentMeeting {
                        MeetingDate = DateTime.Parse("2023-7-6"),
                        ConductingLeader = "Bro. Jepsen",
                        OpeningHymn = "I Believe in Christ",
                        SacramentHymn = "Reverently and Meekly Now",
                        ClosingHymn = "I Know That My Redeemer Lives",
                        IntermediateHymn = "Praise Ye the Lord",
                        OpeningPrayer = "Sis. Zimmerman",
                        ClosingPrayer = "Sis. Campbell",
                        SpeakerSubjects = "Faith, Following the Holy Spirit"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
