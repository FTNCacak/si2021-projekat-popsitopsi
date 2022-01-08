using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Stuffs : Form
    {
        public readonly StuffBusiness stuffBusiness;
        public Stuffs()
        {
            InitializeComponent();
            this.stuffBusiness = new StuffBusiness();
        }
        public void UpdateDataGrid()
        {
            dgStuffs.DataSource= this.stuffBusiness.GetAllStuffs();
        }
        private void Stuffs_Load(object sender, EventArgs e)
        {
            dgStuffs.AutoGenerateColumns = false;
            
            UpdateDataGrid();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Stuff stuff = new Stuff();
            stuff.Name = tbStuffName.Text;
            stuff.Surname = tbStuffSurname.Text;
            stuff.Username = tbStuffUsername.Text;
            stuff.Password = tbStuffPassword.Text;
            stuff.Email = tbStuffEmail.Text;
            stuff.PhoneNumber = tbStuffPhone.Text;

            bool result = this.stuffBusiness.InsertStuff(stuff);
            if (result)
                MessageBox.Show("Uspesan unos radnika!");
            else
                MessageBox.Show("Unos nije uspesan!");
            UpdateDataGrid();
        }
    }
}
