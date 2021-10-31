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
    public partial class FormManageBooks : Form
    {
        public FormManageBooks()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogBook.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBook.Image = Image.FromFile(openFileDialogBook.FileName);
            }
        }
    }
}
