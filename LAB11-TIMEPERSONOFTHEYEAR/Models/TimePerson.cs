using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace  LAB11_TIMEPERSONOFTHEYEAR.Models
{
    /// <summary>
    /// Create TimePerson object
    /// </summary>
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }
        /// <summary>
        /// create List, set path to list, then read the list and split on ","'s, then add the objects to the people list - exception handling if ending year is greater than the beginning year return the entire list 
        /// </summary>
        /// <param name="begYear"></param>
        /// <param name="endYear"></param>
        /// <returns></returns>
        public static List<TimePerson> GetPersons(int begYear, int endYear)
        {
            List<TimePerson> people = new List<TimePerson>();
            //read in the file
            string path = AppContext.BaseDirectory;
            string fullPath = Path.GetFullPath(Path.Combine(path, "../../../wwwroot/PersonOfTheYear.csv"));
            string[] csvValues = File.ReadAllLines(fullPath);
            //perform the following on each line of the read in csv file
            for (int i = 1; i < csvValues.Length; i++)
            {
                string[] personValues = csvValues[i].Split(",");
                people.Add(new TimePerson
                {
                    Year = (personValues[0] == "") ? 0 : Convert.ToInt32(personValues[0]),
                    Honor = personValues[1],
                    Name = personValues[2],
                    Country = personValues[3],
                    BirthYear = (personValues[4] == "") ? 0 : Convert.ToInt32(personValues[4]),
                    DeathYear = (personValues[5] == "") ? 0 : Convert.ToInt32(personValues[5]),
                    Title = personValues[6],
                    Category = personValues[7],
                    Context = personValues[8]
                });
            }
            if (begYear < endYear)
            {
                List<TimePerson> filteredList = people.Where(j => (j.Year >= begYear) && (j.Year <= endYear)).ToList();
                return filteredList;

            }
            else
            {
                return people;
            }
        }

    }
}
