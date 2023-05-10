using pharmacies.enums;
using pharmacies.model;
using pharmacies.repository;
using pharmacies.service.firm;
using pharmacies.service.madicine;
using pharmacies.service.pharmacy;
using pharmacies.service.pharmacyMedicine;
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
    public partial class CreateMedicineForm : Form
    {
        PharmacyServiceImpl pharmacyService = new PharmacyServiceImpl();
        FirmServiceImpl firmService = new FirmServiceImpl();
        PharmacyMedicineServiceImpl pharmacyMedicineService = new PharmacyMedicineServiceImpl();
        MedicineServiceImpl medicineService = new MedicineServiceImpl();

        List<Pharmacy> PharmaciesToSave = new List<Pharmacy>();
        List<Pharmacy> allPharmacies = new List<Pharmacy>();
        public CreateMedicineForm()
        {
            InitializeComponent();

            allPharmacies = pharmacyService.getAll();

            setTypeOfPackaging();
            setMethodOfConsumption();
            setFirm();
            setPharmacyList();
            addMedicins.Enabled = false;
            save.Enabled = false;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void setPharmacyList()
        {
            List<Pharmacy> pharmacies = pharmacyService.getAll();
            foreach (var item in pharmacies)
            {
                PharmacyList.Items.Add(item.Name);
            }
        }

        private void setFirm()
        {
            List<Firm> allFirrms = firmService.getAll();
            foreach (var item in allFirrms)
            {
                firmBox.Items.Add(item.Name);
            }
        }

        private void setMethodOfConsumption()
        {
            foreach (int item in Enum.GetValues(typeof(MethodOfConsumption)))
            {
                Medicine medicine = new Medicine();
                medicine.MethodOfConsumption = (MethodOfConsumption)Enum.GetValues(typeof(MethodOfConsumption)).GetValue(item);
                methodOfConsumption.Items.Add(medicine.getFormatMethodOfConsumption());
            }

        }

        private void setTypeOfPackaging()
        {
            foreach (int item in Enum.GetValues(typeof(TypesOfPackaging)))
            {
                Medicine medicine = new Medicine();
                medicine.TypeOfPackaging = (TypesOfPackaging)Enum.GetValues(typeof(TypesOfPackaging)).GetValue(item);
                typeOfPackaging.Items.Add(medicine.getFormatTypeOfPackaging());
            }
            
        }

        private void saveEnable()
        {
            if (name.Text.Length > 0 && cost.Text.Length > 0 && typeOfPackaging.Text.Length > 0 && methodOfConsumption.Text.Length > 0 && firmBox.Text.Length > 0 && contraindications.Text.Length > 0)
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
            if (PharmacyList.SelectedItems.Count != 0)
            {
                addMedicins.Enabled = true;
            }
            else
            {
                addMedicins.Enabled = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.Name = name.Text;
            medicine.TypeOfPackaging = Medicine.getTypeOfPackaging(typeOfPackaging.Text);
            medicine.MethodOfConsumption = Medicine.getMethodOfConsumption(methodOfConsumption.Text);
            medicine.Cost = Convert.ToInt32(cost.Text);
            medicine.BestBeforeDate = bestBeforeDate.Value;
            medicine.Contraindications = contraindications.Text;
            

            List<Firm> allFirrms = firmService.getAll();
            foreach (var item in allFirrms)
            {
                if(item.Name == firmBox.Text)
                {
                    medicine.FirmId = item.Id;
                }
            }

            List<PharmacyMedicine> pharmacyMedicines = new List<PharmacyMedicine>();
            if (PharmaciesToSave != null)
            {
                foreach (var item in PharmaciesToSave)
                {
                    PharmacyMedicine pharmacyMedicine = new PharmacyMedicine();
                    pharmacyMedicine.MedicineId = medicine.Id;
                    pharmacyMedicine.PharmacyId = item.Id;
                    pharmacyMedicines.Add(pharmacyMedicine);
                }
            }
            medicine.PharmacyMedicine = pharmacyMedicines;
            medicineService.saveMedicine(medicine);
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void typeOfPackaging_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void methodOfConsumption_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void firmBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void typeOfPackaging_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void methodOfConsumption_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void cost_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void firmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void PharmacyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            addEnable();
        }

        private void addMedicins_Click(object sender, EventArgs e)
        {
            foreach (var item in allPharmacies)
            {
                if(item.Name == PharmacyList.SelectedItem.ToString())
                {
                    PharmaciesToSave.Add(item);
                    PharmacyList.Items.Remove(PharmacyList.SelectedItem);
                }
            }
        }

        private void contraindications_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }
    }
}
