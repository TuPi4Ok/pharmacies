using Microsoft.EntityFrameworkCore;
using pharmacies.config;
using pharmacies.model;
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

        public List<Medicine> findAllMedicines()
        {
            try 
            {
                return db.Medicines.Include(c => c.Discount).Include(c => c.Firm).Include(c => c.PharmacyMedicine).ToList();
            } catch { return null; }
            
        }
    }
}
