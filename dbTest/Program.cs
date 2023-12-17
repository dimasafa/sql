// See https://aka.ms/new-console-template for more information


using dbTest.Data;
using dbTest.Models;

namespace HelloWorld
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            DataContextEF entityFramework = new DataContextEF();

            Computer myComtuter = new Computer()
            {
                Nummer = 1232,
                CPU = "intel i5-2262",
                VideoCard = "RTX 3060Ti",
                Price = 943.87m
            };

            entityFramework.Add(myComtuter);
            entityFramework.SaveChanges();

            // Get alle Daten zum variable.
            IEnumerable<Computer> computersEf = entityFramework.Computer.ToList();
            
            
            if (computersEf != null)
            {
                Console.WriteLine("'ComputerId', 'Nummer', 'CPU', 'VideoCard', 'Price'");

                foreach (Computer computer in computersEf)
                {
                    Console.WriteLine("'" + computer.ComputerId
                        + "','" + computer.Nummer
                        + "','" + computer.CPU
                        + "','" + computer.VideoCard
                        + "','" + computer.Price);
                }
            }
        }
    }

}