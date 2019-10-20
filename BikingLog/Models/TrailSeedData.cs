using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikingLog.Models
{
    public class TrailSeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Trails.Any())
            {
                context.Trails.AddRange(
                new Trail
                {
                    Name = "Cumberland Valley Trail",
                    Location = "Newville",
                    Miles = 21,
                    DifficultyLevel = 4
                },
                new Trail
                {
                    Name = "Conewago Recreation Trail",
                    Location = "Elizabethtown",
                    Miles = 5,
                    DifficultyLevel = 2
                },
                new Trail
                {
                    Name = "Jonathan Eshenour Memorial Trail",
                    Location = "Hummelstown",
                    Miles = 13,
                    DifficultyLevel = 3
                },
                new Trail
                {
                    Name = "Heritage Rail Trail",
                    Location = "York",
                    Miles = 21,
                    DifficultyLevel = 4
                },
                new Trail
                {
                    Name = "Capital Area Greenbelt",
                    Location = "Harrisburg",
                    Miles = 20,
                    DifficultyLevel = 4
                },
                new Trail
                {
                    Name = "Lebanon Valley Rail Trail",
                    Location = "Lebanon",
                    Miles = 12,
                    DifficultyLevel = 3
                }
            );

                context.SaveChanges();
            }
        }

    }
}

