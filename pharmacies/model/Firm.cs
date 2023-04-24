using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.model
{
    public class Firm
    {
        private int id;
        private String name;
        private String address;
        private String telephoneNumber;
        List<Medicine> medicines;

        public int Id { get => id; set => id = value; }
        public string TelephoneNumber { get => telephoneNumber; set => telephoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Name { get => name; set => name = value; }
        internal List<Medicine> Medicines { get => medicines; set => medicines = value; }
    }
}
