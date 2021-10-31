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
        public FormManageBooks(int id)
        {
            this.bid = id;
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
            if(bid != -1)
            {
                lbTitle.Text = "แก้ไขข้อมูล";
                var result = (
                from b in context.Books
                join t in context.Types
                on b.type equals t.tid
                where b.bid == bid
                select new
                {
                    b.name,
                    b.detail,
                    type = t.name,
                    b.image
                }).FirstOrDefault();
                    tbNameBook.Text = result.name;
                    tbDetail.Text = result.detail;
                    cbbBook.Text = result.type;
                    if (result.image != null)
                    {
                        pictureBoxBook.Image = (Bitmap)(new ImageConverter()).ConvertFrom(result.image);
                    }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            Book book = new Book();
            if (bid != -1)
            {
                book = (
                from b in context.Books
                where b.bid == bid
                select b).FirstOrDefault();
                if (book == null) return;
                book.name = tbNameBook.Text.Trim();
                book.detail = tbDetail.Text.Trim();
                book.type = cbbBook.SelectedItem != null ? bookType[cbbBook.SelectedItem.ToString()] : 1;
                Console.WriteLine(book.type);
                if (pictureBoxBook.Image != null)
                {
                    book.image = ImageToByteArray(pictureBoxBook.Image);
                }
                else
                {
                    book.image = null;
                } 
                int check = context.SaveChanges();
                if (check == 1)
                {
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                }
                else
                {
                    MessageBox.Show("แก้ไขข้อมูลไม่สำเร็จ");
                }
            }
            else
            {                
                book.name = tbNameBook.Text.Trim();
                book.detail = tbDetail.Text.Trim();
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
