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
    }
}
