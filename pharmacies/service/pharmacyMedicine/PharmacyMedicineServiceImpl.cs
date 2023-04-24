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
        public bool savePharmacyMedicine(PharmacyMedicine pharmacyMedicine)
        {
            pharmacyMedicineRepository.save(pharmacyMedicine);
            return true;
        }
    }
}
