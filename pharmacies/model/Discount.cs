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
        private int MedicineId;
        private Medicine medicine;

        public int Id { get => id; set => id = value; }
        public int Percent { get => percent; set => percent = value; }
        public int MedicineId1 { get => MedicineId; set => MedicineId = value; }
        internal Medicine Medicine { get => medicine; set => medicine = value; }
    }
}
