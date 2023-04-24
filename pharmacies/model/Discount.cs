using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.model
{
    public class Discount
    {
        private int id;
        private int percent;
        //private int medicineId;
        private Medicine medicine;

        public int Id { get => id; set => id = value; }
        public int Percent { get => percent; set => percent = value; }
        //public int MedicineId { get => medicineId; set => medicineId = value; }
        internal Medicine Medicine { get => medicine; set => medicine = value; }
    }
}
