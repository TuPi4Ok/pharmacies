using pharmacies.config;
using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.repository
{
    class PharmacyRepository
    {

        MyApplicationContext db = new MyApplicationContext();

        public void save(Pharmacy pharmacy)
        {
            db.Pharmacies.Add(pharmacy);
            db.SaveChanges();
        }
    }
}
