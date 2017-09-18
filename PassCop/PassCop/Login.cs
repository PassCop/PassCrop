using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices; //for console window
using System.Configuration;
using System.Data.SqlClient;

namespace PassCop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void Login_Load(object sender, EventArgs e)
        {
            erroLabel.Hide();
        }       

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(utilizadorTextbox.Text) || String.IsNullOrWhiteSpace(passwordTextbox.Text))
            {
                MessageBox.Show("Falta introduzir dados.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void novapasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
