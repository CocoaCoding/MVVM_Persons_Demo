using System;
using System.Collections.Generic;

namespace MVVM_Persons_Demo
{
    public class RandomPersonGenerator
    {
        private static RandomPersonGenerator _instance;
        private static Random rnd;

        private List<string> firstNames = new List<string>();
        private List<string> lastNames = new List<string>();

        private RandomPersonGenerator()
        {
            rnd = new Random();
            this.firstNames.AddRange(new List<string>() { "Rose", "Billie", "Ben", "Ken", "Michael", "Thomas", "Mike", "Kenzie" });
            this.firstNames.AddRange(new List<string>() { "Jane", "John", "Russel", "George", "Kagney", "Arnold" });
            this.firstNames.AddRange(new List<string>() { "Bruce", "Steve", "Patty", "Bill", "Ted", "Peter", "David", "May", "Gwen" });
            
            this.lastNames.AddRange(new List<string>() { "Swift", "Piper", "Steele", "Rogers", "Stark", "Hawkins", "Lee", "Kirby" });
            this.lastNames.AddRange(new List<string>() { "Cambell", "Hart", "Jordan", "Fielding", "Crispin","Ford", "Jones" });
            this.lastNames.AddRange(new List<string>() { "Anderson", "Reeves", "Sagan", "Morgan", "Parker", "Watson" });
        }

        public static RandomPersonGenerator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new RandomPersonGenerator();
            }
            return _instance;
        }

        public Person Generate()
        {
            int r = rnd.Next(this.firstNames.Count);
            string firstNameRandom = this.firstNames[r];
           r = rnd.Next(this.lastNames.Count);
            string lastNameRandom = this.lastNames[r];

            DateTime startDate = new DateTime(1960, 1, 1);
            DateTime endDate = new DateTime(2010, 12, 31);

            TimeSpan timeSpan = endDate - startDate;
            TimeSpan newSpan = new TimeSpan(0, rnd.Next(0, (int)timeSpan.TotalMinutes), 0);
            DateTime dateRandom = startDate + newSpan;

            Person person = new Person();
            person.FirstName = firstNameRandom;
            person.LastName = lastNameRandom;
            person.Birthday = dateRandom;

            return person;
        }
    }
}
