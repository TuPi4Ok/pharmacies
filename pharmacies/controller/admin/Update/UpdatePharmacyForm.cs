using pharmacies.model;
using pharmacies.service.madicine;
using pharmacies.service.pharmacy;
using pharmacies.service.pharmacyMedicine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacies.controller.admin.Update
{
    public partial class UpdatePharmacyForm : Form
    {
        MedicineService medicineService = new MedicineServiceImpl();
        PharmacyService pharmacyService = new PharmacyServiceImpl();
        List<Medicine> medicinesToSave = new List<Medicine>();
        PharmacyMedicineService pharmacyMedicineService = new PharmacyMedicineServiceImpl();
        List<Medicine> allMedicines = new List<Medicine>();
        public UpdatePharmacyForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            allMedicines = medicineService.getAll();

            if (allMedicines != null)
            {
                foreach (var medicine in allMedicines)
                {
                    medicinesList.Items.Add(medicine.Name);
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

            name.Enabled = false;
            address.Enabled = false;
            addMedicins.Enabled = false;
            
        }

        private void pharmacyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void saveEnable()
        {
            if (address.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }
        private void addEnable()
        {
            if (medicinesList.SelectedItems.Count != 0)
            {
                addMedicins.Enabled = true;
            }
            else
            {
                addMedicins.Enabled = false;
            }
        }

        private void pharmacyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pharmacyBox.Text.Length > 0)
            {
                name.Enabled = true;
                address.Enabled = true;
            }
            else
            {
                name.Enabled = false;
                address.Enabled = false;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void medicinesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            addEnable();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Pharmacy pharmacy = pharmacyService.getPharmacyByName(pharmacyBox.Text);
            pharmacy.Address = address.Text;
            pharmacy.Name = name.Text;
            pharmacyService.updatePharmacy(pharmacy);
            pharmacyMedicineService.updatePharmacyMedicineByPharmasy(pharmacy, medicinesToSave);
            Close();
        }

        private void addMedicins_Click(object sender, EventArgs e)
        {
            var selected = medicinesList.SelectedItem.ToString();
            foreach (var item in allMedicines)
            {
                if (item.Name == selected)
                {
                    medicinesToSave.Add(item);
                    medicinesList.Items.Remove(medicinesList.SelectedItem);
                }
            }
        }
    }
}
