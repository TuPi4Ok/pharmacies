using pharmacies.service.madicine;
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

namespace pharmacies.controller.admin.Read
{
    public partial class ReadPharmacyForm : Form
    {
        PharmacyServiceImpl pharmacyService = new PharmacyServiceImpl();
        public ReadPharmacyForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Наименование";
            dataGridView1.Columns[2].Name = "Адрес";

            int i = 0;
            foreach (var pharmacy in pharmacyService.getAll())
            {
                dataGridView1.Rows[i].Cells[0].Value = pharmacy.Id;
                dataGridView1.Rows[i].Cells[1].Value = pharmacy.Name;
                dataGridView1.Rows[i].Cells[2].Value = pharmacy.Address;
                i++;
            }
        }
    }
}
