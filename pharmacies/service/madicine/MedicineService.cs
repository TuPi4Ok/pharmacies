﻿using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.service.madicine
{
    interface MedicineService
    {
        bool saveMedicine(Medicine medicine);
        List<Medicine> getAll();
    }
}
