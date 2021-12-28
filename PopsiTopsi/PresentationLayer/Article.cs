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
    public partial class Article : Form
    {
        public readonly ArticleBusiness articleBusiness;
        public Article()
        {
            InitializeComponent();
            this.articleBusiness = new ArticleBusiness();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Articals_Load(object sender, EventArgs e)
        {

        }
    }
}
