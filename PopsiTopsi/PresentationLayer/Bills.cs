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
    public partial class Bills : Form
    {
        public readonly IBillBusiness billBusiness;
        public readonly IBillItemBusiness billItemBusiness;
        public readonly IArticleBusiness articleBusiness;

        public Bills(IBillBusiness _billBusiness, IBillItemBusiness _billItemBusiness, IArticleBusiness _articleBusiness)
        {
            InitializeComponent();
            this.billBusiness = _billBusiness;
            this.billItemBusiness = _billItemBusiness;
            this.articleBusiness = _articleBusiness;
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            List<Bill>list = this.billBusiness.GetAllBills();
            foreach(Bill b in list)
            {
                int rowId = dgvBills.Rows.Add();
                DataGridViewRow row = dgvBills.Rows[rowId];
                row.Cells[0].Value = b.Id;
                row.Cells[1].Value = b.Date;
                row.Cells[2].Value = b.Total;
            }
            
        }

        private void dgvBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idSelect = Convert.ToInt32(dgvBills.SelectedRows[0].Cells["Id"].Value.ToString());
            string bill = "";
            TextBox richTextBox1 = new TextBox();
            richTextBox1.Font = new Font("Consolas", 12, FontStyle.Regular);
            richTextBox1.Multiline = true;
            richTextBox1.Size = new System.Drawing.Size(360, 670);

            Bill b = billBusiness.GetAllBills().FirstOrDefault(s => s.Id == idSelect);
            List<BillItem> billItems = billItemBusiness.GetAllBillItems().Where(s => s.Bill_Id == idSelect).ToList();
            bill += "-------------------------------------\n\n";
            bill += "\t\t FISKALNI RACUN\n\n";
            bill += "\t  " + String.Format("{0:d/M/yyyy}", b.Date) + "    " + String.Format("{0:HH:mm:ss}", b.Date) + "\n";
            bill += "-------------------------------------\n\n";

            foreach (BillItem bit in billItems)
            {
                Article article = articleBusiness.GetAllArticles().FirstOrDefault(a => a.Id == bit.Article_Id);
                bill += article.Name + "\n";
                bill += "\t   " + bit.Quantity + " x " + article.Price + "\t" + "din.\n";
            }
            bill += "-------------------------------------\n\n";
            bill += "\tTotal : \t\t\t" + b.Total + "din.\n";
            bill += "-------------------------------------\n\n";

            richTextBox1.Text = bill;
            BillPanel panel = new BillPanel();
            panel.Controls.Add(richTextBox1);
            panel.ShowDialog();

        }
    }
}
