using AppBooks.Page.dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBooks
{
    public partial class FormBooks : Form
    {
        dbBookEntities context = new dbBookEntities();
        int bid = -1;
        public FormBooks()
        {
            InitializeComponent();
        }

        public byte[] ImageToByteArray(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            dgvBooks.Font = new Font("TH-Sarabun", 10, FontStyle.Regular);
            var result = (
                 from b in context.Books
                 join t in context.Types
                 on b.type equals t.tid
                 select new
                 {
                     รหัสหนังสือ = b.bid,
                     ชื่อหนังสือ = b.name,
                     รายละเอียด = b.detail,
                     ประเภท = t.name,
                 });

            dgvBooks.DataSource = result.ToList();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBoxBook.Image = null;
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvBooks.CurrentRow.Selected = true;
                int id = int.Parse(dgvBooks.Rows[e.RowIndex].Cells["รหัสหนังสือ"].FormattedValue.ToString());
                bid = id;
                var result = (
                from b in context.Books
                join t in context.Types
                on b.type equals t.tid
                where b.bid == id
                select new
                {
                    b.name,
                    b.detail,
                    type = t.name,
                    b.image,
                    b.status
                }).FirstOrDefault();
                lbName.Text = result.name;
                lbDetail.Text = result.detail;
                lbType.Text = result.type;
                lbStatus.Text = (result.status == 0) ? "มีอยู่" : "ถูกยืม";

                if (result.image != null)
                {
                    pictureBoxBook.Image = (Bitmap)(new ImageConverter()).ConvertFrom(result.image);
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FormManageBooks form = new FormManageBooks();
            form.ShowDialog();
            if (form.status == 1)
            {
                FormBooks_Load(sender, e);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bid != -1)
            {
                FormManageBooks form = new FormManageBooks(bid);
                form.ShowDialog();
                if (form.status == 1)
                {
                    FormBooks_Load(sender, e);
                }
            }
            bid = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bid != -1)
            {
                if (MessageBox.Show("ต้องการลบรายการ " + bid + " หรือไม่?", "ลบรายการ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var del = context.Books
                    .Where(b => b.bid == bid)
                    .First();
                    context.Books.Remove(del);
                    int change = context.SaveChanges();
                }
            }
            bid = -1;
        }
    }
}
