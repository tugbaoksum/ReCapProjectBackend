using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from rental in context.Rentalss
                             join brand in context.Brands
                             on rental.CarId equals brand.BrandId

                             join customer in context.Customers
                             on rental.CustomerId equals customer.CustomerId
                             select new RentalDetailDto
                             {
                                 CompanyName = customer.CompanyName,
                                 BrandName = brand.BrandName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                                            

                             };
                return result.ToList();
            }
        }
    }
}
