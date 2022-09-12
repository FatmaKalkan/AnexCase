using AnexCase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnexCase.Context
{
    public class AnexCaseInitializer : DropCreateDatabaseIfModelChanges<AnexCaseContext>
    {
        protected override void Seed(AnexCaseContext context)
        {
            List<Hotel> hotels = new List<Hotel>()
            {
                new Hotel()
                {
                    Id=21,
                    Name="DOLPHIN PARK RESIDENCE"
                },
                new Hotel()
                {
                     Id=22,
                    Name="KUM HOTEL"
                },
                new Hotel()
                {
                    Id=23,
                    Name="Adonis HOTEL"
                },
                 new Hotel()
                {
                     Id=24,
                    Name="ALARA STAR HOTEL"
                }
            };
            foreach (var hotel in hotels)
            {
                context.Hotels.Add(hotel);
            }
            context.SaveChanges();
        }
    }
}
