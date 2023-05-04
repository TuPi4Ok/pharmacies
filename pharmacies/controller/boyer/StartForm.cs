using pharmacies.model;
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

namespace pharmacies.controller.boyer
{
    public partial class StartForm : Form
    {
        MedicineServiceImpl medicineService = new MedicineServiceImpl();
        PharmacyServiceImpl pharmacyService = new PharmacyServiceImpl();
        public StartForm()
        {
            InitializeComponent();

            var allMedicines = medicineService.getAll();
            wellcome.Text = "Добро пожаловать, " + Login.Session.CurrentUser.UserName + "!";
            allMedicines = medicineService.getAll();

            if (allMedicines != null)
            {
                foreach (var medicine in allMedicines)
                {
                    if (medicine.Discount == null)
                    {
                        medicineBox.Items.Add(medicine.Name);
                    }

                }
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
            WhereCanBuy.Enabled = false;
            WhereCanBuyCost.Enabled = false;
        }

        private void buttonEnabled()
        {
            if(medicineBox.Text.Length > 0)
            {
                WhereCanBuy.Enabled = true;
                WhereCanBuyCost.Enabled = true;
            }
            else
            {
                WhereCanBuy.Enabled = false;
                WhereCanBuyCost.Enabled = false;
            }
        }

        private void WhereCanBuy_Click(object sender, EventArgs e)
        {
            List<Pharmacy> pharmacys = pharmacyService.WhereCanBuy(medicineBox.Text);
            String result = "Результат: ";
            foreach(var pharmasy in pharmacys)
            {
                result += pharmasy.Name + " " + pharmasy.Address + "\n";
            }
            if(result != "Результат: ")
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Ничего не найдено");
            }
        }

        private void medicineBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEnabled();
        }

        private void medicineBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void WhereCanBuyCost_Click(object sender, EventArgs e)
        {
            List<Pharmacy> pharmacys = pharmacyService.WhereCanBuyCost(medicineBox.Text);
            String result = "Результат(по возрастанию цены):\n";
            foreach (var pharmasy in pharmacys)
            {
                result += pharmasy.Name + " " + pharmasy.Address + "\n";
            }
            if (result != "Результат: ")
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Ничего не найдено");
            }
        }
    }
}
