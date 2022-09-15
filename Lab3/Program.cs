// See https://aka.ms/new-console-template for more information
using Lab3;

List<Person> people = new List<Person>();

var option = 0;
do
{
    DisplayMenu();
    option = Int32.Parse(Console.ReadLine());
    MenuChoice(option);

    Console.WriteLine("\nHit Enter to return to menu...");
    Console.ReadLine();
    Console.Clear();
} while (option != 0);
    



static void DisplayMenu()
{
    Console.WriteLine("------ Menu ------");
    Console.WriteLine("1. Create a new Person");
    Console.WriteLine("2. View all people");
    Console.WriteLine("3. Remove a person from the list");
    Console.WriteLine("4. Display a random last name");
    Console.WriteLine("5. Create and View Random SSN");
    Console.WriteLine("6. Display someone's phone number at random");
    Console.WriteLine("0. Exit");
    Console.WriteLine("------------------");
}

void MenuChoice(int option)
{
    Random random = new Random();
    switch (option)
    {
        //create new person and add to people list
        case 1:
            people.Add(new Person());
            break;

        //Displays all people
        case 2:
            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }
            break;

        //Removes the last person added from the list
        case 3:

            Console.WriteLine(people[people.Count() - 1].FirstName + " " + people[people.Count() - 1].LastName + " has been removed.");
            people.Remove(people[people.Count() - 1]);

            break;

        //Display a random last name
        case 4:
            Person rand = people[random.Next(people.Count())];
            Console.WriteLine(rand.LastName);
            break;


        //Gets random person and displays their SSN
        case 5:
            Person rando = people[random.Next(people.Count())];
            Console.WriteLine(rando.SSN);
            break;

        //Displays a random phone number pulled from someone on the people list
        case 6:
            Person rnd = people[random.Next(people.Count())];

            /****could not figure out the separator, however below is my attempt****/
                //Console.WriteLine("Please enter your separator");
                //char sep = (char)Console.Read();
                //Console.Clear();
                //rnd.Phone.Format(sep);
            Console.WriteLine(rnd.FirstName + " " + rnd.LastName + ": " + rnd.Phone.ToString());
            break;

        //Exits program
        case 0:
            Console.WriteLine("See ya!");
            break;

        //If user enters invalid option
        default:
            Console.WriteLine("Invalid option. Can you read?");
            break;
    }
}



