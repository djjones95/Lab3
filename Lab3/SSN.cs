using System;
namespace Lab3
{
    public class SSN
    {
        //Propeties

        //Social Security Number
        public string Number
        {
            get;
            init;
        }

        //default constructor
        public SSN()
        {
            Number = GenerateInvalidSSN();
        }

        //Generates a random invalid SSN
        public string GenerateInvalidSSN()
        {
            string invalidSSN = "";
            Random rnd = new Random();

            //900-999
            var nineHundred = rnd.Next(900, 1000).ToString();

            var part1Array = new string[] { "000", "666", nineHundred };

            var part1 = part1Array[rnd.Next(3)];
            var part2 = "00";
            var part3 = "0000";

            invalidSSN = string.Concat(part1, part2, part3);

            return invalidSSN;
        }

        //Formatted toString
        public override string ToString()
        {
            string social = Number;
            social = social.Insert(3, "-");
            social = social.Insert(6, "-");

            return social;
        }
    }
}

