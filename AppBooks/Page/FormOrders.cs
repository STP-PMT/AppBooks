using AppBooks.Page.dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBooks
{
    public partial class FormOrders : Form
    {
        dbBookEntities context = new dbBookEntities();
        int oid = -1;
        public FormOrders()
        {
            InitializeComponent();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine("Date : " + monthCalendar.SelectionRange.Start.ToString());
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            dgvOrdersAll.Font = new Font("TH-Sarabun", 10, FontStyle.Regular);
            var result = (
                 from o in context.Orders
                 join b in context.Books on o.bid equals b.bid
                 join t in context.Types on b.type equals t.tid
                 select new
                 {
                     รหัสรายการ = o.oid,
                     ชื่อหนังสือ = b.name,
                     ชื่อ = o.name,
                     เบอร์โทร = o.phone,
                     วันที่ต้องคืน = o.edate
                 }) ;
            dgvOrdersAll.DataSource = result.ToList();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            FormManageOrders form = new FormManageOrders();
            form.ShowDialog();
            if (form.status == 1)
            {
                FormOrders_Load(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(oid != -1)
            {
                FormManageOrders form = new FormManageOrders(oid);
                form.ShowDialog();
                if (form.status == 1)
                {
                    FormOrders_Load(sender, e);
                }
            }
           
        }

        private void dgvOrdersAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvOrdersAll.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvOrdersAll.CurrentRow.Selected = true;
                int id = int.Parse(dgvOrdersAll.Rows[e.RowIndex].Cells["รหัสรายการ"].FormattedValue.ToString());
                oid = id;
            }
        }
    }
}
