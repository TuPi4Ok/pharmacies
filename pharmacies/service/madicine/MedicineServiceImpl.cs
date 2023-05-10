using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacies.model;
using pharmacies.repository;

namespace pharmacies.service.madicine
{
    class MedicineServiceImpl : MedicineService
    {
        MedicineRepository medicineRepository = new MedicineRepository();

        public bool saveMedicine(Medicine medicine)
        {
            medicineRepository.save(medicine);
            return true;
        }

        public List<Medicine> getAll()
        {
            return medicineRepository.findAllMedicines();
        }

        public bool deleteMedicine(int id)
        {
            try
            {
                medicineRepository.delete(medicineRepository.findMedicineById(id));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Medicine> postingThisMonth(Pharmacy pharmacy)
        {
            return medicineRepository.findMedicineByBestBeforeDate(pharmacy);
        }

        public List<Medicine> getMedicinesByFirmAndPharmacy(Pharmacy pharmacy, Firm firm)
        {
            return medicineRepository.findMedicineByFirmInPharmacy(pharmacy, firm);
        }

        public void updateMedicine(Medicine medicine)
        {
            medicineRepository.update(medicine);
        }

        public Medicine getMedicineByName(string name)
        {
            return medicineRepository.findMedicineByName(name);
        }
    }
}
