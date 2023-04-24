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
        List<Medicine> medicines;

        public int Id { get => id; set => id = value; }
        public string Address { get => address; set => address = value; }
        internal List<Medicine> Medicines { get => medicines; set => medicines = value; }
    }
}
