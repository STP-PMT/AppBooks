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
    public partial class FormBooks : Form
    {
        dbBookEntities context = new dbBookEntities();
        public FormBooks()
        {
            InitializeComponent();
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
                     ประเภท = t.name                     
                 });

            dgvBooks.DataSource = result.ToList();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvBooks.CurrentRow.Selected = true;
                Console.WriteLine(dgvBooks.Rows[e.RowIndex].Cells["รหัสหนังสือ"].FormattedValue.ToString());

            }
        }
    }
}
