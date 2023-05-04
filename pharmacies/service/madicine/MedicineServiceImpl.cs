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
    }
}
