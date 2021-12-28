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
    public partial class Bills : Form
    {
        public readonly BillBusiness billBusiness;
        public readonly BillItemBusiness billItemBusiness;

        public Bills()
        {
            InitializeComponent();
            this.billBusiness = new BillBusiness();
            this.billItemBusiness = new BillItemBusiness();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            List<Bill> bills = new List<Bill>();
            bills.Add(new Bill(1, 150, DateTime.Now, 2));
            bills.Add(new Bill(2, 250, DateTime.Now, 2));
            bills.Add(new Bill(3, 100, DateTime.Now, 2));
            dgvBills.DataSource = bills;

        }
    }
}
