using pharmacies.controller.admin.Create;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacies.controller.admin
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            wellcome.Text = "Добро пожаловать, " + Login.Session.CurrentUser.UserName + "!";

            table.Items.Add("Аптеки");
            table.Items.Add("Лекарства");
            table.Items.Add("Фирмы");
            table.Items.Add("Скидки");
            table.Items.Add("Пользователи");

            Create.Enabled = false;
            Read.Enabled = false;
            Update.Enabled = false;
            Delete.Enabled = false;
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Session.FormLogin.Visible = true;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Login.Session.TableForAdmin = table.Text;

            if(Login.Session.TableForAdmin == "Аптеки")
            {
                CreatePharmacyForm form = new CreatePharmacyForm();
                form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Лекарства")
            {
                CreateMedicineForm form = new CreateMedicineForm();
                form.ShowDialog();
            }
        }

        private void table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Create.Text.Length > 0 && Read.Text.Length > 0 && Update.Text.Length > 0 && Delete.Text.Length > 0)
            {
                Create.Enabled = true;
                Read.Enabled = true;
                Update.Enabled = true;
                Delete.Enabled = true;
            }
            else
            {
                Create.Enabled = false;
                Read.Enabled = false;
                Update.Enabled = false;
                Delete.Enabled = false;
            }
        }

        private void table_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }
    }
}
