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

        }

        private void prijavaZaposlenogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login lg = new Login();

        }

        private void artikliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Article article = new Article();
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
    }
}
