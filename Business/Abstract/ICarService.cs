using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult AddTransactionalTest(Car car);

        IDataResult<List<CarDetailDto>>GetCarImageByCarId(int id);

        IDataResult<List<CarDetailDto>> GetCarDetailsByColorAndBrandId(int colorid, int brandid);
        IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int id);
        
        }
}