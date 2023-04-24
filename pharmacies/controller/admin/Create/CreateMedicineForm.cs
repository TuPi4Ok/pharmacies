using pharmacies.model;
using pharmacies.repository;
using pharmacies.service.pharmacy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacies.controller.admin.Create
{
    public partial class CreateMedicineForm : Form
    {
        PharmacyServiceImpl pharmacyService = new PharmacyServiceImpl();

        public CreateMedicineForm()
        {
            InitializeComponent();
            List<Pharmacy> pharmacies = pharmacyService.getAll();
            PharmacyList.Items.AddRange(pharmacies.ToArray());

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
