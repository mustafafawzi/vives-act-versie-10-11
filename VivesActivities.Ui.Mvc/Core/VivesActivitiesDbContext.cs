using Microsoft.EntityFrameworkCore;
using VivesActivities.Ui.Mvc.Models;

namespace VivesActivities.Ui.Mvc.Core
{
    public class VivesActivitiesDbContext: DbContext
    {
        public VivesActivitiesDbContext(DbContextOptions<VivesActivitiesDbContext> options): base(options)
        {
            
        }
        public DbSet<VivesActivity> Activities => Set<VivesActivity>();

        public void Seed()
        {
            Activities.AddRange(new List<VivesActivity>
            {
                new VivesActivity
                {
                    Name = "Soccer",
                    Type = "Team Sport",
                    Location = "Stadium 1",
                    Description = "Description of Soccer"
                },
                new VivesActivity
                {
                    Name = "Tennis",
                    Type = "Individual Sport",
                    Location = "Court 1",
                    Description = "Description of Tennis"
                },
                new VivesActivity
                {
                    Name = "Basketball",
                    Type = "Team Sport",
                    Location = "Arena 1",
                    Description = "Description of Basketball"
                },
                new VivesActivity
                {
                    Name = "Swimming",
                    Type = "Individual Sport",
                    Location = "Pool 1",
                    Description = "Description of Swimming"
                },
                new VivesActivity
                {
                    Name = "Volleyball",
                    Type = "Team Sport",
                    Location = "Beach 1",
                    Description = "Description of Volleyball"
                },
                new VivesActivity
                {
                    Name = "Golf",
                    Type = "Individual Sport",
                    Location = "Course 1",
                    Description = "Description of Golf"
                },
                new VivesActivity
                {
                    Name = "Badminton",
                    Type = "Individual Sport",
                    Location = "Court 2",
                    Description = "Description of Badminton"
                },
                new VivesActivity
                {
                    Name = "Hockey",
                    Type = "Team Sport",
                    Location = "Field 1",
                    Description = "Description of Hockey"
                },
                new VivesActivity
                {
                    Name = "Table Tennis",
                    Type = "Individual Sport",
                    Location = "Recreation Center 1",
                    Description = "Description of Table Tennis"
                },
                new VivesActivity
                {
                    Name = "Rugby",
                    Type = "Team Sport",
                    Location = "Field 2",
                    Description = "Description of Rugby"
                }
            });

            SaveChanges();
        }
    }
}
