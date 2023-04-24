using pharmacies.config;
using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.repository
{
    internal class PharmacyMedicineRepository
    {
        MyApplicationContext db = new MyApplicationContext();

        public void save(PharmacyMedicine pharmacyMedicine)
        {
            db.PharmacyMedicines.Add(pharmacyMedicine);
            db.SaveChanges();
        }
    }
}
