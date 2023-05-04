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
    class MedicineRepository
    {

        MyApplicationContext db = new MyApplicationContext();

        public void save(Medicine medicine)
        {
            db.Medicines.Add(medicine);
            db.SaveChanges();
        }

        public Medicine findMedicineById(int id)
        {
            return db.Medicines.Where(p => p.Id == id).First();
        }

        public void delete(Medicine medicine)
        {
            db.Medicines.Remove(medicine);
            db.SaveChanges();
        }

        public List<Medicine> findAllMedicines()
        {
            try 
            {
                return db.Medicines.Include(c => c.Discount).Include(c => c.Firm).Include(c => c.PharmacyMedicine).ToList();
            } catch { return null; }
            
        }
    }
}
