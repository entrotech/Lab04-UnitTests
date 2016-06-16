using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talent.Domain.TestData
{
    public class DomainObjectStore
    {
        #region Constructor

        public DomainObjectStore()
        {
            MpaaRatings = LoadMpaaRatings();
            Genres = LoadGenres();
            CreditTypes = LoadCreditTypes();
            HairColors = LoadHairColors();
            EyeColors = LoadEyeColors();
            Shows = LoadShows();
            People = LoadPeople();
            ShowGenres = LoadShowGenres(Shows);
            Credits = LoadCredits(Shows, People);
        }

        #endregion

        #region Properties

        public List<MpaaRating> MpaaRatings { get; set; }
        public List<Genre> Genres { get; set; }
        public List<CreditType> CreditTypes { get; set; }
        public List<HairColor> HairColors { get; set; }
        public List<EyeColor> EyeColors { get; set; }
        public List<Show> Shows { get; set; }
        public List<Person> People { get; set; }
        public List<ShowGenre> ShowGenres { get; set; }
        public List<Credit> Credits { get; set; }

        #endregion

        #region Load Methods

        private static List<MpaaRating> LoadMpaaRatings()
        {
            var maxMpaaRatingId = 0;

            List<MpaaRating> list = new List<MpaaRating>();
            list.Add(
                new MpaaRating()
                {
                    Id = ++maxMpaaRatingId,
                    Code = "G",
                    Name = "General Audiences",
                    Description = "All ages admitted.",
                    DisplayOrder = 10
                }
                );
            list.Add(
                new MpaaRating()
                {
                    Id = ++maxMpaaRatingId,
                    Code = "PG",
                    Name = "Parental Guidance Suggested",
                    Description = "Some material may not be suitable for children.",
                    DisplayOrder = 20
                }
                );
            list.Add(
                new MpaaRating()
                {
                    Id = ++maxMpaaRatingId,
                    Code = "PG-13",
                    Name = "Parents Are Strongly Cautioned",
                    Description = "Parents are urged to be cautious.",
                    DisplayOrder = 30
                }
                );
            list.Add(
                new MpaaRating()
                {
                    Id = ++maxMpaaRatingId,
                    Code = "R",
                    Name = "Restricted",
                    Description = "People under 17 years must be accompanied.",
                    DisplayOrder = 40
                }
                );
            list.Add(
                new MpaaRating()
                {
                    Id = ++maxMpaaRatingId,
                    Code = "NC-17",
                    Name = "Adults Only",
                    Description = "Exclusively for adults.",
                    DisplayOrder = 50
                }
                );
            list.Add(
                new MpaaRating()
                {
                    Id = ++maxMpaaRatingId,
                    Code = "UR",
                    Name = "Unrated",
                    Description = "Not submitted for rating.",
                    DisplayOrder = 60
                }
                );
            return list;
        }

        private static List<Genre> LoadGenres()
        {
            var maxId = 0;

            List<Genre> list = new List<Genre>();
            list.Add(
                new Genre()
                {
                    Id = ++maxId, // 1
                    Code = "Dra",
                    Name = "Drama"
                });
            list.Add(
                new Genre()
                {
                    Id = ++maxId, //2
                    Code = "Com",
                    Name = "Comedy"
                });
            list.Add(
                new Genre()
                {
                    Id = ++maxId, // 3
                    Code = "Sus",
                    Name = "Suspense"
                });
            list.Add(
                new Genre()
                {
                    Id = ++maxId, // 4
                    Code = "Act",
                    Name = "Action"
                });
            list.Add(
                new Genre()
                {
                    Id = ++maxId,  // 5
                    Code = "Doc",
                    Name = "Documentary"
                });
            list.Add(
                new Genre()
                {
                    Id = 6,
                    Code = "Ani",
                    Name = "Animation"
                });
            list.Add(
                new Genre()
                {
                    Id = 7,
                    Code = "Adv",
                    Name = "Adventure"
                });

            return list;
        }

        private static List<CreditType> LoadCreditTypes()
        {
            var maxId = 0;
            List<CreditType> list = new List<CreditType>();
            list.Add(
                new CreditType()
                {
                    Id = ++maxId, // 1
                    Code = "Act",
                    Name = "Actor",
                    DisplayOrder = 5
                });
            list.Add(
                new CreditType()
                {
                    Id = ++maxId, // 2
                    Code = "Dir",
                    Name = "Director",
                    DisplayOrder = 10
                });
            list.Add(
                new CreditType()
                {
                    Id = ++maxId, // 3
                    Code = "Prod",
                    Name = "Producer",
                    DisplayOrder = 10
                });
            list.Add(
                new CreditType()
                {
                    Id = ++maxId, // 4
                    Code = "EP",
                    Name = "Executive Producer",
                    DisplayOrder = 10
                });
            list.Add(
                new CreditType()
                {
                    Id = ++maxId, // 5
                    Code = "Wri",
                    Name = "Writer",
                    DisplayOrder = 10
                });

            return list;
        }

        private static List<HairColor> LoadHairColors()
        {
            var maxId = 0;
            List<HairColor> list = new List<HairColor>();
            list.Add(
                new HairColor()
                {
                    Id = ++maxId, // 1
                    Code = "Un",
                    Name = "Unspecified",
                    DisplayOrder = 5
                });
            list.Add(
                new HairColor()
                {
                    Id = ++maxId, // 2
                    Code = "Bald",
                    Name = "Bald",
                    DisplayOrder = 10
                });
            list.Add(
                new HairColor()
                {
                    Id = ++maxId, // 3
                    Code = "Blnd",
                    Name = "Blonde",
                    DisplayOrder = 10
                });
            list.Add(
                new HairColor()
                {
                    Id = ++maxId, // 4
                    Code = "Brun",
                    Name = "Brunette",
                    DisplayOrder = 10
                });
            list.Add(
                new HairColor()
                {
                    Id = ++maxId, // 5
                    Code = "Gray",
                    Name = "Gray",
                    DisplayOrder = 10
                });
            list.Add(
                new HairColor()
                {
                    Id = ++maxId, // 6
                    Code = "Red",
                    Name = "Red",
                    DisplayOrder = 10
                });

            return list;
        }

        private static List<EyeColor> LoadEyeColors()
        {
            var maxId = 0;
            List<EyeColor> list = new List<EyeColor>();
            list.Add(
                new EyeColor()
                {
                    Id = ++maxId, // 1
                    Code = "Un",
                    Name = "Unspecified",
                    DisplayOrder = 5
                });
            list.Add(
                new EyeColor()
                {
                    Id = ++maxId, // 2
                    Code = "Blue",
                    Name = "Blue",
                    DisplayOrder = 10
                });
            list.Add(
                new EyeColor()
                {
                    Id = ++maxId, // 3
                    Code = "Brn",
                    Name = "Brown",
                    DisplayOrder = 10
                });
            list.Add(
                new EyeColor()
                {
                    Id = ++maxId, // 4
                    Code = "Hzl",
                    Name = "Hazel",
                    DisplayOrder = 10
                });
            list.Add(
                new EyeColor()
                {
                    Id = ++maxId, // 5
                    Code = "Grn",
                    Name = "Green",
                    DisplayOrder = 10
                });
            list.Add(
                new EyeColor()
                {
                    Id = ++maxId, // 6
                    Code = "Blk",
                    Name = "Black",
                    DisplayOrder = 10
                });

            return list;
        }

        private static List<Show> LoadShows()
        {
            var maxId = 0;
            var list = new List<Show>();
            list.Add(
                new Show()
                {
                    Id = ++maxId, // 1
                    Title = "Philomena",
                    LengthInMinutes = 98,
                    MpaaRatingId = 3,
                    ReleaseDate = new DateTime(2013, 11, 27)
                });

            list.Add(
                new Show()
                {
                    Id = ++maxId, // 2
                    Title = "Frozen",
                    LengthInMinutes = 102,
                    MpaaRatingId = 2,
                    ReleaseDate = new DateTime(2013, 11, 27)
                });

            return list;
        }

        private static List<Person> LoadPeople()
        {
            var maxId = 0;


            List<Person> list = new List<Person>();
            list.Add(
                new Person
                {
                    Id = ++maxId, // 1
                    Salutation = "Ms.",
                    FirstName = "Judith",
                    MiddleName = "Olivia",
                    LastName = "Dench",
                    Suffix = "",
                    DateOfBirth = new DateTime(1934, 12, 9),
                    HairColorId = 5,
                    EyeColorId = 2,
                    Height = 66
                });

            list.Add(
                new Person
                {
                    Id = ++maxId, // 2
                    Salutation = "Mr.",
                    FirstName = "Stephen",
                    MiddleName = "",
                    LastName = "Frears",
                    Suffix = "",
                    DateOfBirth = new DateTime(1941, 6, 20)
                });


            list.Add(
                new Person
                {
                    Id = ++maxId, // 3
                    Salutation = "Mr.",
                    FirstName = "Stephen",
                    MiddleName = "John",
                    LastName = "Coogan",
                    Suffix = "",
                    DateOfBirth = new DateTime(1965, 10, 14),
                    HairColorId = 4,
                    EyeColorId = 5,
                    Height = 72
                });

            list.Add(
                new Person
                {
                    Id = ++maxId, // 4
                    Salutation = "Ms.",
                    FirstName = "Sophie",
                    MiddleName = "Kennedy",
                    LastName = "Clark",
                    Suffix = "",
                    DateOfBirth = null,
                    HairColorId = 3,
                    EyeColorId = 3,
                    Height = 68
                });

            list.Add(
                new Person
                {
                    Id = ++maxId, // 5
                    Salutation = "Mr.",
                    FirstName = "Chris",
                    MiddleName = "",
                    LastName = "Buck",
                    Suffix = "",
                    DateOfBirth = null,
                    HairColorId = 4,
                    EyeColorId = 5,
                    Height = 68
                });

            list.Add(
                new Person
                {
                    Id = ++maxId, // 6
                    Salutation = "Ms.",
                    FirstName = "Jennifer",
                    MiddleName = "",
                    LastName = "Lee",
                    Suffix = "",
                    DateOfBirth = null,
                    HairColorId = 3,
                    EyeColorId = 5
                });

            list.Add(
                new Person
                {
                    Id = ++maxId, // 7
                    Salutation = "Ms.",
                    FirstName = "Kristen",
                    MiddleName = "",
                    LastName = "Bell",
                    Suffix = "",
                    DateOfBirth = new DateTime(1980, 7, 18),
                    HairColorId = 4,
                    EyeColorId = 6
                });

            list.Add(
                new Person
                {
                    Id = ++maxId, // 8
                    Salutation = "",
                    FirstName = "Josh",
                    MiddleName = "",
                    LastName = "Gad",
                    Suffix = "",
                    DateOfBirth = null,
                    HairColorId = 1,
                    EyeColorId = 1
                });

            return list;
        }

        private static List<ShowGenre> LoadShowGenres(List<Show> shows)
        {
            var maxShowGenreId = 0;

            var list = new List<ShowGenre>();
            ShowGenre showGenre;

            showGenre = new ShowGenre
            {
                Id = ++maxShowGenreId,
                ShowId = 1,
                GenreId = 1
            };
            list.Add(showGenre);
            FindShowById(shows, showGenre.ShowId).ShowGenres.Add(showGenre);

            showGenre = new ShowGenre
            {
                Id = ++maxShowGenreId,
                ShowId = 2,
                GenreId = 2
            };
            list.Add(showGenre);
            FindShowById(shows, showGenre.ShowId).ShowGenres.Add(showGenre);

            showGenre = new ShowGenre
            {
                Id = ++maxShowGenreId,
                ShowId = 2,
                GenreId = 6
            };
            list.Add(showGenre);
            FindShowById(shows, showGenre.ShowId).ShowGenres.Add(showGenre);

            showGenre = new ShowGenre
            {
                Id = ++maxShowGenreId,
                ShowId = 2,
                GenreId = 7
            };
            FindShowById(shows, showGenre.ShowId).ShowGenres.Add(showGenre);

            list.Add(showGenre);
            return list;
        }

        private static List<Credit> LoadCredits(List<Show> shows, List<Person> people)
        {
            var maxId = 0;
            var list = new List<Credit>();
            Credit crd;
            crd = new Credit
            {
                Id = ++maxId,
                ShowId = 1,
                PersonId = 1,
                CreditTypeId = 1,
                Character = "Philomena"
            };
            list.Add(crd);
            FindShowById(shows, crd.ShowId).Credits.Add(crd);
            FindPersonById(people, crd.PersonId).Credits.Add(crd);

            crd = new Credit
            {
                Id = ++maxId,
                ShowId = 1,
                PersonId = 2,
                CreditTypeId = 2
            };
            list.Add(crd);
            FindShowById(shows, crd.ShowId).Credits.Add(crd);
            FindPersonById(people, crd.PersonId).Credits.Add(crd);

            crd = new Credit
            {
                Id = ++maxId,
                ShowId = 1,
                PersonId = 3,
                CreditTypeId = 5
            };
            list.Add(crd);
            FindShowById(shows, crd.ShowId).Credits.Add(crd);
            FindPersonById(people, crd.PersonId).Credits.Add(crd);

            crd = new Credit
            {
                Id = ++maxId,
                ShowId = 1,
                PersonId = 3,
                CreditTypeId = 1,
                Character = "Martin Sixsmith"
            };
            list.Add(crd);
            FindShowById(shows, crd.ShowId).Credits.Add(crd);
            FindPersonById(people, crd.PersonId).Credits.Add(crd);

            crd = new Credit
            {
                Id = ++maxId,
                ShowId = 1,
                PersonId = 4,
                CreditTypeId = 1,
                Character = "Young Philomena"
            };
            list.Add(crd);
            FindShowById(shows, crd.ShowId).Credits.Add(crd);
            FindPersonById(people, crd.PersonId).Credits.Add(crd);

            crd = new Credit
            {
                Id = ++maxId,
                ShowId = 1,
                PersonId = 5,
                CreditTypeId = 2
            };
            list.Add(crd);
            FindShowById(shows, crd.ShowId).Credits.Add(crd);
            FindPersonById(people, crd.PersonId).Credits.Add(crd);

            crd = new Credit
            {
                Id = ++maxId,
                ShowId = 2,
                PersonId = 6,
                CreditTypeId = 2
            };
            list.Add(crd);
            FindShowById(shows, crd.ShowId).Credits.Add(crd);
            FindPersonById(people, crd.PersonId).Credits.Add(crd);

            crd = new Credit
            {
                Id = ++maxId,
                ShowId = 2,
                PersonId = 6,
                CreditTypeId = 5
            };
            list.Add(crd);
            FindShowById(shows, crd.ShowId).Credits.Add(crd);
            FindPersonById(people, crd.PersonId).Credits.Add(crd);

            crd = new Credit
            {
                Id = ++maxId,
                ShowId = 2,
                PersonId = 7,
                CreditTypeId = 1,
                Character = "Anna"
            };
            list.Add(crd);
            FindShowById(shows, crd.ShowId).Credits.Add(crd);
            FindPersonById(people, crd.PersonId).Credits.Add(crd);

            crd = new Credit
            {
                Id = ++maxId,
                ShowId = 2,
                PersonId = 8,
                CreditTypeId = 1,
                Character = "Olaf"
            };
            list.Add(crd);
            FindShowById(shows, crd.ShowId).Credits.Add(crd);
            FindPersonById(people, crd.PersonId).Credits.Add(crd);

            return list;
        }
        #endregion

        #region Helper Methods

        public static MpaaRating FindMpaaRatingById(List<MpaaRating> ratings, int id)
        {
            foreach (var r in ratings)
            {
                if (r.Id == id) return r;
            }
            return null;
        }

        public static Genre FindGenreById(List<Genre> genres, int id)
        {
            foreach (var g in genres)
            {
                if (g.Id == id) return g;
            }
            return null;
        }

        public static CreditType FindCreditTypeById(List<CreditType> creditTypes, int id)
        {
            foreach (var c in creditTypes)
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public static HairColor FindHairColorById(List<HairColor> hairColors, int id)
        {
            foreach (var c in hairColors)
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public static EyeColor FindEyeColorById(List<EyeColor> EyeColors, int id)
        {
            foreach (var c in EyeColors)
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public static Show FindShowById(List<Show> shows, int id)
        {
            foreach (var c in shows)
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public static Person FindPersonById(List<Person> people, int id)
        {
            foreach (var c in people)
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        #endregion

    }
}
