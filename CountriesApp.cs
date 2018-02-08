using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    static class CountriesApp
    {

        public static void menu()
        {
            Console.WriteLine("\nHere is the list of countries: \n");
            
            foreach (Countries c in CountriesList.countries)
            {
                Console.WriteLine( c.GetName() );
            }
            Console.WriteLine();
            selection();
        }
        
        public static void selection()
        {
            Console.WriteLine("\n1: Display list of Countries \n2: Add a new Country \n3: Delete a Country \n4: Exit");
            string input = Console.ReadLine();
            int valid = validate(input);

            if (valid == 1)
            {
                menu();
            }
            else if (valid == 2)
            {
                Console.Write("Enter the name of the new Country: ");
                string country = Console.ReadLine();
                Countries userCountry = new Countries(country);
                CountriesList.countries.Add(userCountry);
                CountriesTextFile.write();
            }
            else if (valid ==3)
            {
                int i = 0;
                foreach (Countries c in CountriesList.countries)
                {
                    Console.WriteLine("[ " + i + " ]"  + c.GetName());
                    i++;
                }
                
                Console.Write("Enter the number of the country you want to remove from the list:");
                string userInput = Console.ReadLine();
                int validNum = validate(userInput);
                //fix out of range
                try
                {
                    CountriesList.countries.RemoveAt(validNum);
                }
                catch
                {
                    Console.WriteLine("Invalid number entered. Try again.");
                    selection();
                }
                CountriesTextFile.write();
                menu();
            }
            else if (valid == 4)
            {
                Console.WriteLine("Goodbye.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input. Must be a number 1 - 4");
                selection();
            }
            

        }

        public static int validate(string input)
        {
            if (int.TryParse(input, out int valid) != false)
            {
                
               return int.Parse(input);
            }
            else
            {
                Console.WriteLine("Invalid input, must enter a number 1 - 4");
                selection();
                return -1;
            }


        }

    }
}
