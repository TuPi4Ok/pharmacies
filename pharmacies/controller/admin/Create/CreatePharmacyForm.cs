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

namespace pharmacies.controller.admin.Create
{
    public partial class CreatePharmacyForm : Form
    {
        MedicineServiceImpl medicineService = new MedicineServiceImpl();
        PharmacyServiceImpl pharmacyService = new PharmacyServiceImpl();
        PharmacyMedicineService pharmacyMedicineService = new PharmacyMedicineServiceImpl();

        List<Medicine> medicinesToSave = new List<Medicine>();
        List<Medicine> allMedicines;
        //Dictionary<String, Medicine> medicineMap = new Dictionary<String, Medicine>();
        public CreatePharmacyForm()
        {
            InitializeComponent();

            allMedicines = medicineService.getAll();

            if (allMedicines != null)
            {
                foreach (var medicine in allMedicines)
                {
                    medicinesList.Items.Add(medicine + " " + medicine.Firm.Name);
                }
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
            if (medicinesList.SelectedItems.Count != 0)
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
            foreach(var item in allMedicines)
            {
                String itemName = medicinesList.SelectedItems[0].ToString().Split(' ')[0];
                String itemFirm = medicinesList.SelectedItems[0].ToString().Split(' ')[1];
                if (item.Name == itemName && item.Firm.Name == itemFirm)
                {
                    medicinesToSave.Add(item);
                    medicinesList.Items.Remove(medicinesList.SelectedItems[0]);
                }
            }
           
        }


        private void address_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Pharmacy pharmacy = new Pharmacy();
            pharmacy.Address = address.Text;
            pharmacy.Name = name.Text;
            if (medicinesToSave != null)
            {
                foreach (var item in medicinesToSave)
                {
                    PharmacyMedicine pharmacyMedicine = new PharmacyMedicine();
                    pharmacyMedicine.Medicine = item;
                    pharmacyMedicine.Pharmacy = pharmacy;
                    pharmacyMedicineService.savePharmacyMedicine(pharmacyMedicine);
                }
            }
            pharmacyService.savePharmacy(pharmacy);
            Close();
        }

        private void medicinesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            addEnable();
        }

        private void CreatePharmacyForm_Load(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }
    }
}
