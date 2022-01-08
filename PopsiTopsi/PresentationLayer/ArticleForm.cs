using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ArticleForm : Form
    {
        public readonly ArticleBusiness articleBusiness;
        public OpenFileDialog dialog;
        public byte[] img;
        public ArticleForm()
        {
            InitializeComponent();
            this.articleBusiness = new ArticleBusiness();
        }
        public void UpdateDataGrid()
        {
            dgArticles.DataSource = this.articleBusiness.GetAllArticles();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Articals_Load(object sender, EventArgs e)
        {
            dgArticles.AutoGenerateColumns = false;
            UpdateDataGrid();
        }

        private void btnArticalAdd_Click(object sender, EventArgs e)
        {
            string type;
            List<String> list = new List<String>();
           foreach (CheckBox cb in panel1.Controls.OfType<CheckBox>())
            {
                if(cb.Checked)
                {
                    list.Add(cb.Text);
                }
            }
            type = String.Join(",",list.ToArray());
            Article article = new Article();
            article.Name = tbArticalName.Text;
            article.Price = Decimal.Parse(tbArticalPrice.Text);
            article.Type = type;
            article.Description = tbArticalDescription.Text;
            article.Image = img;

            bool result = this.articleBusiness.InsertArticle(article);
            if (result)
                MessageBox.Show("Uspesan unos artikla!");
            else
                MessageBox.Show("Unos artikala nije uspesan!");
            UpdateDataGrid();
            tbArticalName.Text = "";
            tbArticalPrice.Text = "";
            tbArticalDescription.Text = "";
            pictureBox1.Image = null;
            cbBox.Checked = false;
            cbDonut.Checked = false;
            cbMuffin.Checked = false;
            cbPops.Checked = false;
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            this.dialog = new OpenFileDialog();
            dialog.Title = "Open Image";
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            string f = pictureBox1.ImageLocation;

            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(dialog.FileName);
                 pictureBox1.Image = bmp;
                 MemoryStream ms = new MemoryStream();
                 bmp.Save(ms, bmp.RawFormat);
                img = ms.ToArray();
              
            }
          
            dialog.Dispose();
        }

        private void dgArticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSelect = Convert.ToInt32(dgArticles.SelectedRows[0].Cells["Id"].Value.ToString());

            Article article = this.articleBusiness.GetSelectedArticle(idSelect);
            tbArticalName.Text = article.Name;
            tbArticalPrice.Text = article.Price.ToString();
            tbArticalDescription.Text = article.Description;
           
         /*   using (var ms = new MemoryStream(article.Image))
            {
                ms.Write(img.ToArray(), 0, img.Length);
                pictureBox1.Image= Image.FromStream(ms);
            }
          */
        }
    }
}
