using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class CarPassport
    {
        //private Driver _owner;

        //public Driver Owner
        //{
        //    get
        //    {
        //        return _owner;
        //    }
        //    set
        //    {
        //        _owner = value;
        //    }
        //}

        //автоматическое св-во
        public Driver Owner
        { get; set; }

        public readonly Car Car;//это свойство с гет

        public CarPassport(Car car)
        {
            Car = car;
        }
    }
}
