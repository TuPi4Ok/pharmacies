using pharmacies.controller.admin.Create;
using pharmacies.controller.admin.Delete;
using pharmacies.controller.admin.Read;
using pharmacies.controller.admin.Update;
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

            Create.Enabled = false;
            Read.Enabled = false;
            Update.Enabled = false;
            Delete.Enabled = false;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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

            if (Login.Session.TableForAdmin == "Фирмы")
            {
                CreateFirmForm form = new CreateFirmForm();
                form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Скидки")
            {
                CreateDiscountForm form = new CreateDiscountForm();
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

        private void Read_Click(object sender, EventArgs e)
        {
            Login.Session.TableForAdmin = table.Text;

            if (Login.Session.TableForAdmin == "Аптеки")
            {
                ReadPharmacyForm form = new ReadPharmacyForm();
                form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Лекарства")
            {
                ReadMedicineForm form = new ReadMedicineForm();
                form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Фирмы")
            {
                ReadFirmForm form = new ReadFirmForm();
                form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Скидки")
            {
                ReadDiscountForm form = new ReadDiscountForm();
                form.ShowDialog();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Login.Session.TableForDelete = table.Text;
            DeleteForm form = new DeleteForm();
            form.ShowDialog();
        }

        private void wellcome_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            Login.Session.TableForAdmin = table.Text;

            if (Login.Session.TableForAdmin == "Аптеки")
            {
                UpdatePharmacyForm form = new UpdatePharmacyForm();
                form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Лекарства")
            {
                UpdateMedicineForm form = new UpdateMedicineForm();
                form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Фирмы")
            {
                UpdateFirmForm form = new UpdateFirmForm();
                form.ShowDialog();
            }

            if (Login.Session.TableForAdmin == "Скидки")
            {
                UpdateDiscountForm form = new UpdateDiscountForm();
                form.ShowDialog();
            }
        }
    }
}
