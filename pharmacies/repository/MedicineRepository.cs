using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;
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

        public List<Medicine> findMedicineByBestBeforeDate(Pharmacy pharmacy1)
        {
            return (from medicine in db.Medicines
                   join pharmacyMedicine in db.PharmacyMedicines on medicine.Id equals pharmacyMedicine.MedicineId
                   join pharmacy in db.Pharmacys on pharmacyMedicine.PharmacyId equals pharmacy.Id
                   where pharmacy.Id == pharmacy1.Id && medicine.BestBeforeDate.Month == DateTime.Now.Month
                   select medicine).ToList();
        }

        public List<Medicine> findMedicineByFirmInPharmacy(Pharmacy pharmacy1, Firm firm1)
        {
            return (from medicine in db.Medicines
                    join firm in db.Firms on medicine.FirmId equals firm.Id
                    join pharmacyMedicine in db.PharmacyMedicines on medicine.Id equals pharmacyMedicine.MedicineId
                    join pharmacy in db.Pharmacys on pharmacyMedicine.PharmacyId equals pharmacy.Id
                    where pharmacy.Id == pharmacy1.Id && medicine.BestBeforeDate > DateTime.Now && firm.Id == firm1.Id
                    select medicine).ToList();
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
