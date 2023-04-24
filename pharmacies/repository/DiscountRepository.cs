using pharmacies.config;
using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.repository
{
    class DiscountRepository
    {

        MyApplicationContext db = new MyApplicationContext();

        public void save(Discount discount)
        {
            db.Discounts.Add(discount);
            db.SaveChanges();
        }
    }
}
