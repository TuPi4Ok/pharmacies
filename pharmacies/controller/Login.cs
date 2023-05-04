using pharmacies.config;
using pharmacies.controller;
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

namespace pharmacies
{
    public partial class Login : Form
    {
        private static Session session = new Session(false);
        private UserServiseImpl userServise = new UserServiseImpl();

        internal static Session Session { get => session; set => session = value; }

        public Login()
        {
            InitializeComponent();
            Loging.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void LoginEnable()
        {
            if (userNameField.Text.Length > 0 && passwordField.Text.Length > 0)
            {
                Loging.Enabled = true;
            }
            else
            {
                Loging.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(userNameField.Text, passwordField.Text);
            User existingUser = userServise.getUser(userNameField.Text);
            if(userServise.validate(existingUser, user))
            {
                Session.setSession(existingUser, this);
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль!");
                userNameField.Text = "";
                passwordField.Text = "";
                return;
            }

            if(Session.CurrentUser.Role == Role.BOYER)
            {
                controller.boyer.StartForm startForm = new controller.boyer.StartForm();
                startForm.Show();
            }
            if (Session.CurrentUser.Role == Role.ADMIN)
            {
                controller.admin.StartForm startForm = new controller.admin.StartForm();
                startForm.Show();
            }
            this.Visible = false;
        }

        private void registration_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
            Session.FormLogin = this;
            this.Visible = false;
        }

        private void userNameField_TextChanged(object sender, EventArgs e)
        {
            LoginEnable();
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            LoginEnable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
