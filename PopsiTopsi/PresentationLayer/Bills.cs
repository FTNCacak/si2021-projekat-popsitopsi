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

        }
    }
}
