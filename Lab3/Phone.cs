using System;
namespace Lab3
{
    public class Phone
    {
        //Properties

        //Phone number
        public string Number
        {
            get;
            init;
        }

        //default constructor
        public Phone()
        {
            Number = Format();
        }

        //formats phone number by adding separator
        public string Format(char separator = '-')
        {
            string phoneNumber = "";
            Random rnd = new Random();
            int[] randomNumbers = new int[10];

            for(int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(10);
            }

            if (randomNumbers[0] == 0 || randomNumbers[0] == 1)
            {
                randomNumbers[0] = rnd.Next(2, 10);
            }

            foreach(int i in randomNumbers)
            {
                phoneNumber += i;
            }

            phoneNumber = phoneNumber.Insert(3, separator.ToString()).Insert(7, separator.ToString());

            return phoneNumber;
        }

        public override string ToString()
        {
            return Number;
        }
    }
}

