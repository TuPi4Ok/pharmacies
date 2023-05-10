using pharmacies.model;
using pharmacies.service.firm;
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
    public partial class UpdateFirmForm : Form
    {
        FirmService firmService = new FirmServiceImpl();
        public UpdateFirmForm()
        {
            InitializeComponent();

            setFirm();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            name.Enabled = false;
            address.Enabled = false;
            telefonNumber.Enabled = false;
            save.Enabled = false;
        }

        private void setFirm()
        {
            List<Firm> allFirrms = firmService.getAll();
            foreach (var item in allFirrms)
            {
                firmBox.Items.Add(item.Name);
            }
        }

        private void firmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(firmBox.Text.Length > 0)
            {
                name.Visible = true;
                address.Visible = true;
                telefonNumber.Visible = true;
            }
            else
            {
                name.Visible = false;
                address.Visible = false;
                telefonNumber.Visible = false;
            }
        }

        private void firmBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void saveEnable()
        {
            if (name.Text.Length > 0 && address.Text.Length > 0 && telefonNumber.Text.Length > 0)
            {
                save.Enabled = true;
            }
            else
            {
                save.Enabled = false;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Firm firm = firmService.getFirmByName(firmBox.Text);
            firm.Name = name.Text;
            firm.Address = address.Text;
            firm.TelephoneNumber = telefonNumber.Text;
            firmService.updateFirm(firm);
            Close();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void telefonNumber_TextChanged(object sender, EventArgs e)
        {
            saveEnable();
        }

        private void telefonNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if ((e.KeyChar == '+') && (telefonNumber.Text.Length == 0))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (e.KeyChar == (char)Keys.Tab)
                return;
            e.KeyChar = '\0';
        }
    }
}
