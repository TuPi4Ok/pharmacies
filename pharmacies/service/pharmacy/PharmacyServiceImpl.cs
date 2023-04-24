using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacies.model;
using pharmacies.repository;

namespace pharmacies.service.pharmacy
{
    class PharmacyServiceImpl : PharmacyService
    {
        PharmacyRepository pharmacyRepository = new PharmacyRepository();

        public bool savePharmacy(Pharmacy pharmacy)
        {
            pharmacyRepository.save(pharmacy);
            return true;
        }
    }
}
