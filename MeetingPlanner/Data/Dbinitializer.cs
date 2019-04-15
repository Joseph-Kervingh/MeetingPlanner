using System;
using System.Collections.Generic;
using MeetingPlanner.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Data
{
    public static class Dbinitializer
    {
        public static void Initialize(PlannerContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Meeting.
            if (context.Meetings.Any())
            {
                return;   // DB has been seeded
            }
            var meetings = new Meeting[]
              {

              };

            foreach (Meeting m in meetings)
            {
                context.Meetings.Add(m);
            }
            context.SaveChanges();

            var hymns = new Hymn[]
                {
                };

            foreach (Hymn h in hymns)
            {
                context.Hymns.Add(h);
            }

            context.SaveChanges();

            var prayers = new Prayer[]
                {
                };

            foreach (Prayer p in prayers)
            {
                context.Prayers.Add(p);
            }

            context.SaveChanges();

            var agendas = new Agenda[]
            {
            };

            foreach (Agenda a in agendas)
            {
                context.Agendas.Add(a);
            }
            context.SaveChanges();

        }

    }
}
