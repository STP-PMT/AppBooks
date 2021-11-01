using AppBooks.Page.dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

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
            loadData();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            dgvOrdersAll.Font = new Font("TH-Sarabun", 10, FontStyle.Regular);
            loadData();
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
            oid = -1;
           
        }

        private void dgvOrdersAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvOrdersAll.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvOrdersAll.CurrentRow.Selected = true;
                int id = int.Parse(dgvOrdersAll.Rows[e.RowIndex].Cells["รหัสรายการ"].FormattedValue.ToString());
                oid = id;
                var result = (
                 from o in context.Orders
                 join b in context.Books on o.bid equals b.bid
                 join t in context.Types on b.type equals t.tid
                 where o.oid == id
                 select new
                 {
                     NameBook = b.name,
                     Detail = b.detail,
                     Sdate = o.sdate,
                     Edate = o.edate,
                     Username = o.name,
                     Phone = o.phone,
                     Image = b.image
                     
                 }).FirstOrDefault();
                lbName.Text = result.NameBook;
                lbDetail.Text = result.Detail;
                lbSdate.Text = result.Sdate.ToString("dd MMM yyyy");
                lbEdate.Text = result.Edate.ToString("dd MMM yyyy");
                lbUserName.Text = result.Username;
                lbPhone.Text = result.Phone;
                if (result.Image != null)
                {
                    ptbOrder.Image = (Bitmap)(new ImageConverter()).ConvertFrom(result.Image);
                }
                //lbPrice.Text = 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        
            if (oid != -1)
            {
                if (MessageBox.Show("ต้องการลบรายการ " + oid + " หรือไม่?", "ลบรายการ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var del = context.Orders
                    .Where(o => o.oid == oid)
                    .First();
                    context.Orders.Remove(del);
                    context.SaveChanges();
                }
                FormOrders_Load(sender, e);
            }
            oid = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (oid != -1) {
                if (MessageBox.Show("ยืนยันการคืนหนังสือ" + oid + " หรือไม่?", "ยืนยันการคืนหนังสือ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var order = (from o in context.Orders
                                 join b in context.Books on o.bid equals b.bid
                                 join t in context.Types on b.type equals t.tid
                                 where o.oid == oid
                                 select b).FirstOrDefault();
                    order.status = 0;
                    context.SaveChanges();
                }
            }
            FormOrders_Load(sender, e);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            var result = (from o in context.Orders
                 join b in context.Books on o.bid equals b.bid
                 join t in context.Types on b.type equals t.tid
                 where b.status == 1 
                 select new
                 {
                     รหัสรายการ = o.oid,
                     ชื่อหนังสือ = b.name,
                     ชื่อ = o.name,
                     เบอร์โทร = o.phone,
                     วันที่ต้องคืน = o.edate
                 });
            dgvOrdersAll.DataSource = result.ToList();
        }
        
        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var result = (
                 from o in context.Orders
                 join b in context.Books on o.bid equals b.bid
                 join t in context.Types on b.type equals t.tid
                 where b.status == 1 && o.edate == monthCalendar.SelectionRange.Start
                 select new
                 {
                     รหัสรายการ = o.oid,
                     ชื่อหนังสือ = b.name,
                     ชื่อ = o.name,
                     เบอร์โทร = o.phone,
                     วันที่ต้องคืน = o.edate
                 });
            dgvOrdersAll.DataSource = result.ToList();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            var result = (
                 from o in context.Orders
                 join b in context.Books on o.bid equals b.bid
                 join t in context.Types on b.type equals t.tid
                 where b.status == 1 && o.edate < monthCalendar.SelectionRange.Start
                 select new
                 {
                     รหัสรายการ = o.oid,
                     ชื่อหนังสือ = b.name,
                     ชื่อ = o.name,
                     เบอร์โทร = o.phone,
                     วันที่ต้องคืน = o.edate
                 });
            dgvOrdersAll.DataSource = result.ToList();
        }
    }
}
