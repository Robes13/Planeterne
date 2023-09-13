using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planet
{
    /// <summary>
    /// This class houses all the planets that will be inserted later on.
    /// </summary>
    internal class Planet
    {
        #region Fields

        private string _name;
        private float _temperature;
        private double _diameter;

        #endregion Fields

        #region Constructors

        public Planet(string name, float temperature, double diameter)
        {
            _name = name;
            _temperature = temperature;
            _diameter = diameter;
        }
        #endregion Constructors

        #region Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public float Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        public double Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }
        #endregion Properties

    }
}
