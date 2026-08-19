using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CABACUNGAN_OrderMealManagementSystem
{
    public partial class frm_LogInForm : Form
    {
        public frm_LogInForm()
        {
            InitializeComponent();
        }

        private void frm_LogInForm_Load(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
        }
        private void chk_ShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_Password.UseSystemPasswordChar)
            { txt_Password.UseSystemPasswordChar = false; }
            else
            { txt_Password.UseSystemPasswordChar = true; }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {Application.Exit();}
        private void btn_MouseLeave_Click(object sender, EventArgs e)
        {btn_Close.BackColor = Color.IndianRed;}
        private void btn_MouseEnter_Click(object sender, EventArgs e)
        {btn_Close.BackColor = Control.DefaultBackColor;}


        private void gbtn_Login_Click(object sender, EventArgs e)
        {
            lbl_Username.Text = "Username";
            lbl_Password.Text = "Password";
            lbl_ErrorUsername.Text = "";
            lbl_ErrorPassword.Text = "";
            lbl_AllError.Text = "";

            string user = txt_Username.Text;
            string pass = txt_Password.Text;

            lbl_Username.ForeColor = Color.Black;
            lbl_Password.ForeColor = Color.Black;

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(user))
            {
                lbl_ErrorUsername.Text = "Username is required! *";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(pass))
            {
                lbl_ErrorPassword.Text = "Password is required! *";
                isValid = false;
            }

            if (!isValid) return;

            if (user == "admin" && pass == "1234")
            {
                frm_OrderingForm mainForm = new frm_OrderingForm();
                mainForm.Show();
                this.Hide();
            }
            else if (user != "admin" && pass == "1234")
            {
                lbl_Username.ForeColor = Color.Red;
                lbl_Username.Text = "Username  *";
            }
            else if (user == "admin" && pass != "1234")
            {
                lbl_Password.ForeColor = Color.Red;
                lbl_Password.Text = "Password  *";
            }
            else
            {
                lbl_Username.ForeColor = Color.Red;
                lbl_Username.Text = "Username  *";
                lbl_Password.ForeColor = Color.Red;
                lbl_Password.Text = "Password  *";
                lbl_AllError.Text = "Username and Password is Incorrect";
            }
        }

        private void lnklbl_AboutUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.canva.com/design/DAHDb7J0asg/NmquTlolgk3PacdvoECDWA/view?utm_content=DAHDb7J0asg&utm_campaign=designshare&utm_medium=link2&utm_source=uniquelinks&utlId=h6705aa3c6b",
                UseShellExecute = true

            });


            //helpp
        }

    }
}

