using BusinessLayer;
using Shared.BusinessInterface;
using Shared.Models;
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
        public  string stuff;
        public readonly IStuffBusiness stuffBusiness;
        public readonly IArticleBusiness articleBusiness;
        public readonly IBillBusiness billBusiness;
        public readonly IBillItemBusiness billItemBusiness;
      
        public Login(IArticleBusiness _articleBusiness, IBillBusiness _billBusiness, IBillItemBusiness _billItemBusiness, IStuffBusiness _stuffBusiness)
        {
            InitializeComponent();
            this.articleBusiness = _articleBusiness;
            this.billBusiness = _billBusiness;
            this.billItemBusiness = _billItemBusiness;
            this.stuffBusiness = _stuffBusiness;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool validate = false;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            List<Stuff> list =stuffBusiness.GetAllStuffs();
            foreach(Stuff s in list)
            {
                if(s.Username.Equals(username)&& s.Password.Equals(password))
                {
                    validate = true;
                Main main = new Main(articleBusiness,billBusiness,billItemBusiness,stuffBusiness);
                    PresentationLayer.Properties.Settings.Default.UserId = s.Id;
                this.Hide();
                main.ShowDialog();
                
                }
                else
                {
                    validate = false;
                }
            }

            if(validate==false)
            {
                MessageBox.Show("Uneli ste pogresne podatke za prijavu!");
                tbUsername.Text = "";
                tbPassword.Text = "";
            }
            
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
