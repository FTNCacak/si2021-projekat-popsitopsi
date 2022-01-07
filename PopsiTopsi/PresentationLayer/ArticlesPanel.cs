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
    public partial class ArticlesPanel : UserControl
    {
        public Article article { get; set; }
        public ArticlesPanel(Article a)
        {
            InitializeComponent();
            article = a;
            lblName.Text = a.Name;
            lblPrice.Text = "Cena: "+ a.Price.ToString();
            //pbPhoto.Image = a.Image;
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void ArticlesPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
