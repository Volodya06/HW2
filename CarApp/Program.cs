using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("D", "Лада");
            car.Color = Color.Black;

            try
            {
                //if (car.Driver != null)
                 Console.WriteLine(car.Driver.Name);
            }
            catch(Exception exc)
            {
                //задание сделать информативный вывод
                Console.WriteLine("Ошибка");
            }
            
            DateTime date1 = new DateTime(2013, 5, 4);
            Driver driver1 = new Driver(date1, "Вольдемар");
            driver1.ListCategory.Add("B");
            driver1.ListCategory.Add("C");

            try
            {
                //наняли водителя
                car.Driver = driver1;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            try
            {
                //сменили водителя
                car.ChangeOwner(driver1, "o777oo");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

                driver1.ListCategory.Add("D");

                car.ChangeOwner(driver1, "o777oo");

                Console.WriteLine(car.CarNumber);
                Console.WriteLine(car.Driver.Name);
            

            //int exper = driver1.Experience;

            
            Console.ReadLine();
        }
    }
}
