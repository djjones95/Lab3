using System;
namespace Lab3
{
    public class Person
    {
        //Backing fields
        private string firstName;
        private string lastName;

        //Array of first names
        private string[] _arrayOfFirstNames = new string[]
        {"DJ","Sarah","Matt","Jill","Tom","Jane","John","Tori","Levi","Rachel"};

        private Dependent[] dependents;

        //Properties

        //First name
        public string FirstName
        {
            get { return firstName; }
            init { firstName = value; }
            //this means that this value un firstName is essentially final for this specific Person object and cannot be changed
        }

        //Last name
        public string LastName
        {
            get { return lastName; }
            init { lastName = value; }
        }

        //Birthday
        public DateTime BirthDate
        {
            get;
            init;
        }

        //Social Security Number
        public SSN SSN
        {
            get;
            init;
        }

        //Phone number
        public Phone Phone
        {
            get;
            init;
        }


        //Constructor
        public Person()
        {
            this.firstName = FirstName = GenerateFirstName();
            this.lastName = LastName = GenerateLastName();
            this.SSN =  new SSN();
            this.Phone = new Phone();

            //Birthdate Logic
            Random rnd = new Random();
            DateTime dateToday = DateTime.Now;
            int year = rnd.Next(dateToday.Year - 81, dateToday.Year - 19);
            int month = rnd.Next(1, 12);
            int day = rnd.Next(1, 31);
            this.BirthDate = new DateTime(year, month, day);



        }

        //Generates random first name from provided array
        public string GenerateFirstName()
        {
            Random rnd = new Random();
            int pullRandomName = rnd.Next(9);
            return _arrayOfFirstNames[pullRandomName];
        }

        //Generates random last name from provided Enum
        public string GenerateLastName()
        {
            Random rnd = new Random();
            int pullRandomName = rnd.Next(9);
            string LName = "";
            if(pullRandomName == (int)Lab3.LastName.Smith)
            {
                LName = Lab3.LastName.Smith.ToString();
            }
            else if(pullRandomName == (int)Lab3.LastName.Jones)
            {
                LName = Lab3.LastName.Jones.ToString();
            }
            else if(pullRandomName == (int)Lab3.LastName.Johnson)
            {
                LName = Lab3.LastName.Johnson.ToString();
            }
            else if (pullRandomName == (int)Lab3.LastName.Clark)
            {
                LName = Lab3.LastName.Clark.ToString();
            }
            else if (pullRandomName == (int)Lab3.LastName.Way)
            {
                LName = Lab3.LastName.Way.ToString();
            }
            else if (pullRandomName == (int)Lab3.LastName.Carrier)
            {
                LName = Lab3.LastName.Carrier.ToString();
            }
            else if (pullRandomName == (int)Lab3.LastName.Edwards)
            {
                LName = Lab3.LastName.Edwards.ToString();
            }
            else if (pullRandomName == (int)Lab3.LastName.Bingham)
            {
                LName = Lab3.LastName.Bingham.ToString();
            }
            else if (pullRandomName == (int)Lab3.LastName.Griffith)
            {
                LName = Lab3.LastName.Griffith.ToString();
            }
            else if (pullRandomName == (int)Lab3.LastName.Hale)
            {
                LName = Lab3.LastName.Hale.ToString();
            }

            return LName;
        }

        //Returns persons age
        public int Age()
        {
            var age = DateTime.Now - BirthDate;
            return age.Days / 365;
        }

        //Formatted toString
        public override string ToString()
        {
            return
                $"-----------------------------------------\n" +
                $"Name:\t\t{FirstName} {LastName}\n" +
                $"Birthday:\t{BirthDate.ToShortDateString()}\n" +
                $"Age:\t\t{Age()}\n" +
                $"SSN:\t\t{SSN}\n" +
                $"Phone:\t\t{Phone.Number}\n" +
                $"-----------------------------------------\n";
        }




    }
}

