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
        int oid = -1;
        int bid = -1;
        public int status { get; set; }
        private dbBookEntities context = new dbBookEntities();
        public FormManageOrders()
        {
            InitializeComponent();
        }
        public FormManageOrders(int id)
        {
            this.oid = id;
            InitializeComponent();
        }

        private void FormManageOrders_Load(object sender, EventArgs e)
        {
            dgvManageOrders.Font = new Font("TH-Sarabun", 10, FontStyle.Regular);
            dtpSdate.Value = DateTime.Now;
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
            if (oid != -1)
            {
                lbTitle.Text = "แก้ไขข้อมูล";
                var rsOrder = (
                from o in context.Orders
                join b in context.Books on o.bid equals b.bid
                where o.oid == oid
                select new
                {
                    o.name,
                    o.phone,
                    book = b.name,
                    b.bid,
                    o.sdate,
                    o.edate

                }).FirstOrDefault();
                tbName.Text = rsOrder.name.Trim();
                tbPhone.Text = rsOrder.phone.Trim();
                lbBookName.Text = rsOrder.book.Trim();
                dtpSdate.Value = Convert.ToDateTime(rsOrder.sdate);
                dtpOrders.Value = Convert.ToDateTime(rsOrder.edate);
                dtpOrders.MaxDate = Convert.ToDateTime(rsOrder.sdate).AddDays(7);
                dtpOrders.MinDate = Convert.ToDateTime(rsOrder.sdate);
                
                bid = rsOrder.bid;
            }
            else {
                dtpOrders.MaxDate = dtpOrders.Value.AddDays(7);
                dtpOrders.MinDate = dtpOrders.Value;
            }
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            if (oid != -1)
            {
                order = (
                from o in context.Orders
                where o.oid == oid
                select o).FirstOrDefault();
                if (order == null) return;
                order.name = tbName.Text;
                order.phone = tbPhone.Text;
                order.bid = bid;
                order.sdate = dtpSdate.Value;
                order.edate = dtpOrders.Value;
                int check = context.SaveChanges();
                if (check == 1)
                {
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                    Dispose();
                }
                else
                {
                    MessageBox.Show("แก้ไขข้อมูลไม่สำเร็จ");
                }
            }
            else
            {
                order.name = tbName.Text;
                order.phone = tbPhone.Text;
                order.bid = bid;
                order.sdate = dtpSdate.Value;
                order.edate = dtpOrders.Value;
                context.Orders.Add(order);               
                int check = context.SaveChanges();
                if (check == 1)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                    Dispose();
                }
                else
                {
                    MessageBox.Show("เพิ่มข้อมูลไม่สำเร็จ");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}