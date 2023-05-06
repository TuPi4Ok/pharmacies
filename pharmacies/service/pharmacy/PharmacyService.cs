using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.service.pharmacy
{
    interface PharmacyService
    {
        bool savePharmacy(Pharmacy pharmacy);
        List<Pharmacy> getAll();
        bool deletePharmacy(int id);
        List<Pharmacy> WhereCanBuy(String medicine);
        List<Pharmacy> WhereCanBuyCost(String medicine);

        Pharmacy getPharmacyByName(String Name);
    }
}
