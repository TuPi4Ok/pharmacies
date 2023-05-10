using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.service.pharmacyMedicine
{
    internal interface PharmacyMedicineService
    {
        bool savePharmacyMedicine(PharmacyMedicine pharmacyMedicine);
        List<PharmacyMedicine> getPharmacyMedicinesByPharmacyId(int id);
        List<PharmacyMedicine> getPharmacyMedicinesByMedicineId(int id);
        void updatePharmacyMedicineByPharmasy(Pharmacy pharmacy, List<Medicine> medicines);
        void updatePharmacyMedicineByMedicine(Medicine medicine, List<Pharmacy> pharmacies);
    }
}
