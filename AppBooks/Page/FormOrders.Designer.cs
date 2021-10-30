
namespace AppBooks
{
    partial class FormOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.tabEnd = new System.Windows.Forms.TabPage();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelDetailOrder = new System.Windows.Forms.Panel();
            this.labelTitleOrders = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDetailBook = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDetail = new System.Windows.Forms.Label();
            this.labelSdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSdate = new System.Windows.Forms.Label();
            this.lbEdate = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabAll.SuspendLayout();
            this.panelDetailOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(546, 373);
            this.dgvOrders.TabIndex = 0;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar.Location = new System.Drawing.Point(584, 18);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabAll);
            this.tabControl1.Controls.Add(this.tabEnd);
            this.tabControl1.Location = new System.Drawing.Point(12, 170);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 405);
            this.tabControl1.TabIndex = 2;
            // 
            // tabAll
            // 
            this.tabAll.Controls.Add(this.dgvOrders);
            this.tabAll.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAll.Location = new System.Drawing.Point(4, 22);
            this.tabAll.Name = "tabAll";
            this.tabAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabAll.Size = new System.Drawing.Size(552, 379);
            this.tabAll.TabIndex = 0;
            this.tabAll.Text = "ทั้งหมด";
            this.tabAll.UseVisualStyleBackColor = true;
            // 
            // tabEnd
            // 
            this.tabEnd.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEnd.Location = new System.Drawing.Point(4, 22);
            this.tabEnd.Name = "tabEnd";
            this.tabEnd.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnd.Size = new System.Drawing.Size(552, 303);
            this.tabEnd.TabIndex = 1;
            this.tabEnd.Text = "เลยกำหนด";
            this.tabEnd.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(356, 144);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(149, 20);
            this.tbSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(511, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panelDetailOrder
            // 
            this.panelDetailOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetailOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDetailOrder.Controls.Add(this.lbPhone);
            this.panelDetailOrder.Controls.Add(this.lbUserName);
            this.panelDetailOrder.Controls.Add(this.label6);
            this.panelDetailOrder.Controls.Add(this.labelUser);
            this.panelDetailOrder.Controls.Add(this.lbEdate);
            this.panelDetailOrder.Controls.Add(this.lbSdate);
            this.panelDetailOrder.Controls.Add(this.label2);
            this.panelDetailOrder.Controls.Add(this.labelSdate);
            this.panelDetailOrder.Controls.Add(this.lbDetail);
            this.panelDetailOrder.Controls.Add(this.lbName);
            this.panelDetailOrder.Controls.Add(this.labelDetailBook);
            this.panelDetailOrder.Controls.Add(this.labelName);
            this.panelDetailOrder.Controls.Add(this.pictureBox1);
            this.panelDetailOrder.Location = new System.Drawing.Point(584, 192);
            this.panelDetailOrder.Name = "panelDetailOrder";
            this.panelDetailOrder.Size = new System.Drawing.Size(227, 376);
            this.panelDetailOrder.TabIndex = 5;
            // 
            // labelTitleOrders
            // 
            this.labelTitleOrders.Font = new System.Drawing.Font("Prompt", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(254)))));
            this.labelTitleOrders.Location = new System.Drawing.Point(12, 23);
            this.labelTitleOrders.Name = "labelTitleOrders";
            this.labelTitleOrders.Size = new System.Drawing.Size(140, 45);
            this.labelTitleOrders.TabIndex = 6;
            this.labelTitleOrders.Text = "รายการยืม";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(13, 123);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 19);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ชื่อหนังสือ :";
            // 
            // labelDetailBook
            // 
            this.labelDetailBook.AutoSize = true;
            this.labelDetailBook.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailBook.Location = new System.Drawing.Point(8, 152);
            this.labelDetailBook.Name = "labelDetailBook";
            this.labelDetailBook.Size = new System.Drawing.Size(78, 19);
            this.labelDetailBook.TabIndex = 2;
            this.labelDetailBook.Text = "รายละเอียด :";
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(92, 123);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(120, 19);
            this.lbName.TabIndex = 3;
            // 
            // lbDetail
            // 
            this.lbDetail.BackColor = System.Drawing.Color.White;
            this.lbDetail.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetail.Location = new System.Drawing.Point(92, 152);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(120, 52);
            this.lbDetail.TabIndex = 4;
            // 
            // labelSdate
            // 
            this.labelSdate.AutoSize = true;
            this.labelSdate.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdate.Location = new System.Drawing.Point(30, 219);
            this.labelSdate.Name = "labelSdate";
            this.labelSdate.Size = new System.Drawing.Size(56, 19);
            this.labelSdate.TabIndex = 5;
            this.labelSdate.Text = "วันที่ยืม :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "กำหนดยืน :";
            // 
            // lbSdate
            // 
            this.lbSdate.BackColor = System.Drawing.Color.White;
            this.lbSdate.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdate.Location = new System.Drawing.Point(92, 219);
            this.lbSdate.Name = "lbSdate";
            this.lbSdate.Size = new System.Drawing.Size(120, 19);
            this.lbSdate.TabIndex = 7;
            // 
            // lbEdate
            // 
            this.lbEdate.BackColor = System.Drawing.Color.White;
            this.lbEdate.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdate.Location = new System.Drawing.Point(92, 247);
            this.lbEdate.Name = "lbEdate";
            this.lbEdate.Size = new System.Drawing.Size(120, 19);
            this.lbEdate.TabIndex = 8;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(43, 282);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(41, 19);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "ผู้ยืม :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "เบอร์โทร :";
            // 
            // lbUserName
            // 
            this.lbUserName.BackColor = System.Drawing.Color.White;
            this.lbUserName.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(92, 282);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(120, 19);
            this.lbUserName.TabIndex = 11;
            // 
            // lbPhone
            // 
            this.lbPhone.BackColor = System.Drawing.Color.White;
            this.lbPhone.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(92, 310);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(120, 19);
            this.lbPhone.TabIndex = 12;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 587);
            this.Controls.Add(this.labelTitleOrders);
            this.Controls.Add(this.panelDetailOrder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.monthCalendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabAll.ResumeLayout(false);
            this.panelDetailOrder.ResumeLayout(false);
            this.panelDetailOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.TabPage tabEnd;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelDetailOrder;
        private System.Windows.Forms.Label labelTitleOrders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDetailBook;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbEdate;
        private System.Windows.Forms.Label lbSdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSdate;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUser;
    }
}