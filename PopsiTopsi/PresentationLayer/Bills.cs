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
        public readonly IStuffBusiness stuffBusiness;
        public Bills(IBillBusiness _billBusiness, IBillItemBusiness _billItemBusiness, IArticleBusiness _articleBusiness, IStuffBusiness _stuffBusiness)
        {
            InitializeComponent();
            this.billBusiness = _billBusiness;
            this.billItemBusiness = _billItemBusiness;
            this.articleBusiness = _articleBusiness;
            this.stuffBusiness = _stuffBusiness;
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
            Bill bill = billBusiness.GetAllBills().FirstOrDefault(s => s.Id == idSelect);
            Stuff s = stuffBusiness.GetAllStuffs().FirstOrDefault(s => s.Id == PresentationLayer.Properties.Settings.Default.UserId);
            BillPanel bp = new BillPanel(bill,billItemBusiness,articleBusiness,s.Username);
            bp.ShowDialog();


        }
    }
}
