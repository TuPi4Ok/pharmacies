using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacies.model;
using pharmacies.repository;

namespace pharmacies.service.discount
{
    class DiscountServiceImpl : DiscountService
    {
        DiscountRepository discountRepository = new DiscountRepository();

        public bool deleteDiscount(int id)
        {
            try
            {
                discountRepository.delete(discountRepository.findDiscountById(id));
                return true;
            } 
            catch 
            {
                return false;
            }
        }

        public List<Discount> getAll()
        {
            return discountRepository.findAllDiscounts();
        }

        public bool saveDiscount(Discount discount)
        {
            discountRepository.save(discount);
            return true;
        }
    }
}
