using pharmacies.config;
using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacies.repository
{
    class FirmRepository
    {

        MyApplicationContext db = new MyApplicationContext();

        public void save(Firm firm)
        {
            db.Firms.Add(firm);
            db.SaveChanges();
        }

        public List<Firm> findAllFirms()
        {
            return db.Firms.ToList();
        }
    }
}
