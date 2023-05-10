using pharmacies.model;
using pharmacies.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.service.pharmacyMedicine
{
    internal class PharmacyMedicineServiceImpl : PharmacyMedicineService
    {
        PharmacyMedicineRepository pharmacyMedicineRepository = new PharmacyMedicineRepository();

        public List<PharmacyMedicine> getPharmacyMedicinesByMedicineId(int id)
        {
            return pharmacyMedicineRepository.findPharmacyMedicineByMedecineId(id);
        }

        public List<PharmacyMedicine> getPharmacyMedicinesByPharmacyId(int id)
        {
            return pharmacyMedicineRepository.findPharmacyMedicineByPharmacyId(id);
        }

        public bool savePharmacyMedicine(PharmacyMedicine pharmacyMedicine)
        {
            pharmacyMedicineRepository.save(pharmacyMedicine);
            return true;
        }

        public void updatePharmacyMedicineByMedicine(Medicine medicine, List<Pharmacy> pharmacies)
        {
            foreach(var pharmacyMedicine in pharmacyMedicineRepository.findPharmacyMedicineByMedecineId(medicine.Id))
            {
                pharmacyMedicineRepository.delete(pharmacyMedicine);
            }

            foreach(var pharmacy in pharmacies)
            {
                PharmacyMedicine pharmacyMedicine = new PharmacyMedicine();
                pharmacyMedicine.PharmacyId = pharmacy.Id;
                pharmacyMedicine.MedicineId = medicine.Id;
                pharmacyMedicineRepository.save(pharmacyMedicine);
            }
        }

        public void updatePharmacyMedicineByPharmasy(Pharmacy pharmacy, List<Medicine> medicines)
        {
            foreach (var pharmacyMedicine in pharmacyMedicineRepository.findPharmacyMedicineByPharmacyId(pharmacy.Id))
            {
                pharmacyMedicineRepository.delete(pharmacyMedicine);
            }

            foreach (var medicine in medicines)
            {
                PharmacyMedicine pharmacyMedicine = new PharmacyMedicine();
                pharmacyMedicine.PharmacyId = pharmacy.Id;
                pharmacyMedicine.MedicineId = medicine.Id;
                pharmacyMedicineRepository.save(pharmacyMedicine);
            }
        }
    }
}
