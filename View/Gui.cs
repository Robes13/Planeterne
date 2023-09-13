using Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne.View
{
    /// <summary>
    /// This class is used to print everything
    /// </summary>
    internal class Gui
    {
        /// <summary>
        /// This method takes a list and prints every element in console.
        /// </summary>
        /// <param name="planets"> The list that will be printed</param>
        public void PrintList(List<Planet.Planet> planets)
        {
            foreach (Planet.Planet planet in planets)
            {
                Console.WriteLine(planet.Name + "\n" + planet.Temperature + " celcius\n" + planet.Diameter + " km\n");
            }
        }
        /// <summary>
        /// Waits for the user to be ready for next printed screen
        /// </summary>
        public void PrintNext()
        {
            Console.WriteLine("Press any key to show next assignment.");
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Printing the number of items in a list
        /// </summary>
        /// <param name="planets"> The list that will be counted and printed.</param>
        public void PrintNumberOfPlanets(List<Planet.Planet> planets)
        {
            Console.WriteLine(planets.Count() + " planets in the solar sytem.");
        }
        /// <summary>
        /// Waits for user to be ready to remove all from a list
        /// </summary>
        public void RemoveAll()
        {
            Console.WriteLine("Press any to delete every item from the list");
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Waits for user to be ready to exit program.
        /// </summary>
        public void ExitProgram()
        {
            Console.Clear();
            Console.WriteLine("Press any key to exit program....");
        }
    }
}
