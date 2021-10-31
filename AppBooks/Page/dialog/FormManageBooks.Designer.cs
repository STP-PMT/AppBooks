namespace AppBooks.Page.dialog
{
    partial class FormManageBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageBooks));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDetailBook = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.tbNameBook = new System.Windows.Forms.TextBox();
            this.tbDetail = new System.Windows.Forms.TextBox();
            this.cbbBook = new System.Windows.Forms.ComboBox();
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            this.openFileDialogBook = new System.Windows.Forms.OpenFileDialog();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(460, 56);
            this.panelTitle.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.btnClose);
            this.panelBody.Controls.Add(this.btnOk);
            this.panelBody.Controls.Add(this.btnFile);
            this.panelBody.Controls.Add(this.pictureBoxBook);
            this.panelBody.Controls.Add(this.cbbBook);
            this.panelBody.Controls.Add(this.tbDetail);
            this.panelBody.Controls.Add(this.tbNameBook);
            this.panelBody.Controls.Add(this.labelType);
            this.panelBody.Controls.Add(this.labelDetailBook);
            this.panelBody.Controls.Add(this.labelName);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 56);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(460, 267);
            this.panelBody.TabIndex = 1;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(59, 145);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(57, 19);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "ประเภท :";
            // 
            // labelDetailBook
            // 
            this.labelDetailBook.AutoSize = true;
            this.labelDetailBook.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailBook.Location = new System.Drawing.Point(38, 78);
            this.labelDetailBook.Name = "labelDetailBook";
            this.labelDetailBook.Size = new System.Drawing.Size(78, 19);
            this.labelDetailBook.TabIndex = 7;
            this.labelDetailBook.Text = "รายละเอียด :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(43, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 19);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "ชื่อหนังสือ :";
            // 
            // tbNameBook
            // 
            this.tbNameBook.Location = new System.Drawing.Point(122, 49);
            this.tbNameBook.Name = "tbNameBook";
            this.tbNameBook.Size = new System.Drawing.Size(172, 20);
            this.tbNameBook.TabIndex = 9;
            // 
            // tbDetail
            // 
            this.tbDetail.Location = new System.Drawing.Point(122, 78);
            this.tbDetail.Multiline = true;
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Size = new System.Drawing.Size(172, 60);
            this.tbDetail.TabIndex = 10;
            // 
            // cbbBook
            // 
            this.cbbBook.FormattingEnabled = true;
            this.cbbBook.Location = new System.Drawing.Point(122, 144);
            this.cbbBook.Name = "cbbBook";
            this.cbbBook.Size = new System.Drawing.Size(172, 21);
            this.cbbBook.TabIndex = 11;
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.BackColor = System.Drawing.Color.White;
            this.pictureBoxBook.Location = new System.Drawing.Point(323, 49);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(116, 116);
            this.pictureBoxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBook.TabIndex = 12;
            this.pictureBoxBook.TabStop = false;
            // 
            // openFileDialogBook
            // 
            this.openFileDialogBook.FileName = "openFileDialog1";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(323, 171);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(116, 23);
            this.btnFile.TabIndex = 13;
            this.btnFile.Text = "เปิดไฟล์";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(323, 232);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(58, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "ยืนยัน";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Prompt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(142, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(176, 29);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "เพิ่มข้อมูลหนังสือ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(387, 232);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "ยกเลิก";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 323);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManageBooks";
            this.Text = "จัดการข้อมูลหนังสือ";
            this.panelTitle.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.ComboBox cbbBook;
        private System.Windows.Forms.TextBox tbDetail;
        private System.Windows.Forms.TextBox tbNameBook;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDetailBook;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxBook;
        private System.Windows.Forms.OpenFileDialog openFileDialogBook;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnClose;
    }
}