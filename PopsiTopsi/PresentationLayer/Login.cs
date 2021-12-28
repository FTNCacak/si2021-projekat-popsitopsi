using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public readonly StuffBusiness stuffBusiness;
        public Login()
        {
            InitializeComponent();
            this.stuffBusiness = new StuffBusiness();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
