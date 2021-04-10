using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {


        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 ColorName = color.ColorName,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear= car.ModelYear,
                                 Description=car.Description,
                                 CarId=car.Id


                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByBrandId(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             where (brand.BrandId==id)
                             select new CarDetailDto
                             {
                                 ColorName = color.ColorName,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description


                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColorId(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             where (color.ColorId==id)
                             select new CarDetailDto
                            
                             {
                                 ColorName = color.ColorName,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description


                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarImageByCarId(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join image in context.CarImages
                             on car.Id equals image.CarId
                             where (image.CarId == id)
                             select new CarDetailDto

                             {
                                 ColorName = color.ColorName,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description,
                                 ImagePath=image.ImagePath,
                                 CarId=car.Id
                                 


                             };
                return result.ToList();
            }
        }
        public List<CarDetailDto> GetCarDetailsByColorAndBrandId(int colorid, int brandid) { 
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join image in context.CarImages
                             on car.Id equals image.CarId
                             where (brand.BrandId == brandid && color.ColorId == colorid)
                             select new CarDetailDto

                             {
                                 ColorName = color.ColorName,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description,
                                 ImagePath = image.ImagePath,
                                 CarId = car.Id



                             };
                return result.ToList();
            }
        }
        public List<CarDetailDto> GetCarDetailsByCarId(int id)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             where (car.Id==id)
                             select new CarDetailDto
                             {
                                 ColorName = color.ColorName,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description


                             };
                return result.ToList();
            }
        }
    }
}