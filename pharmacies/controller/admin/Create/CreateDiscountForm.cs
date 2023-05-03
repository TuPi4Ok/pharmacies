using pharmacies.model;
using pharmacies.service.discount;
using pharmacies.service.madicine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacies.controller.admin.Create
{
    public partial class CreateDiscountForm : Form
    {
        MedicineServiceImpl medicineService = new MedicineServiceImpl();
        DiscountServiceImpl discountService = new DiscountServiceImpl();

        List<Medicine> allMedicines;
        List<Medicine> addMedicines = new List<Medicine>();
        public CreateDiscountForm()
        {
            InitializeComponent();

            allMedicines = medicineService.getAll();

            if (allMedicines != null)
            {
                foreach (var medicine in allMedicines)
                {
                    if(medicine.Discount == null)
                    {
                        medicineBox.Items.Add(medicine.Name);
                        addMedicines.Add(medicine);
                    }
                        
                }
            }

            save.Enabled = false;
        }

        private void saveEnable()
        {
            if (medicineBox.Text.Length > 0 && procent.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }

        private void medicineBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void procent_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void medicineBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void procent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && (procent.Text.Length == 0 || Convert.ToInt32(procent.Text + e.KeyChar) < 100))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar == (char)Keys.Tab)
                return;
            e.KeyChar = '\0';
        }

        private void save_Click(object sender, EventArgs e)
        {
            Discount discount = new Discount();
            discount.Percent = Convert.ToInt32(procent.Text);
            Medicine medicine = new Medicine();
            foreach(var item in addMedicines)
            {
                if (item.Name == medicineBox.Text)
                {
                    medicine = item; break;
                }
            }

            discount.Id = medicine.Id;
            discountService.saveDiscount(discount);
            Close();
        }
    }
}
