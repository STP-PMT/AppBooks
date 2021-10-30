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
    public partial class FormHome : Form
    {
        private Color c = Color.FromArgb(100, 70, 185, 255);
        public FormHome()
        {
            InitializeComponent();
        }

        private void setColorButton()
        {
            btnHome.BackColor = Color.White;
            btnBooks.BackColor = Color.White;
            btnOrders.BackColor = Color.White;
            btnTypes.BackColor = Color.White;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setColorButton();
            btnHome.BackColor = c;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            setColorButton();
            btnOrders.BackColor = c;
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            setColorButton();
            btnBooks.BackColor = c;
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            setColorButton();
            btnTypes.BackColor = c;
        }
    }
}
