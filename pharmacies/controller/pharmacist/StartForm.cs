using pharmacies.model;
using pharmacies.service.firm;
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

namespace pharmacies.controller.pharmacist
{
    public partial class StartForm : Form
    {
        MedicineServiceImpl medicineService = new MedicineServiceImpl();
        PharmacyServiceImpl pharmacyService = new PharmacyServiceImpl();
        FirmServiceImpl firmService = new FirmServiceImpl();

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
                    medicineBox.Items.Add(medicine.Name);
                }
            }

            var allPharmacys = pharmacyService.getAll();

            if (allPharmacys != null)
            {
                foreach (var pharmacy in allPharmacys)
                {
                    pharmacyBox.Items.Add(pharmacy.Name);
                }
            }

            var allFirms = firmService.getAll();

            if (allFirms != null)
            {
                foreach (var firm in allFirms)
                {
                    firmBox.Items.Add(firm.Name);
                }
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            WhereCanBuy.Enabled = false;
            WhereCanBuyCost.Enabled = false;
            PostingThisMonth.Enabled = false;
            firmButton.Enabled = false;
        }

        private void buttonEnabled()
        {
            if (medicineBox.Text.Length > 0)
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

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Session.FormLogin.Visible = true;
        }

        private void PostingThisMonth_Click(object sender, EventArgs e)
        {
            List<Medicine> medicines = medicineService.postingThisMonth(pharmacyService.getPharmacyByName(pharmacyBox.Text));
            String result = "Результат:\n";
            foreach (var medicine in medicines)
            {
                result += medicine.Name + "\n";
            }
            if (result != "Результат:\n")
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Ничего не найдено");
            }
        }

        private void pharmacyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void pharmacyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pharmacyBox.Text.Length > 0)
            {
                PostingThisMonth.Enabled = true;
            }
            else
            {
                PostingThisMonth.Enabled = false;
            }

            if (pharmacyBox.Text.Length > 0 && firmBox.Text.Length > 0)
            {
                firmButton.Enabled = true;
            }
            else
            {
                firmButton.Enabled = false;
            } 
        }

        private void firmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pharmacyBox.Text.Length > 0 && firmBox.Text.Length > 0)
            {
                firmButton.Enabled = true;
            }
            else
            {
                firmButton.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Medicine> medicines = medicineService.getMedicinesByFirmAndPharmacy(pharmacyService.getPharmacyByName(pharmacyBox.Text), firmService.getFirmByName(firmBox.Text));
            String result = "Результат:\n";
            foreach (var medicine in medicines)
            {
                result += medicine.Name + "\n";
            }
            if (result != "Результат:\n")
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Ничего не найдено");
            }
        }

        private void firmBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }
    }
}
