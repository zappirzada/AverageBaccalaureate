using System;
using System.Collections.Generic;

namespace AverageBaccalaureate.Models
{
    public class MajorDiscipline
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
    }
    public class MajorsList
    {
        /// <summary>
        /// 
        /// </summary>
        public static List<MajorDiscipline> GetList(int countryId)
        {
            List<MajorDiscipline> MajorsList = null;
            if (countryId == 1)
            {
                MajorsList = new List<MajorDiscipline>()
                {
                    new MajorDiscipline()
                    {
                        Id = 1,
                        Name = "S",
                        CountryId = 1
                    },
                    new MajorDiscipline()
                    {
                        Id = 2,
                        Name = "ES",
                        CountryId = 1
                    },
                    new MajorDiscipline()
                    {
                        Id = 3,
                        Name = "L",
                        CountryId = 1
                    },
                    new MajorDiscipline()
                    {
                        Id = 4,
                        Name = "ST2S",
                        CountryId = 1
                    },
                    new MajorDiscipline()
                    {
                        Id = 5,
                        Name = "STD2A",
                        CountryId = 1
                    },
                    new MajorDiscipline()
                    {
                        Id = 6,
                        Name = "STI2D",
                        CountryId = 1
                    },
                    new MajorDiscipline()
                    {
                        Id = 7,
                        Name = "STMG",
                        CountryId = 1
                    }
                };
            }
            else if (countryId == 2)
            {
                MajorsList = new List<MajorDiscipline>()
                {
                    new MajorDiscipline()
                    {
                        Id = 1,
                        Name = $"اللغة العربية",
                        CountryId = 2
                    },
                    new MajorDiscipline()
                    {
                        Id = 2,
                        Name = $"العلوم الشرعية",
                        CountryId = 2
                    },
                    new MajorDiscipline()
                    {
                        Id = 3,
                        Name = $"(الٱداب) الٱداب والعلوم الإنسانية",
                        CountryId = 2
                    },
                    new MajorDiscipline()
                    {
                        Id = 4,
                        Name = $"(العلوم الإنسانية) الٱداب والعلوم الإنسانية",
                        CountryId = 2
                    },
                    new MajorDiscipline()
                    {
                        Id = 5,
                        Name = "Sciences Physiques",
                        CountryId = 2
                    },
                    new MajorDiscipline()
                    {
                        Id = 6,
                        Name = "Sciences Agronomiques",
                        CountryId = 2
                    },
                    new MajorDiscipline()
                    {
                        Id = 7,
                        Name = "Sciences Mathématiques (A&B)",
                        CountryId = 2
                    },
                    new MajorDiscipline()
                    {
                        Id = 8,
                        Name = "Sciences Economiques",
                        CountryId = 2
                    },
                    new MajorDiscipline()
                    {
                        Id = 9,
                        Name = "Gestion et Comptabilité",
                        CountryId = 2
                    },
                    new MajorDiscipline()
                    {
                        Id = 10,
                        Name = "Sciences et Technologies",
                        CountryId = 2
                    },
                    new MajorDiscipline()
                    {
                        Id = 11,
                        Name = "Arts Appliqués",
                        CountryId = 2
                    },
                    new MajorDiscipline()
                    {
                        Id = 12,
                        Name = "SVT",
                        CountryId = 2
                    }
                };
            }
            return MajorsList;
        }
    }
}
