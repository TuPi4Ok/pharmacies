using pharmacies.service.discount;
using pharmacies.service.firm;
using pharmacies.service.madicine;
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
    public partial class ReadFirmForm : Form
    {
        FirmServiceImpl firmService = new FirmServiceImpl();
        public ReadFirmForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = firmService.getAll().Count;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Наименование";
            dataGridView1.Columns[2].Name = "Адрес";
            dataGridView1.Columns[3].Name = "Номер телефона";

            int i = 0;
            foreach (var firm in firmService.getAll())
            {
                dataGridView1.Rows[i].Cells[0].Value = firm.Id;
                dataGridView1.Rows[i].Cells[1].Value = firm.Name;
                dataGridView1.Rows[i].Cells[2].Value = firm.Address;
                dataGridView1.Rows[i].Cells[3].Value = firm.TelephoneNumber;
                i++;
            }
        }
    }
}
