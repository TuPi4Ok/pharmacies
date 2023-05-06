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

        public List<Pharmacy> getAll()
        {
            return pharmacyRepository.findAllPharmacies();
        }

        public bool deletePharmacy(int id)
        {
            try
            {
                pharmacyRepository.delete(pharmacyRepository.findPharmacyById(id));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Pharmacy> WhereCanBuy(String medicine)
        {
            return pharmacyRepository.findPharmasyByMedicine(medicine);
        }

        public List<Pharmacy> WhereCanBuyCost(string medicine)
        {
            return pharmacyRepository.findPharmasyByMedicineCost(medicine);
        }

        public Pharmacy getPharmacyByName(string name)
        {
            return pharmacyRepository.findPharmacyByName(name);
        }
    }
}
