using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBooks.Page.dialog
{
    public partial class FormManageOrders : Form
    {
        int bid = -1;
        public int status { get; set; }
        private dbBookEntities context = new dbBookEntities();
        public FormManageOrders()
        {
            InitializeComponent();
        }

        private void FormManageOrders_Load(object sender, EventArgs e)
        {
            dgvManageOrders.Font = new Font("TH-Sarabun", 10, FontStyle.Regular);
            dtpOrders.MaxDate = dtpOrders.Value.AddDays(7);
            dtpOrders.MinDate = dtpOrders.Value;
            lbDate.Text = dtpOrders.Value.Date.ToString("dd.MM.yyyy");
            var result = (
                 from b in context.Books
                 join t in context.Types
                 on b.type equals t.tid
                 where b.status == 0
                 select new
                 {
                     รหัสหนังสือ = b.bid,
                     ชื่อหนังสือ = b.name,
                     ประเภท = t.name,
                 });

            dgvManageOrders.DataSource = result.ToList();
        }

        private void FormManageOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            status = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dgvManageOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvManageOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) 
            {
                dgvManageOrders.CurrentRow.Selected = true;
                int id = int.Parse(dgvManageOrders.Rows[e.RowIndex].Cells["รหัสหนังสือ"].FormattedValue.ToString());
                bid = id;
                var result = (
                from b in context.Books
                where b.bid == id
                select new
                {
                    b.name,
                }).FirstOrDefault();
                lbBookName.Text = result.name;
            }
        }
    }
}
