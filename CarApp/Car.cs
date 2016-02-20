using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    //public enum Category
    //{
    //    A,
    //    B,
    //    C
    //}

    public class Car
    {
        #region Fields

        public readonly string Model;

        private Color _color = Color.Blue;

        private string _carNumber;

        public readonly string Category;

        public readonly CarPassport CarPasport;

        private Driver _driver;
        #endregion

        #region Properties

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public string CarNumber
        {
            get
            {
                return _carNumber;
            }
            private set
            {
                _carNumber = value;
            }
        }

        #endregion

        #region Constructors

        public Car(string category, string model)
        {
            Category = category;
            Model = model;

            CarPasport = new CarPassport(this);
        }
        #endregion

        #region Methods

        public void ChangeOwner(Driver driver, string carNumber)
        {
            driver.OwnCar(this);
            CarNumber = carNumber;
            CarPasport.Owner = driver;
        }
        #endregion
    }
}
