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
using System.Xml.Linq;

namespace pharmacies.controller.admin.Update
{
    public partial class UpdateDiscountForm : Form
    {
        MedicineService medicineService = new MedicineServiceImpl();
        DiscountServiceImpl discountService = new DiscountServiceImpl();
        public UpdateDiscountForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            procent.Enabled = false;

            var allDiscounts = discountService.getAll();

            if (allDiscounts != null)
            {
                foreach (var discount in allDiscounts)
                {
                    DiscountBox.Items.Add(discount.Id);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            var discount = discountService.getDiscountById(Convert.ToInt32(DiscountBox.Text));
            discount.Percent = Convert.ToInt32(procent);
            discountService.updateDiscount(discount);
            Close();
        }

        private void saveEnable()
        {
            if (procent.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }

        private void DiscountBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void DiscountBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DiscountBox.Text.Length > 0)
            {
                procent.Enabled = true;
            }
            else
            {
                procent.Enabled = false;
            }
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

        private void procent_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }
    }
}
