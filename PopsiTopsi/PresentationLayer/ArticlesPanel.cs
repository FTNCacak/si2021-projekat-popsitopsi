using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if(a.Image!="")
            pbPhoto.Image = ConvertBinaryToImage(Convert.FromBase64String(a.Image));
            
            
        }

        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

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
