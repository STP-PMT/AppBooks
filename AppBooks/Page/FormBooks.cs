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
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvBooks.CurrentRow.Selected = true;
                int id = int.Parse( dgvBooks.Rows[e.RowIndex].Cells["รหัสหนังสือ"].FormattedValue.ToString());
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
                    b.image
                });
                foreach(var i in result)
                {
                    lbName.Text = i.name;
                    lbDetail.Text = i.detail;
                    lbType.Text = i.type;
                    if (i.image != null) 
                    {
                        pictureBoxBook.Image = (Bitmap)(new ImageConverter()).ConvertFrom(i.image);
                    }                    
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FormManageBooks form = new FormManageBooks();           
            form.ShowDialog();
        }
    }
}
