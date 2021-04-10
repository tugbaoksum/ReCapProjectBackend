using Business.Concrete;
using Bussiness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //CarBrandColor();
            RentalTest();
            
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result =rentalManager.Add(new Rental { CarId = 3, CustomerId = 3 ,RentDate=DateTime.Now});
            //UserManager userManager = new UserManager(new EfUserDal());
            //var result =userManager.Add(new User { FirstName = "Tugba", LastName = "Öksüm", Email = "tugba.oksum", Password = "fb" });
            Console.WriteLine(result.Message);
            //var result = rentalManager.GetAll();
            //if (result.Success == true)
            //{
            //    foreach (var rental in result.Data)
            //    {
            //        Console.WriteLine("Car with ID: " + rental.CarId );
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
        }

        private static void CarBrandColor()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + " " + car.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}