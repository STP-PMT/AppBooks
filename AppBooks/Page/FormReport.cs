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
    public partial class FormReport : Form
    {
        dbBookEntities context = new dbBookEntities();
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            dgvOrdersAll.Font = new Font("TH-Sarabun", 10, FontStyle.Regular);
            loadData();
        }

        private void loadData()
        {
            var result = (
                 from o in context.Orders
                 join b in context.Books on o.bid equals b.bid
                 join t in context.Types on b.type equals t.tid
                 where b.status == 0
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

        private void dgvOrdersAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvOrdersAll.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvOrdersAll.CurrentRow.Selected = true;
                int id = int.Parse(dgvOrdersAll.Rows[e.RowIndex].Cells["รหัสรายการ"].FormattedValue.ToString());
                
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
                     Image = b.image,

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
                int num = (DateTime.Now - result.Edate).Days;
                lbPrice.Text = (num * 5).ToString();
            }
        }
    }
}
