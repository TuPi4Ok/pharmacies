using pharmacies.config;
using pharmacies.enums;
using pharmacies.model;
using pharmacies.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacies.controller
{
    public partial class RegistrationForm : Form
    {
        UserServiseImpl userServise = new UserServiseImpl();

        public RegistrationForm()
        {
            InitializeComponent();
            roleField.Items.Add("Администратор");
            roleField.Items.Add("Фармоцевт");
            roleField.Items.Add("Покупатель");
            registration.Enabled = false;
        }

        private void registrationEnable()
        {
            if (userNameField.Text.Length > 0 && passwordField.Text.Length > 0 && roleField.Text.Length > 0)
            {
                registration.Enabled = true;
            }
            else
            {
                registration.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            registrationEnable();
        }

        private void roleField_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '\0';
        }

        private void userNameField_TextChanged(object sender, EventArgs e)
        {
            registrationEnable();
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            registrationEnable();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = userNameField.Text;
            user.Password = passwordField.Text;
            if (roleField.Text == "Администратор")
            {
                user.Role = Role.ADMIN;
            }
            if (roleField.Text == "Фармоцевт")
            {
                user.Role = Role.PHARMACIST;
            }
            if (roleField.Text == "Покупатель")
            {
                user.Role = Role.BOYER;
            }

            if (userServise.saveUser(user))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Пользователь с таким именем уже существует!");
            }
        }
    }
}
