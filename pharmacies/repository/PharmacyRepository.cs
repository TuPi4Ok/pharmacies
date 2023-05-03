using Microsoft.EntityFrameworkCore;
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
            db.Pharmacys.Add(pharmacy);
            db.SaveChanges();
        }

        public List<Pharmacy> findAllPharmacies()
        {
            return db.Pharmacys.Include(c => c.PharmacyMedicine).ToList();
        }
    }
}
