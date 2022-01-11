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
        public Image img;
        public byte[] byteimg;
        public ArticleForm()
        {
            InitializeComponent();
            this.articleBusiness = new ArticleBusiness();
        }
        public void UpdateDataGrid()
        {
            dgArticles.DataSource = this.articleBusiness.GetAllArticles();
        }
        public void DeleteTextBox()
        {
            tbArticalName.Text = "";
            tbArticalPrice.Text = "";
            tbArticalDescription.Text = "";
            pictureBox1.Image = null;
            cbBox.Checked = false;
            cbDonut.Checked = false;
            cbMuffin.Checked = false;
            cbPops.Checked = false;
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
            article.Image = Convert.ToBase64String(byteimg);

            bool result = this.articleBusiness.InsertArticle(article);
            if (result)
                MessageBox.Show("Uspesan unos artikla!");
            else
                MessageBox.Show("Unos artikala nije uspesan!");
            UpdateDataGrid();
            DeleteTextBox();
           
        }
        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }
        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...", ValidateNames = true, Multiselect = false })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    lblFileName.Text = openFile.FileName;
                    img = Image.FromFile(lblFileName.Text);
                    byteimg = ConvertImageToBinary(img);
                    pictureBox1.Image =img ;
                    
                }
            }
        }
        
        private void dgArticles_Cell(object sender, DataGridViewCellEventArgs e)
        {
            int idSelect = Convert.ToInt32(dgArticles.SelectedRows[0].Cells["Id"].Value.ToString());

            Article article = this.articleBusiness.GetSelectedArticle(idSelect);
            tbArticalName.Text = article.Name;
            tbArticalPrice.Text = article.Price.ToString();
            tbArticalDescription.Text = article.Description;
            byteimg = Convert.FromBase64String(article.Image);
            pictureBox1.Image = ConvertBinaryToImage(Convert.FromBase64String(article.Image));          
        }

        private void btnArticalDelete_Click(object sender, EventArgs e)
        {
            int idSelect = Convert.ToInt32(dgArticles.SelectedRows[0].Cells["Id"].Value.ToString());
           
            bool result = this.articleBusiness.DeleteArticle(idSelect);
            if(result)
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

        private void btnArticalChange_Click(object sender, EventArgs e)
        {
             string type;
            List<String> list = new List<String>();
            foreach (CheckBox cb in panel1.Controls.OfType<CheckBox>())
            {
                if (cb.Checked)
                {
                    list.Add(cb.Text);
                }
            }
            type = String.Join(",", list.ToArray());
            int idSelect = Convert.ToInt32(dgArticles.SelectedRows[0].Cells["Id"].Value.ToString());
            Article article = new Article();
            article.Name = tbArticalName.Text;
            article.Price = Decimal.Parse(tbArticalPrice.Text);
            article.Type = type;
            article.Description = tbArticalDescription.Text;
            article.Image = Convert.ToBase64String(byteimg);
            bool result = articleBusiness.UpdateArticle(article, idSelect);
            if(result)
            {
                MessageBox.Show("Uspesna izmena!");
            }
            else
            {
                MessageBox.Show("Izmena nije uspesna!");
            }
            UpdateDataGrid();
            DeleteTextBox();
        }
    }
}
