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
    public partial class Stuffs : Form
    {
        public readonly IStuffBusiness stuffBusiness;
        public Stuffs(IStuffBusiness _stuffBusiness)
        {
            InitializeComponent();
            this.stuffBusiness = _stuffBusiness;
        }
        public void UpdateDataGrid()
        {
            dgStuffs.DataSource= this.stuffBusiness.GetAllStuffs();
        }
        public void DeleteTextBox()
        {
            tbStuffName.Text = "";
            tbStuffSurname.Text = "";
            tbStuffPhone.Text = "";
            tbStuffUsername.Text = "";
            tbStuffPassword.Text = "";
            tbStuffEmail.Text = "";
        }
        private void Stuffs_Load(object sender, EventArgs e)
        {
            dgStuffs.AutoGenerateColumns = false;
            
            UpdateDataGrid();
        
          
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (PresentationLayer.Properties.Settings.Default.UserId == 1003)
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
                DeleteTextBox();
            }
            else
            {
                MessageBox.Show("Morate se prijaviti kao admin!");
            }


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (PresentationLayer.Properties.Settings.Default.UserId == 1003)
            {
                int idSelect = Convert.ToInt32(dgStuffs.SelectedRows[0].Cells["Id"].Value.ToString());

                bool result = this.stuffBusiness.DeleteStuff(idSelect);

                if (result)
                {
                    MessageBox.Show("Uspesno brisanje!");

                }
                else
                {
                    MessageBox.Show("Neuspesno brisanje!");
                }
                UpdateDataGrid();
                DeleteTextBox();
            }
            else
            {
                MessageBox.Show("Morate se prijavit kao admin!");
            }
                
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (PresentationLayer.Properties.Settings.Default.UserId == 1003)
            {
             int idSelect = Convert.ToInt32(dgStuffs.SelectedRows[0].Cells["Id"].Value.ToString());
                Stuff stuff = stuffBusiness.GetSelectedStuff(idSelect);
                        stuff.Name = tbStuffName.Text;
                        stuff.Surname = tbStuffSurname.Text;
                        stuff.Username = tbStuffUsername.Text;
                        stuff.Password = tbStuffPassword.Text;
                        stuff.Email = tbStuffEmail.Text;
                        stuff.PhoneNumber = tbStuffPhone.Text;

                        bool result = this.stuffBusiness.UpdateStuff(stuff);
                        if (result)
                            MessageBox.Show("Uspesna izmena!");
                        else
                            MessageBox.Show("Izmena nije uspesna!");
                        UpdateDataGrid();
                        DeleteTextBox();
            }
            else
            {
                MessageBox.Show("Morate se prijaviti  kao admin!");
            }

               
        }

        private void dgStuffs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idSelect = Convert.ToInt32(dgStuffs.SelectedRows[0].Cells["Id"].Value.ToString());
            Stuff s = this.stuffBusiness.GetSelectedStuff(idSelect);
            tbStuffName.Text = s.Name;
            tbStuffSurname.Text = s.Surname;
            tbStuffPhone.Text = s.PhoneNumber;
            tbStuffUsername.Text = s.Username;
            tbStuffPassword.Text = s.Password;
            tbStuffEmail.Text = s.Email;
        }
    }
}
