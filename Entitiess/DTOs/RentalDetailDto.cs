using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class RentalDetailDto
    {
        public DateTime ? RentDate { get; set; }

        public string BrandName { get; set; }
        public string CompanyName { get; set; }
        public DateTime ? ReturnDate { get; set; }
    }
}
