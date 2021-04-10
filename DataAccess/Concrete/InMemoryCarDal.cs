using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId=3,ColorId = 1, DailyPrice=15000, ModelYear=2021,Description="Açıklama"},
                new Car{ Id=2, BrandId=1,ColorId = 2, DailyPrice=30000, ModelYear=1995,Description="Açıklama"},
                new Car{ Id=3, BrandId=2,ColorId = 2, DailyPrice=4500, ModelYear=1999,Description="Açıklama"},
                new Car{ Id=4, BrandId=3,ColorId = 3, DailyPrice=25000, ModelYear=2009,Description="Açıklama"},
                new Car{ Id=5, BrandId=3,ColorId = 4, DailyPrice=15000, ModelYear=2002,Description="Açıklama"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car) //referans tür direkt remove olarak silinmez linq kullanacağız.
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id); //tek tek dolasmaya karsılık geliyor foreach yapısı gibi.
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars; //veritabanındaki ürünlerin tamamını döndürür.
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList(); //where kosulu içindeki şarta uyan bütün elemanları yeni bir liste haline getirip onu döndürür.
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByCarId(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByColorAndBrandId(int colorid, int brandid)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarImageByCarId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id); //gönderdiğim araba id'sine sahip olan listedeki ürünü bul demek.
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
