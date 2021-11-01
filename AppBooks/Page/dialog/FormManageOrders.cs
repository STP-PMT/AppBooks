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
            dtpOrders.MaxDate = dtpOrders.Value.AddDays(7);
            dtpOrders.MinDate = dtpOrders.Value;
            lbDate.Text = dtpOrders.Value.Date.ToString("dd.MM.yyyy");
        }

        private void FormManageOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            status = 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
