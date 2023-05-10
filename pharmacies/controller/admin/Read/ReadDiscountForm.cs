using pharmacies.service.discount;
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
    public partial class ReadDiscountForm : Form
    {
        DiscountServiceImpl discountService = new DiscountServiceImpl();
        public ReadDiscountForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            dataGridView1.ColumnCount = 3;
            dataGridView1.RowCount = discountService.getAll().Count;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Процент";
            dataGridView1.Columns[2].Name = "Лекарство";

            int i = 0;
            foreach (var pharmacy in discountService.getAll())
            {
                dataGridView1.Rows[i].Cells[0].Value = pharmacy.Id;
                dataGridView1.Rows[i].Cells[1].Value = pharmacy.Percent;
                dataGridView1.Rows[i].Cells[2].Value = pharmacy.Medicine.Name;
                i++;
            }

        }
    }
}
