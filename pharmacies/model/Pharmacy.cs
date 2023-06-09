﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.model
{
    public class Pharmacy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        private int id;
        private string name;
        private String address;
        List<PharmacyMedicine> pharmacyMedicine;

        public int Id { get => id; set => id = value; }
        public string Address { get => address; set => address = value; }
        public string Name { get => name; set => name = value; }
        internal List<PharmacyMedicine> PharmacyMedicine { get => pharmacyMedicine; set => pharmacyMedicine = value; }
    }
}
