using pharmacies.repository;
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
    public partial class ReadMedicineForm : Form
    {
        MedicineServiceImpl medicineServiceImpl = new MedicineServiceImpl();

        public ReadMedicineForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Наименование";
            dataGridView1.Columns[2].Name = "Вид упаковки";
            dataGridView1.Columns[3].Name = "Способ употребления";
            dataGridView1.Columns[4].Name = "Цена";
            dataGridView1.Columns[5].Name = "Изготовитель";
            dataGridView1.Columns[6].Name = "Противопоказания";
            dataGridView1.Columns[7].Name = "Срок годности";

            int i = 0;
            foreach(var medicine in medicineServiceImpl.getAll())
            {
                dataGridView1.Rows[i].Cells[0].Value = medicine.Id;
                dataGridView1.Rows[i].Cells[1].Value = medicine.Name;
                dataGridView1.Rows[i].Cells[2].Value = medicine.getFormatTypeOfPackaging();
                dataGridView1.Rows[i].Cells[3].Value = medicine.getFormatMethodOfConsumption();
                dataGridView1.Rows[i].Cells[4].Value = medicine.Cost;
                dataGridView1.Rows[i].Cells[5].Value = medicine.Firm.Name;
                dataGridView1.Rows[i].Cells[6].Value = medicine.Contraindications;
                dataGridView1.Rows[i].Cells[7].Value = medicine.BestBeforeDate;
                i++;
            }
        }
    }
}
