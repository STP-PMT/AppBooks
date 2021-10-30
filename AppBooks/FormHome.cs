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
            btnReport.BackColor = Color.White;
        }

        private Form temp = null;
        private void openChildForm(Form form)
        {
            if(temp !=null)
            {
                temp.Close();
            }
            temp = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelDetail.Controls.Add(form);
            panelDetail.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setColorButton();
            btnHome.BackColor = c;
            openChildForm(new FormPageHome());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            setColorButton();
            btnOrders.BackColor = c;
            openChildForm(new FormOrders());
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            setColorButton();
            btnBooks.BackColor = c;
            openChildForm(new FormBooks());
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            setColorButton();
            btnTypes.BackColor = c;
            openChildForm(new FormTypes());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            setColorButton();
            btnReport.BackColor = c;
            openChildForm(new FormReport());
        }
    }
}
