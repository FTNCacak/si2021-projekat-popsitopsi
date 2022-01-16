using BusinessLayer;
using Shared.BusinessInterface;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{

    public partial class Main : Form
    {
        public readonly IArticleBusiness articleBusiness;
        public readonly IBillBusiness billBusiness;
        public readonly IBillItemBusiness billItemBusiness;
        public readonly IStuffBusiness stuffBusiness;



        public Main(IArticleBusiness _articleBusiness,IBillBusiness _billBusiness,IBillItemBusiness _billItemBusiness,IStuffBusiness _stuffBusiness)
        {

            InitializeComponent();
            this.articleBusiness = _articleBusiness;
            this.billBusiness = _billBusiness;
            this.billItemBusiness = _billItemBusiness;
            this.stuffBusiness = _stuffBusiness;
        }


        private void Main_Load(object sender, EventArgs e)
        {
            FillMainForm();
        }
        public void FillMainForm()
        {
            panelArticles.Controls.Clear();
            List<Article> list = this.articleBusiness.GetAllArticles();
            foreach (Article a in list)
            {

                ArticlesPanel ap = new ArticlesPanel(a);
                panelArticles.Controls.Add(ap);

                ap.Click += Ap_Click;
            }
        }

        private void Ap_Click(object sender, EventArgs e)
        {
            ArticlesPanel panel = (ArticlesPanel)sender;
            bool duplicate = false;

            if (dgBill.Rows.Count != 0)
            {
                foreach (DataGridViewRow r in dgBill.Rows)
                {
                    if ((int)r.Cells[0].Value == panel.article.Id)
                    {
                        duplicate = true;
                        r.Cells[3].Value = (int)r.Cells[3].Value + 1;
                        r.Cells[4].Value = (int)r.Cells[3].Value * panel.article.Price;
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
                row.Cells[4].Value = panel.article.Price;
            }
        }

      

        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticleForm article = new ArticleForm(articleBusiness,stuffBusiness,billBusiness,billItemBusiness);
           
            article.ShowDialog();
         

            FillMainForm();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stuffs stuffs = new Stuffs(stuffBusiness);
            stuffs.ShowDialog();
        }

        private void računiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills(billBusiness,billItemBusiness,articleBusiness,stuffBusiness);
            bills.ShowDialog();
        }

        private void buttonDonuts_Click(object sender, EventArgs e)
        {
            panelArticles.Controls.Clear();
            buttonDonuts.BackColor = Color.Silver;
            buttonMuffins.BackColor = Color.FromArgb(255, 192, 192);
            buttonBoxs.BackColor = Color.FromArgb(255, 192, 192);
            buttonPops.BackColor = Color.FromArgb(255, 192, 192);

            List<Article> list = this.articleBusiness.GetAllArticles();
            foreach (Article a in list)
            {
                if (a.Type.Contains("KROFNE"))
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
            buttonDonuts.BackColor = Color.FromArgb(255, 192, 192);
            buttonPops.BackColor = Color.FromArgb(255, 192, 192);
            buttonBoxs.BackColor = Color.FromArgb(255, 192, 192);

            List<Article> list = this.articleBusiness.GetAllArticles();
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
            buttonMuffins.BackColor = Color.FromArgb(255, 192, 192);
            buttonDonuts.BackColor = Color.FromArgb(255, 192, 192);
            buttonPops.BackColor = Color.FromArgb(255, 192, 192);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dgBill.Rows.RemoveAt(this.dgBill.SelectedRows[0].Index);
        }

      
        private void buttonPay_Click(object sender, EventArgs e)
        {
           

            int sum = 0;
            for (int i = 0; i < dgBill.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgBill.Rows[i].Cells["Sum"].Value);
            }

            Bill b = new Bill();
            b.Stuff_Id = PresentationLayer.Properties.Settings.Default.UserId;
            b.Date = DateTime.Now;
            b.Total = sum;
            this.billBusiness.InsertBill(b);
            b.Id = billBusiness.GetNewBillId();

            Stuff s = stuffBusiness.GetAllStuffs().FirstOrDefault(s => s.Id == b.Stuff_Id);

            BillItem bi = new BillItem();
            foreach (DataGridViewRow row in dgBill.Rows)
            {

                bi.Bill_Id = b.Id;
                bi.Article_Id = Convert.ToInt32(dgBill.Rows[row.Index].Cells["Id"].Value);
                bi.Quantity= Convert.ToInt32(dgBill.Rows[row.Index].Cells["Quantity"].Value);
                this.billItemBusiness.InsertBillItem(bi);
            }
            BillPanel bp = new BillPanel(b,billItemBusiness,articleBusiness,s.Username);
            bp.ShowDialog();
            dgBill.Rows.Clear();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
