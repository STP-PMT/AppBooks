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
    public partial class FormDeleteBooks : Form
    {
        int id = -1;
        public int status { get; set; }
        dbBookEntities context = new dbBookEntities();
        public FormDeleteBooks()
        {
            InitializeComponent();
        }

        public FormDeleteBooks(int  id )
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           if(id!=-1)
            {
                var del = context.Books
                    .Where(b => b.bid == id)
                    .First();
                context.Books.Remove(del);

                int change = context.SaveChanges();                
                this.Close();
            }                        
        }

        private void FormDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            status = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
