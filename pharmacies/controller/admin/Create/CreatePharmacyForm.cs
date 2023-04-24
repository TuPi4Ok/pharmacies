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

namespace pharmacies.controller.admin.Create
{
    public partial class CreatePharmacyForm : Form
    {
        List<Medicine> medicinesToSave = new List<Medicine>();
        MedicineServiceImpl medicineService = new MedicineServiceImpl();
        PharmacyServiceImpl pharmacyService = new PharmacyServiceImpl();

        public CreatePharmacyForm()
        {
            InitializeComponent();
            List<Medicine> AllMedicines = medicineService.getAll();
            foreach (var medicine in AllMedicines)
            {
                medicinesList.Items.Add(medicine);
            }
            save.Enabled = false;
            addMedicins.Enabled = false;
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
            if (medicinesList.SelectedItems[0] != null)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addMedicins_Click(object sender, EventArgs e)
        {
            medicinesToSave.Add((Medicine)medicinesList.SelectedItems[0]);
            medicinesList.Items.Remove(medicinesList.SelectedItems[0]);
        }


        private void address_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Pharmacy pharmacy = new Pharmacy();
            pharmacy.Address = address.Text;
            pharmacy.Medicines = medicinesToSave;
            pharmacyService.savePharmacy(pharmacy);
        }
    }
}
