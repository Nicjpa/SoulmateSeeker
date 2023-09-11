using Microsoft.EntityFrameworkCore;
using SoulmateSeeker.Entities;
using System;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Text;

namespace SoulmateSeeker.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<AppUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var appUsers = new List<AppUser>()
            {
                // 5 FEMALE USERS:

                 new AppUser()
                 {
                     Id = 1,
                     UserName = "liza",
                     Gender = "female",
                     DateOfBirth = new DateTime(1956, 7, 22),
                     KnownAs = "liza",
                     Created = new DateTime(2020, 6, 24),
                     LastActive = new DateTime(2020, 10, 10),
                     Introduction = "IntroductionBlablabla",
                     LookingFor = "LookingForBlablabla",
                     Interests = "I am interesed in blablabla",
                     City = "Greenbush",
                     Country = "Martinique"
                 },

                 new AppUser()
                 {
                     Id = 2,
                     UserName = "karen",
                     Gender = "female",
                     DateOfBirth = new DateTime(1995, 10, 12),
                     KnownAs = "karen",
                     Created = new DateTime(2019, 12, 09),
                     LastActive = new DateTime(2020, 05, 06),
                     Introduction = "IntroductionBlablabla",
                     LookingFor = "LookingForBlablabla",
                     Interests = "I am interesed in blablabla",
                     City = "Celeryville",
                     Country = "Grenada"
                 },

                 new AppUser()
                 {
                     Id = 3,
                     UserName = "margo",
                     Gender = "female",
                     DateOfBirth = new DateTime(1959, 1, 24),
                     KnownAs = "margo",
                     Created = new DateTime(2019, 8, 10),
                     LastActive = new DateTime(2020, 5, 12),
                     Introduction = "IntroductionBlablabla",
                     LookingFor = "LookingForBlablabla",
                     Interests = "I am interesed in blablabla",
                     City = "Rosewood",
                     Country = "Svalbard and Jan Mayen Islands"
                 },

                 new AppUser()
                 {
                     Id = 4,
                     UserName = "lois",
                     Gender = "female",
                     DateOfBirth = new DateTime(1988, 6, 22),
                     KnownAs = "lois",
                     Created = new DateTime(2019, 4, 24),
                     LastActive = new DateTime(2020, 6, 17),
                     Introduction = "IntroductionBlablabla",
                     LookingFor = "LookingForBlablabla",
                     Interests = "I am interesed in blablabla",
                     City = "Orviston",
                     Country = "Zimbabwe",
                 },

                 new AppUser()
                 {
                     Id = 5,
                     UserName = "ruthie",
                     Gender = "female",
                     DateOfBirth = new DateTime(1956, 1, 12),
                     KnownAs = "ruthie",
                     Created = new DateTime(2019, 4, 30),
                     LastActive = new DateTime(2020, 6, 21),
                     Introduction = "IntroductionBlablabla",
                     LookingFor = "LookingForBlablabla",
                     Interests = "I am interesed in blablabla",
                     City = "Germanton",
                     Country = "Antigua and Barbuda",
                 },

                 // 5 MALE USERS:

                 new AppUser()
                 {
                     Id = 6,
                     UserName = "todd",
                     Gender = "male",
                     DateOfBirth = new DateTime(1950, 2, 7),
                     KnownAs = "todd",
                     Created = new DateTime(2019, 4, 29),
                     LastActive = new DateTime(2020, 5, 16),
                     Introduction = "IntroductionBlablabla",
                     LookingFor = "LookingForBlablabla",
                     Interests = "I am interesed in blablabla",
                     City = "Cliff",
                     Country = "British Indian Ocean Territory",
                 },

                 new AppUser()
                 {
                     Id = 7,
                     UserName = "porter",
                     Gender = "male",
                     DateOfBirth = new DateTime(1967, 4, 9),
                     KnownAs = "porter",
                     Created = new DateTime(2020, 4, 5),
                     LastActive = new DateTime(2020, 6, 23),
                     Introduction = "IntroductionBlablabla",
                     LookingFor = "LookingForBlablabla",
                     Interests = "I am interesed in blablabla",
                     City = "Welda",
                     Country = "Christmas Island",
                 },

                 new AppUser()
                 {
                     Id = 8,
                     UserName = "mayo",
                     Gender = "male",
                     DateOfBirth = new DateTime(1990, 3, 23),
                     KnownAs = "mayo",
                     Created = new DateTime(2019, 3, 14),
                     LastActive = new DateTime(2020, 5, 17),
                     Introduction = "IntroductionBlablabla",
                     LookingFor = "LookingForBlablabla",
                     Interests = "I am interesed in blablabla",
                     City = "Calrence",
                     Country = "Burkina Faso",
                 },

                 new AppUser()
                 {
                     Id = 9,
                     UserName = "skinner",
                     Gender = "male",
                     DateOfBirth = new DateTime(1952, 12, 1),
                     KnownAs = "skinner",
                     Created = new DateTime(2019, 1, 28),
                     LastActive = new DateTime(2020, 6, 7),
                     Introduction = "IntroductionBlablabla",
                     LookingFor = "LookingForBlablabla",
                     Interests = "I am interesed in blablabla",
                     City = "Herald",
                     Country = "Poland",
                 },

                 new AppUser()
                 {
                     Id = 10,
                     UserName = "davis",
                     Gender = "male",
                     DateOfBirth = new DateTime(1978, 3, 20),
                     KnownAs = "davis",
                     Created = new DateTime(2019, 2, 25),
                     LastActive = new DateTime(2020, 6, 11),
                     Introduction = "IntroductionBlablabla",
                     LookingFor = "LookingForBlablabla",
                     Interests = "I am interesed in blablabla",
                     City = "Lupton",
                     Country = "Luxembourg",
                 },
            };

            var userMainPhotos = new List<Photo>()
            {
                new Photo()
                {
                    Id = 1,
                    AppUserId = 1,
                    Url = "https://randomuser.me/api/portraits/women/54.jpg",
                    IsMain = true,
                },

                new Photo()
                {
                    Id = 2,
                    AppUserId = 2,
                    Url = "https://randomuser.me/api/portraits/women/50.jpg",
                    IsMain = true,
                },

                new Photo()
                {
                    Id = 3,
                    AppUserId = 3,
                    Url = "https://randomuser.me/api/portraits/women/14.jpg",
                    IsMain = true,
                },

                new Photo()
                {
                    Id = 4,
                    AppUserId = 4,
                    Url = "https://randomuser.me/api/portraits/women/11.jpg",
                    IsMain = true,
                },

                new Photo()
                {
                    Id = 5,
                    AppUserId = 5,
                    Url = "https://randomuser.me/api/portraits/women/84.jpg",
                    IsMain = true,
                },

                //new Photo()
                //{
                //    Id = 6,
                //    AppUserId = 6,
                //    Url = "https://randomuser.me/api/portraits/men/90.jpg",
                //    IsMain = true,
                //},

                new Photo()
                {
                    Id = 7,
                    AppUserId = 7,
                    Url = "https://randomuser.me/api/portraits/men/87.jpg",
                    IsMain = true,
                },

                new Photo()
                {
                    Id = 8,
                    AppUserId = 8,
                    Url = "https://randomuser.me/api/portraits/men/57.jpg",
                    IsMain = true,
                },

                new Photo()
                {
                    Id = 9,
                    AppUserId = 9,
                    Url = "https://randomuser.me/api/portraits/men/11.jpg",
                    IsMain = true,
                },

                new Photo()
                {
                    Id = 10,
                    AppUserId = 10,
                    Url = "https://randomuser.me/api/portraits/men/93.jpg",
                    IsMain = true,
                },
            };

            AddHashAndSaltThePasswordsToTheUsers(appUsers);



            modelBuilder.Entity<AppUser>().HasData(appUsers);
            modelBuilder.Entity<Photo>().HasData(userMainPhotos);
        }

        private void AddHashAndSaltThePasswordsToTheUsers(List<AppUser> appUsers)
        {
            foreach (var user in appUsers)
            {
                using var hmac = new HMACSHA512();

                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$w0rd"));
                user.PasswordSalt = hmac.Key;
            }
        }
    }
}
