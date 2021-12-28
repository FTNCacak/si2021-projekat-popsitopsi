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
    public partial class Stuffs : Form
    {
        public readonly StuffBusiness stuffBusiness;
        public Stuffs()
        {
            InitializeComponent();
            this.stuffBusiness = new StuffBusiness();
        }

        private void Stuffs_Load(object sender, EventArgs e)
        {

        }
    }
}
