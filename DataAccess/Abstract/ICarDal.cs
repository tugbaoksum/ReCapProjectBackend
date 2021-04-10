using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
        List<CarDetailDto> GetCarDetailsByBrandId(int id);
        List<CarDetailDto> GetCarDetailsByColorId(int id);
        List<CarDetailDto> GetCarImageByCarId(int id);
        List<CarDetailDto> GetCarDetailsByColorAndBrandId(int colorid, int brandid);
        List<CarDetailDto> GetCarDetailsByCarId(int id);
        
        }
}
