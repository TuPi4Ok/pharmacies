using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.service.discount
{
    interface DiscountService
    {
        bool saveDiscount(Discount discount);

        List<Discount> getAll();

        bool deleteDiscount(int id);
    }
}
