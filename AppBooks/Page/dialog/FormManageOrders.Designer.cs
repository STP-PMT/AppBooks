
namespace AppBooks.Page.dialog
{
    partial class FormManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageOrders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSdate = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.dtpOrders = new System.Windows.Forms.DateTimePicker();
            this.dgvManageOrders = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelBookName = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.dtpSdate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 60);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(257, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(207, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "เพิ่มรายการยืมหนังสือ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpSdate);
            this.panel2.Controls.Add(this.lbBookName);
            this.panel2.Controls.Add(this.labelBookName);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.dgvManageOrders);
            this.panel2.Controls.Add(this.dtpOrders);
            this.panel2.Controls.Add(this.tbPhone);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelUser);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelSdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 359);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "เบอร์โทร :";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(39, 60);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(41, 19);
            this.labelUser.TabIndex = 13;
            this.labelUser.Text = "ผู้ยืม :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "กำหนดคืน :";
            // 
            // labelSdate
            // 
            this.labelSdate.AutoSize = true;
            this.labelSdate.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdate.Location = new System.Drawing.Point(21, 158);
            this.labelSdate.Name = "labelSdate";
            this.labelSdate.Size = new System.Drawing.Size(56, 19);
            this.labelSdate.TabIndex = 11;
            this.labelSdate.Text = "วันที่ยืม :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(86, 59);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(151, 20);
            this.tbName.TabIndex = 15;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(86, 88);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(151, 20);
            this.tbPhone.TabIndex = 16;
            // 
            // dtpOrders
            // 
            this.dtpOrders.CustomFormat = "dd.MM.yyyy";
            this.dtpOrders.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrders.Location = new System.Drawing.Point(83, 187);
            this.dtpOrders.Name = "dtpOrders";
            this.dtpOrders.Size = new System.Drawing.Size(151, 20);
            this.dtpOrders.TabIndex = 17;
            // 
            // dgvManageOrders
            // 
            this.dgvManageOrders.AllowUserToAddRows = false;
            this.dgvManageOrders.AllowUserToDeleteRows = false;
            this.dgvManageOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvManageOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageOrders.Location = new System.Drawing.Point(299, 60);
            this.dgvManageOrders.Name = "dgvManageOrders";
            this.dgvManageOrders.ReadOnly = true;
            this.dgvManageOrders.RowHeadersVisible = false;
            this.dgvManageOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvManageOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageOrders.Size = new System.Drawing.Size(410, 236);
            this.dgvManageOrders.TabIndex = 19;
            this.dgvManageOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageOrders_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(634, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "ยกเลิก";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(553, 318);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "ตกลง";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(504, 31);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(124, 20);
            this.tbSearch.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(634, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookName.Location = new System.Drawing.Point(6, 124);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(73, 19);
            this.labelBookName.TabIndex = 24;
            this.labelBookName.Text = "ชื่อหนังสือ :";
            // 
            // lbBookName
            // 
            this.lbBookName.Location = new System.Drawing.Point(86, 127);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(151, 20);
            this.lbBookName.TabIndex = 25;
            // 
            // dtpSdate
            // 
            this.dtpSdate.CustomFormat = "dd.MM.yyyy";
            this.dtpSdate.Enabled = false;
            this.dtpSdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSdate.Location = new System.Drawing.Point(83, 158);
            this.dtpSdate.Name = "dtpSdate";
            this.dtpSdate.Size = new System.Drawing.Size(151, 20);
            this.dtpSdate.TabIndex = 26;
            // 
            // FormManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManageOrders";
            this.Text = "รายการยืม";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManageOrders_FormClosed);
            this.Load += new System.EventHandler(this.FormManageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSdate;
        private System.Windows.Forms.DateTimePicker dtpOrders;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvManageOrders;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.DateTimePicker dtpSdate;
    }
}