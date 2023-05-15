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
    class PharmacyRepository
    {

        MyApplicationContext db = new MyApplicationContext();

        public void save(Pharmacy pharmacy)
        {
            db.Pharmacys.Add(pharmacy);
            db.SaveChanges();
        }

        public Pharmacy findPharmacyByName(string name)
        {
            return db.Pharmacys.Include(p => p.PharmacyMedicine).Where(p => p.Name == name).FirstOrDefault();
        }

        public Pharmacy findPharmacyById(int id)
        {
            return db.Pharmacys.Where(p => p.Id == id).First();
        }

        public void delete(Pharmacy pharmacy)
        {
            db.Pharmacys.Remove(pharmacy);
            db.SaveChanges();
        }

        public List<Pharmacy> findPharmasyByMedicine(String medicine1)
        {
            return (from pharmasy in db.Pharmacys
                   join pharmacyMedicine in db.PharmacyMedicines on pharmasy.Id equals pharmacyMedicine.PharmacyId
                   join medicine in db.Medicines on pharmacyMedicine.MedicineId equals medicine.Id
                   where medicine1 == medicine.Name && medicine.BestBeforeDate > DateTime.Now
                   select pharmasy).ToList();
        }

        public List<Pharmacy> findPharmasyByMedicineCost(String medicine1)
        {
            return (from pharmasy in db.Pharmacys
                    join pharmacyMedicine in db.PharmacyMedicines on pharmasy.Id equals pharmacyMedicine.PharmacyId
                    join medicine in db.Medicines on pharmacyMedicine.MedicineId equals medicine.Id
                    join discount in db.Discounts on medicine.Id equals discount.Id
                    orderby medicine.Cost * ((100 - discount.Percent) / 100)
                    where medicine1 == medicine.Name && medicine.BestBeforeDate > DateTime.Now
                    select pharmasy).ToList();
        }

        public List<Pharmacy> findAllPharmacies()
        {
            return db.Pharmacys.Include(c => c.PharmacyMedicine).ToList();
        }

        public void update(Pharmacy pharmacy)
        {
            db.Pharmacys.Update(pharmacy);
            db.SaveChanges();
        }
    }
}
