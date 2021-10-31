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

namespace AppBooks.Page.dialog
{
    public partial class FormManageBooks : Form
    {
        int bid =-1;
        Dictionary<string, int> bookType = new Dictionary<string, int>();
        dbBookEntities context = new dbBookEntities();
        public FormManageBooks()
        {
            InitializeComponent();
            
        }

        public byte[] ImageToByteArray(Image image)
        {
            var ms = new MemoryStream();
            image.Save(ms, image.RawFormat);
            return ms.ToArray();
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

        private void FormManageBooks_Load(object sender, EventArgs e)
        {
            var rsType = context.Types;
            foreach (var t in rsType)
            {
                bookType.Add(t.name, t.tid);
                cbbBook.Items.Add(t.name);
            }
           

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (bid != -1)
            {

            }
            else
            {
                Book book = new Book();
                book.name = tbNameBook.Text;
                book.detail = tbDetail.Text;
                book.type = cbbBook.SelectedItem != null ? bookType[ cbbBook.SelectedItem.ToString()]:1;
                Console.WriteLine(book.type);
                if (pictureBoxBook.Image != null)
                {
                    book.image = ImageToByteArray(pictureBoxBook.Image);
                }
                else
                {
                    book.image = null;
                }              
                context.Books.Add(book);
                int check = context.SaveChanges();
                if (check == 1)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                }
                else
                {
                    MessageBox.Show("เพิ่มข้อมูลไม่สำเร็จ");
                }
            }
        }
    }
}
