using pharmacies.model;
using pharmacies.service.discount;
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

namespace pharmacies.controller.admin.Delete
{
    public partial class DeleteForm : Form
    {
        DiscountServiceImpl discountService = new DiscountServiceImpl();
        FirmServiceImpl firmService = new FirmServiceImpl();
        MedicineServiceImpl medicineService = new MedicineServiceImpl();
        PharmacyServiceImpl pharmacyService = new PharmacyServiceImpl();

        public DeleteForm()
        {
            InitializeComponent();

            delete.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(deleteId.Text.Length > 0)
            {
                delete.Enabled = true;
            }
            else { delete.Enabled = false; }
        }

        private void deleteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar == (char)Keys.Tab)
                return;
            e.KeyChar = '\0';
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(Login.Session.TableForDelete == "Аптеки")
            {
                if (pharmacyService.deletePharmacy(Convert.ToInt32(deleteId.Text)))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Запись с данным ID на найдена.");
                }
            }

            if (Login.Session.TableForDelete == "Лекарства")
            {
                if (medicineService.deleteMedicine(Convert.ToInt32(deleteId.Text)))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Запись с данным ID на найдена.");
                }
            }

            if (Login.Session.TableForDelete == "Фирмы")
            {
                if (firmService.deleteFirm(Convert.ToInt32(deleteId.Text)))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Запись с данным ID на найдена.");
                }
            }

            if (Login.Session.TableForDelete == "Скидки")
            {
                if (discountService.deleteDiscount(Convert.ToInt32(deleteId.Text)))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Запись с данным ID на найдена.");
                }
            }
        }
    }
}
