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
        public int status { get; set; }
        public FormManageOrders()
        {
            InitializeComponent();
        }

        private void FormManageOrders_Load(object sender, EventArgs e)
        {

        }

        private void FormManageOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            status = 1;
        }
    }
}
