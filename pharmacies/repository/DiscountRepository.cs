using Microsoft.EntityFrameworkCore;
using pharmacies.config;
using pharmacies.model;
using Remotion.Linq.Clauses.ExpressionVisitors;
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

        public Discount findDiscountById(int id)
        {
            return db.Discounts.Where(p => p.Id == id).First();
        }

        public void delete(Discount discount)
        {
            db.Discounts.Remove(discount);
            db.SaveChanges();
        }

        public List<Discount> findAllDiscounts()
        {
            return db.Discounts.Include(c => c.Medicine).ToList();
        }
    }
}
