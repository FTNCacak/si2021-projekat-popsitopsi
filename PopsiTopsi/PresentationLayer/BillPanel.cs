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
    public partial class BillPanel : Form
    {
        public readonly IBillItemBusiness billItemBusiness;
        public readonly IArticleBusiness articleBusiness;
        public BillPanel(Bill b, IBillItemBusiness _billItemBusiness, IArticleBusiness _articleBusiness,string stuffUsername)
        {
            InitializeComponent();
            this.billItemBusiness = _billItemBusiness;
            this.articleBusiness = _articleBusiness;
            string bill = "";
            

            
            List<BillItem> billItems = billItemBusiness.GetAllBillItems().Where(s => s.Bill_Id == b.Id).ToList();
            bill += "-----------------------------------------\n\n";
            bill += "\t\t FISKALNI RACUN\n\n";
            bill += "\t \t " + String.Format("{0:d/M/yyyy}", b.Date) + "    " + String.Format("{0:HH:mm:ss}", b.Date) + "\n";
            bill += "------------------------------------------\n\n";

            foreach (BillItem bit in billItems)
            {
                Article article = articleBusiness.GetAllArticles().FirstOrDefault(a => a.Id == bit.Article_Id);
                bill +=  "\t"+article.Name + "\n\n";
                bill +=  "\t\t\t"+ bit.Quantity + " x " + article.Price + " din.\n\n";
            }
            bill += "-----------------------------------------\n\n";
            bill += "\tUkupno : \t\t" + b.Total + " din.\n";
            bill += "-----------------------------------------\n\n";
            bill += "\n\n\t\t Radnik:" +stuffUsername;
            richTextBox1.Text = bill;
           
           
        }

        private void BillPanel_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
