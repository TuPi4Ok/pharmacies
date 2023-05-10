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

        public List<PharmacyMedicine> findPharmacyMedicineByPharmacyId(int id)
        {
            return db.PharmacyMedicines.Where(p => p.PharmacyId == id).ToList();
        }

        public List<PharmacyMedicine> findPharmacyMedicineByMedecineId(int id)
        {
            return db.PharmacyMedicines.Where(p => p.MedicineId == id).ToList();
        }

        public void delete(PharmacyMedicine pharmacyMedicine)
        {
            db.PharmacyMedicines.Remove(pharmacyMedicine);
            db.SaveChanges();
        }
    }
}
