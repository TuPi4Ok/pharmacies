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
        private String Name;
        private String address;
        private String telephoneNumber;
        List<Medicine> medicines;

        public int Id { get => id; set => id = value; }
        public string TelephoneNumber { get => telephoneNumber; set => telephoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Name1 { get => Name; set => Name = value; }
        internal List<Medicine> Medicines { get => medicines; set => medicines = value; }
    }
}
