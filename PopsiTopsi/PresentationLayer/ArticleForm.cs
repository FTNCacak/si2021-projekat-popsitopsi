using BusinessLayer;
using Shared.BusinessInterface;
using Shared.Models;

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
        public readonly IArticleBusiness articleBusiness;
        public readonly IStuffBusiness stuffBusiness;
        public readonly IBillBusiness billBusiness;
        public readonly IBillItemBusiness billItemBusiness;
        public OpenFileDialog dialog;
        public Image img;
        public byte[] byteimg;
   
        public ArticleForm(IArticleBusiness _articleBusiness, IStuffBusiness _stuffBusiness, IBillBusiness _billBusiness, IBillItemBusiness _billItemBusines)
        {
            InitializeComponent();
            articleBusiness = _articleBusiness;
            stuffBusiness = _stuffBusiness;
            billBusiness = _billBusiness;
            billItemBusiness = _billItemBusines;
          
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
        private void Articals_Load(object sender, EventArgs e)
        {
            dgArticles.AutoGenerateColumns = false;
            UpdateDataGrid();
        }

        private void btnArticalAdd_Click(object sender, EventArgs e)
        {
            if (PresentationLayer.Properties.Settings.Default.UserId == 1003)
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
            Article article = new Article();
                try
                {
                    
                    article.Name = tbArticalName.Text;
                    article.Price = Decimal.Parse(tbArticalPrice.Text);
                    article.Type = type;
                    article.Description = tbArticalDescription.Text;
                    if(byteimg!=null)
                    article.Image = Convert.ToBase64String(byteimg);
    
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("Greska pri unosu podataka!");
                    return;
                };

            bool result = this.articleBusiness.InsertArticle(article);
            if (result)
                MessageBox.Show("Uspesan unos artikla!");
            else
                MessageBox.Show("Unos artikala nije uspesan!");
            UpdateDataGrid();
            DeleteTextBox();
            
                
            }
            else
            {
                MessageBox.Show("Morate se prijaviti kao admin da bi dodavali artikle!");
                DeleteTextBox();
            }
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
                    lblFileName.Visible = false;
                    lblFileName.Text = openFile.FileName;
                    img = Image.FromFile(lblFileName.Text);
                    byteimg = ConvertImageToBinary(img);
                    pictureBox1.Image = img;

                }
            }
        }
        private void btnArticalDelete_Click(object sender, EventArgs e)
        {
            if (PresentationLayer.Properties.Settings.Default.UserId == 1003)
            {
               
                int idSelect = Convert.ToInt32(dgArticles.SelectedRows[0].Cells["Id"].Value.ToString());
                 if(articleBusiness.IsArticleConnectedToBill(idSelect)==true)
                {
                    MessageBox.Show("Ne mozete izbrisati ovu stavku jer se nalazi na racunu!");
                }
                 else
                {
                    bool result = this.articleBusiness.DeleteArticle(idSelect);
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
            }
            else
            {
                MessageBox.Show("Morate se prijaviti kao admin da bi brisali!");
            }
        }

        private void btnArticalChange_Click(object sender, EventArgs e)
        {
            if (PresentationLayer.Properties.Settings.Default.UserId == 1003)
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
                Article article = articleBusiness.GetSelectedArticle(idSelect);
                article.Name = tbArticalName.Text;
                article.Price = Decimal.Parse(tbArticalPrice.Text);
                article.Type = type;
                article.Description = tbArticalDescription.Text;
                if(byteimg!=null)
                article.Image = Convert.ToBase64String(byteimg);
                bool result = articleBusiness.UpdateArticle(article);
                if (result)
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
            else
            {
                MessageBox.Show("Morate se prijaviti kao admin da bi menjali artikle!");
            }
        
        }

        private void dgArticles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSelect = Convert.ToInt32(dgArticles.SelectedRows[0].Cells["Id"].Value.ToString());

            Article article = this.articleBusiness.GetSelectedArticle(idSelect);
            tbArticalName.Text = article.Name;
            tbArticalPrice.Text = article.Price.ToString();
            tbArticalDescription.Text = article.Description;
            byteimg = Convert.FromBase64String(article.Image);
            if(article.Image!="")
                pictureBox1.Image = ConvertBinaryToImage(Convert.FromBase64String(article.Image));
            if (article.Type.Contains("POPSI"))
                cbPops.Checked = true;
            else
                cbPops.Checked = false;
            if (article.Type.Contains("KROFNE"))
                cbDonut.Checked = true;
            else
                cbDonut.Checked = false;
            if (article.Type.Contains("MAFINI"))
                cbMuffin.Checked = true;
            else cbMuffin.Checked = false;
            if (article.Type.Contains("BOX"))
                cbBox.Checked = true;
            else
                cbBox.Checked = false;
        }

        private void ArticleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            //Main main = new Main(articleBusiness, billBusiness,billItemBusiness,stuffBusiness);
           // main.Main_Load();
            
        }
    }
}
