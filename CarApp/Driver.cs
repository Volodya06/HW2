using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Driver
    {
        //readonly - может инициализироваться только в конструкторе или при объявлении
        public readonly DateTime LicenseDate; //дата выдачи прав
        public readonly string Name;

        //private readonly DateTime date;

        //public DateTime Date
        //{
        //    get
        //    {
        //        return date;
        //    }
        //}

        private List<string> _listCategory = new List<string>();

        public int Experience
        {
            get
            {
                return DateTime.Now.Year - LicenseDate.Year;
            }
        }

        public List<string> ListCategory
        {
            get
            {
                return _listCategory;
            }
        }

        private Car _car;

        public Car Car
        {
            private set
            {
                _car = value;
            }
            get
            {
                return _car;
            }
        }

        public void OwnCar(Car car)
        {
            if (ListCategory.Contains(car.Category) == false)
            {
                string str = string.Format("У водителя {0} нету прав категории {1}", Name, car.Category);
                throw new Exception(str);
            }
            else
            {
                Car = car;
            }
        }

        public Driver(DateTime licenseDate, string name)
        {
            LicenseDate = licenseDate;
            Name = name;
        }
    }
}
