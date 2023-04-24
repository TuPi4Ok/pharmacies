using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.model
{
    public class Pharmacy
    {
        private int id;
        private String address;
        List<PharmacyMedicine> pharmacyMedicine;

        public int Id { get => id; set => id = value; }
        public string Address { get => address; set => address = value; }
        internal List<PharmacyMedicine> PharmacyMedicine { get => pharmacyMedicine; set => pharmacyMedicine = value; }
    }
}
