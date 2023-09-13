using Planet;
using Planeterne.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    /// <summary>
    /// This class is responsible for inserting data into our model in the correct way, and it also houses some
    /// methods that is used for handling our data.
    /// </summary>
    internal class Controller
    {
        public void Start()
        {
            // Adding all planets to our list in the correct order.
            Planet.Planet mercury = new Planet.Planet("Merkur", 167, 4879.4);
            Planet.Planet earth = new Planet.Planet("Earth", 15, 12742);
            Planet.Planet mars = new Planet.Planet("Mars", -63, 6779);
            Planet.Planet jupiter = new Planet.Planet("Jupiter", -145, 139820);
            Planet.Planet saturn = new Planet.Planet("Saturn", -178, 116460);
            Planet.Planet uranus = new Planet.Planet("Uranus", -195, 50724);
            Planet.Planet neptune = new Planet.Planet("Neptune", -200, 49244);
            Planet.Planet pluto = new Planet.Planet("Pluto", -232, 2376.6);
            // Adding them all at once
            List<Planet.Planet> planets = new List<Planet.Planet>()
            {
                mercury, earth, mars, jupiter, saturn, uranus, neptune, pluto
            };
            Gui gui = new Gui();
            gui.PrintList(planets);
            Planet.Planet venus = new Planet.Planet("Venus", 464, 12104);
            // Inserting venus at the correct place.
            planets.Insert(1, venus);


            gui.PrintNext();
            // Finding the index of Pluto and removing it
            int plutoIndex = FindIndex(planets, "Pluto");
            planets.RemoveAt(planets.IndexOf(pluto));


            gui.PrintList(planets);
            gui.PrintNext();
            // Inserting Pluto at the correct place again.
            planets.Insert(plutoIndex, pluto);

            // Printing the number of planets.
            gui.PrintNumberOfPlanets(planets);
            gui.PrintNext();

            // Creating a new list for the planets with a minus temperature, and finding them using the method below.
            List<Planet.Planet> meanTemperature = MeanTemperature(planets);
            gui.PrintList(meanTemperature);
            gui.PrintNext();

            // Creating a new list for the planets with a diameter bigger than 10.000 and smaller than 50.000, and finding them using 
            // the Method below.
            List<Planet.Planet> findBigPlanets = FindBigPlanets(planets);
            gui.PrintList(findBigPlanets);


            gui.PrintNext();
            gui.RemoveAll();
            RemoveAll(planets);
            gui.PrintList(planets);
            gui.ExitProgram();
            ExitProgram();
        }
        /// <summary>
        /// This method finds the index of a planet and returns it.
        /// </summary>
        /// <param name="planets"> the list we need to find a planet from</param>
        /// <param name="planetFind"> the planet we want to find</param>
        /// <returns> the index of the planet we want to find</returns>
        public int FindIndex(List<Planet.Planet> planets, string planetFind)
        {
            int count = 0;
            int findIndex = 0;
            foreach (Planet.Planet planet in planets)
            {
                if (planet.Name == planetFind)
                {
                    findIndex = count; break;
                }
                count++;
            }
            return findIndex;
        }
        /// <summary>
        /// This method returns a list of all the planets with a sub zero temperature.
        /// </summary>
        /// <param name="planets"> the list of planets we want to find sub zero planets from.</param>
        /// <returns> a new list with said sub zero planets.</returns>
        public List<Planet.Planet> MeanTemperature(List<Planet.Planet> planets)
        {
            List<Planet.Planet> meanTemperature = new List<Planet.Planet>();
            foreach (Planet.Planet planet in planets)
            {
                if (planet.Temperature < 0)
                {
                    meanTemperature.Add(planet);
                }
            }
            return meanTemperature;
        }
        /// <summary>
        /// This method finds the all planets with a diameter bigger than 10.000 and smaller than 50.000
        /// And returns it in a new list.
        /// </summary>
        /// <param name="planets"> The list where we will be looking for the planets</param>
        /// <returns> New list with the specified planets we want</returns>
        public List<Planet.Planet> FindBigPlanets(List<Planet.Planet> planets)
        {
            List<Planet.Planet> FindBigPlanets = new List<Planet.Planet>();
            foreach (Planet.Planet planet in planets)
            {
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                {
                    FindBigPlanets.Add(planet);
                }
            }
            return FindBigPlanets;
        }
        /// <summary>
        /// Removes every item from a list.
        /// </summary>
        /// <param name="planets"></param>
        public void RemoveAll(List<Planet.Planet> planets)
        {
            planets.Clear();
        }
        /// <summary>
        /// Closes the program.
        /// </summary>
        public void ExitProgram()
        {
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
