using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_each_loop_demo_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TOPIC:
            // for-each loop in C#

            // DESCRIPTION:
            // This code demonstrates
            // the use of a for-each loop
            // to iterate over a collection
            // of integers.

            try
            {
                DemoForEachLoop();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

        static void DemoForEachLoop()
        {
            String[] cars = {"Nissan", "Mazda", "Toyota"};
            int count = 1;

            foreach (String car in cars) 
            { 
                Console.WriteLine($"CAR {count}: {car}");
                count++;
            }
        }
    }
}
