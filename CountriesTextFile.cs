using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    static class CountriesTextFile
    {
        const string filePath = @"C:\Users\aManHasNoName\source\repos\Lab15\countries.txt";


    

        public static void read()
        {

            try
            {
                StreamReader reader = new StreamReader(filePath);

                while (reader.EndOfStream != true)
                {
                    string line = reader.ReadLine();
                    Countries country = new Countries(line);
                    CountriesList.countries.Add(country);
                }


                reader.Close();
                CountriesApp.selection();

            }
            catch
            {
                Console.WriteLine("Error reading file...");
                CountriesApp.selection();
            }
        }

        public static void delete()
        {
            try
            {
                StreamWriter writer = new StreamWriter(filePath);
                foreach (Countries c in CountriesList.countries)
                {
                    writer.Write(c.GetName() + "\n");
                }
                Console.WriteLine("Country removed successfully.");
                CountriesApp.selection();
                //fix clearing of whole list?
                writer.Close();
            }
            catch
            {
                Console.WriteLine("An error occurred trying to delete a country");
                CountriesApp.selection();
            }
        }

        public static void write()
        {
           
            try
            {
                StreamWriter writer = new StreamWriter(filePath);

                

                Console.WriteLine("Writing to file...");

                foreach (Countries c in CountriesList.countries)
                {
                    writer.Write(c.GetName() + "\n");
                }

                System.Threading.Thread.Sleep(300);
                Console.WriteLine("Write complete.");
                writer.Close();
                CountriesApp.selection();

            }
            catch
            {
                Console.WriteLine("Error writing to file.");
                CountriesApp.selection();

            }

        }      
    }
}
