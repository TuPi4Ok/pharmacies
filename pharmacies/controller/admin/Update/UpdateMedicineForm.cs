using pharmacies.enums;
using pharmacies.model;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacies.controller.admin.Update
{
    public partial class UpdateMedicineForm : Form
    {
        PharmacyService pharmacyService = new PharmacyServiceImpl();
        FirmService firmService = new FirmServiceImpl();
        MedicineService medicineService = new MedicineServiceImpl();
        PharmacyMedicineService pharmacyMedicineService = new PharmacyMedicineServiceImpl();

        List<Pharmacy> allPharmacies = new List<Pharmacy>();
        List<Pharmacy> pharmaciesToSave = new List<Pharmacy>();
        public UpdateMedicineForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            name.Enabled = false;
            typeOfPackaging.Enabled = false;
            methodOfConsumption.Enabled = false;
            cost.Enabled = false;
            contraindications.Enabled = false;
            firmBox.Enabled = false;
            bestBeforeDate.Enabled = false;
            addMedicins.Enabled = false;
            save.Enabled = false;
            setTypeOfPackaging();
            setMethodOfConsumption();
            setFirm();
            setPharmacyList();

            var allMedicines = medicineService.getAll();

            if (allMedicines != null)
            {
                foreach (var medicine in allMedicines)
                {
                    medicineBox.Items.Add(medicine.Name);
                }
            }
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

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(medicineBox.Text.Length > 0)
            {
                name.Enabled = true;
                typeOfPackaging.Enabled = true;
                methodOfConsumption.Enabled = true;
                cost.Enabled = true;
                contraindications.Enabled = true;
                firmBox.Enabled = true;
                bestBeforeDate.Enabled = true;
            }
            else
            {
                name.Enabled = false;
                typeOfPackaging.Enabled = false;
                methodOfConsumption.Enabled = false;
                cost.Enabled = false;
                contraindications.Enabled = false;
                firmBox.Enabled = false;
                bestBeforeDate.Enabled = false;
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

        private void name_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void typeOfPackaging_SelectedIndexChanged(object sender, EventArgs e)
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

        private void contraindications_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void firmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void bestBeforeDate_ValueChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void PharmacyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            addEnable();
        }

        private void cost_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            Medicine medicine = medicineService.getMedicineByName(medicineBox.Text);
            medicine.Name = name.Text;
            medicine.TypeOfPackaging = Medicine.getTypeOfPackaging(typeOfPackaging.Text);
            medicine.MethodOfConsumption = Medicine.getMethodOfConsumption(methodOfConsumption.Text);
            medicine.Cost = Convert.ToInt32(cost.Text);
            medicine.BestBeforeDate = bestBeforeDate.Value;
            medicine.Contraindications = contraindications.Text;


            List<Firm> allFirrms = firmService.getAll();
            foreach (var item in allFirrms)
            {
                if (item.Name == firmBox.Text)
                {
                    medicine.FirmId = item.Id;
                }
            }
            if (pharmaciesToSave != null)
            {
                pharmacyMedicineService.updatePharmacyMedicineByMedicine(medicine, pharmaciesToSave);
            }
            medicineService.saveMedicine(medicine);
            Close();
        }

        private void addMedicins_Click(object sender, EventArgs e)
        {
            foreach (var item in allPharmacies)
            {
                if (item.Name == PharmacyList.SelectedItem.ToString())
                {
                    pharmaciesToSave.Add(item);
                    PharmacyList.Items.Remove(PharmacyList.SelectedItem);
                }
            }
        }
    }
}
