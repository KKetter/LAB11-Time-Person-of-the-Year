using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LAB11_TIMEPERSONOFTHEYEAR.Models
{
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
                TimePerson holdsValuePriorToPeopleList = new TimePerson()
                {

                    Year = Convert.ToInt32(personValues[0]),
                    Honor = personValues[1],
                    Name = personValues[2],
                    Country = personValues[3],
                    BirthYear = Convert.ToInt32(personValues[4]),
                    DeathYear = Convert.ToInt32(personValues[5]),
                    Title = personValues[6],
                    Category = personValues[7],
                    Context = personValues[8]
                };
                people.Add(holdsValuePriorToPeopleList);

                //next step - LINQ query to filter
            }

            //iterate through array and set values appropiately
            //csv is comma delimated 
            //create the full list of peoples from the csv file
            //THEN do the LINQ query (with Lambda expression) to filter

            //people.Add();

            //Amandas where
            //List<TimePerson> listofPeople = people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();

            return people;
        }

    }
}
