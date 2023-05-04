using Microsoft.EntityFrameworkCore;
using pharmacies.config;
using pharmacies.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        public Firm findFirmByName(String name)
        {
            try
            {
                return db.Firms.Where(p => p.Name == name).ToList().First();
            }
            catch
            {
                return null;
            }
        }

        public Firm findFirmById(int id)
        {
            return db.Firms.Where(p => p.Id == id).First();
        }

        public void delete(Firm firm)
        {
            db.Firms.Remove(firm);
            db.SaveChanges();
        }


        public List<Firm> findAllFirms()
        {
            return db.Firms.Include(c => c.Medicines).ToList();
        }
    }
}
