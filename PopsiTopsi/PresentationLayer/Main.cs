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
    
    public partial class Main : Form
    {
        public readonly ArticleBusiness articleBusiness;
        public readonly BillBusiness billBusiness;
        public readonly BillItemBusiness billItemBusiness;
        public readonly StuffBusiness stuffBusiness;
        


        public Main()
        {
            
            InitializeComponent();
            this.articleBusiness = new ArticleBusiness();
            this.billBusiness = new BillBusiness();
            this.billItemBusiness = new BillItemBusiness();
            this.stuffBusiness = new StuffBusiness();
            
        }
       

        private void Main_Load(object sender, EventArgs e)
        {
            FillMainForm();
        }
        public void FillMainForm()
        {
            List<Article> list = this.articleBusiness.GetAllArticles();
            foreach(Article a in list)
            {
               
                ArticlesPanel ap = new ArticlesPanel(a);
                panelArticles.Controls.Add(ap);
                
                ap.Click += Ap_Click;
            }
        }

        private void Ap_Click(object sender, EventArgs e)
        {
            ArticlesPanel panel = (ArticlesPanel)sender;
            bool duplicate=false;

            if (dgBill.Rows.Count != 0)
            {
                foreach (DataGridViewRow r in dgBill.Rows)
                {
                    if ((int)r.Cells[0].Value == panel.article.Id)
                    {
                        duplicate = true;
                        r.Cells[3].Value = (int)r.Cells[3].Value + 1;
                        break;
                    }
                }

            }
                if (!duplicate)
                {
                    int rowId = dgBill.Rows.Add();
                    DataGridViewRow row = dgBill.Rows[rowId];
                    row.Cells[0].Value = panel.article.Id;
                    row.Cells[1].Value = panel.article.Name;
                    row.Cells[3].Value = 1;
                    row.Cells[2].Value = panel.article.Price;
                }
        }

        private void prijavaZaposlenogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login lg = new Login();

        }

        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticleForm article = new ArticleForm();
            //this.Hide();
            article.ShowDialog();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stuffs stuffs = new Stuffs();
            stuffs.ShowDialog();
        }

        private void računiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.ShowDialog();
        }

        private void buttonDonuts_Click(object sender, EventArgs e)
        {
            panelArticles.Controls.Clear();
            buttonDonuts.BackColor = Color.Silver;
            List<Article> list = this.articleBusiness.GetAllArticles();
            foreach (Article a in list)
            {
                if(a.Type.Contains("KROFNE"))
                    {
                    ArticlesPanel ap = new ArticlesPanel(a);
                    panelArticles.Controls.Add(ap);

                    ap.Click += Ap_Click;
                }
                
            }
          
        }

        private void buttonMuffins_Click(object sender, EventArgs e)
        {
            panelArticles.Controls.Clear();
            buttonMuffins.BackColor = Color.Silver;
            buttonDonuts.BackColor= Color.FromArgb(255, 192, 192);
            buttonPops.BackColor = Color.FromArgb(255, 192, 192);
            buttonBoxs.BackColor = Color.FromArgb(255, 192, 192);

            List <Article> list = this.articleBusiness.GetAllArticles();
            foreach (Article a in list)
            {
                if (a.Type.Contains("MAFINI"))
                {
                    ArticlesPanel ap = new ArticlesPanel(a);
                    panelArticles.Controls.Add(ap);

                    ap.Click += Ap_Click;
                }

            }
        }

        private void buttonPops_Click(object sender, EventArgs e)
        {
            panelArticles.Controls.Clear();
            buttonPops.BackColor = Color.Silver;
            buttonMuffins.BackColor = Color.FromArgb(255, 192, 192);
            buttonDonuts.BackColor = Color.FromArgb(255, 192, 192);
            buttonBoxs.BackColor = Color.FromArgb(255, 192, 192);

            List<Article> list = this.articleBusiness.GetAllArticles();
            foreach (Article a in list)
            {
                if (a.Type.Contains("POPSI"))
                {
                    ArticlesPanel ap = new ArticlesPanel(a);
                    panelArticles.Controls.Add(ap);

                    ap.Click += Ap_Click;
                }

            }
        }

        private void buttonBoxs_Click(object sender, EventArgs e)
        {
            panelArticles.Controls.Clear();
            buttonBoxs.BackColor = Color.Silver;
            List<Article> list = this.articleBusiness.GetAllArticles();
            foreach (Article a in list)
            {
                if (a.Type.Contains("BOXOVI"))
                {
                    ArticlesPanel ap = new ArticlesPanel(a);
                    panelArticles.Controls.Add(ap);

                    ap.Click += Ap_Click;
                }

            }
        }
    }
}
