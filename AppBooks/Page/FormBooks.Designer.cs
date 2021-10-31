
namespace AppBooks
{
    partial class FormBooks
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.labelTitleOrders = new System.Windows.Forms.Label();
            this.lbDetail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.labelDetailBook = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelDetailOrder = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.labelType = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            this.panelDetailOrder.SuspendLayout();
            this.tabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(846, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "ลบ";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(765, 143);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // labelTitleOrders
            // 
            this.labelTitleOrders.Font = new System.Drawing.Font("Prompt", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(254)))));
            this.labelTitleOrders.Location = new System.Drawing.Point(12, 24);
            this.labelTitleOrders.Name = "labelTitleOrders";
            this.labelTitleOrders.Size = new System.Drawing.Size(110, 45);
            this.labelTitleOrders.TabIndex = 15;
            this.labelTitleOrders.Text = "หนังสือ";
            // 
            // lbDetail
            // 
            this.lbDetail.BackColor = System.Drawing.Color.Gainsboro;
            this.lbDetail.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetail.Location = new System.Drawing.Point(92, 267);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(120, 52);
            this.lbDetail.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Gainsboro;
            this.lbName.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(92, 238);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(120, 19);
            this.lbName.TabIndex = 3;
            // 
            // labelDetailBook
            // 
            this.labelDetailBook.AutoSize = true;
            this.labelDetailBook.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailBook.Location = new System.Drawing.Point(8, 267);
            this.labelDetailBook.Name = "labelDetailBook";
            this.labelDetailBook.Size = new System.Drawing.Size(78, 19);
            this.labelDetailBook.TabIndex = 2;
            this.labelDetailBook.Text = "รายละเอียด :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(13, 238);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 19);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ชื่อหนังสือ :";
            // 
            // panelDetailOrder
            // 
            this.panelDetailOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetailOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDetailOrder.Controls.Add(this.lbType);
            this.panelDetailOrder.Controls.Add(this.labelType);
            this.panelDetailOrder.Controls.Add(this.lbDetail);
            this.panelDetailOrder.Controls.Add(this.lbName);
            this.panelDetailOrder.Controls.Add(this.labelDetailBook);
            this.panelDetailOrder.Controls.Add(this.labelName);
            this.panelDetailOrder.Controls.Add(this.pictureBoxBook);
            this.panelDetailOrder.Location = new System.Drawing.Point(694, 189);
            this.panelDetailOrder.Name = "panelDetailOrder";
            this.panelDetailOrder.Size = new System.Drawing.Size(227, 454);
            this.panelDetailOrder.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(867, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 25);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(684, 39);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(177, 20);
            this.tbSearch.TabIndex = 12;
            // 
            // tabAll
            // 
            this.tabAll.Controls.Add(this.dgvBooks);
            this.tabAll.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAll.Location = new System.Drawing.Point(4, 22);
            this.tabAll.Name = "tabAll";
            this.tabAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabAll.Size = new System.Drawing.Size(667, 460);
            this.tabAll.TabIndex = 0;
            this.tabAll.Text = "ทั้งหมด";
            this.tabAll.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(3, 3);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(661, 454);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBook.Location = new System.Drawing.Point(684, 143);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 18;
            this.btnAddBook.Text = "เพิ่มหนังสือ";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabAll);
            this.tabControl1.Location = new System.Drawing.Point(12, 164);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 486);
            this.tabControl1.TabIndex = 11;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(29, 334);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(57, 19);
            this.labelType.TabIndex = 5;
            this.labelType.Text = "ประเภท :";
            // 
            // lbType
            // 
            this.lbType.BackColor = System.Drawing.Color.Gainsboro;
            this.lbType.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(92, 334);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(120, 19);
            this.lbType.TabIndex = 6;
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.BackColor = System.Drawing.Color.White;
            this.pictureBoxBook.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBook.TabIndex = 0;
            this.pictureBoxBook.TabStop = false;
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 662);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelTitleOrders);
            this.Controls.Add(this.panelDetailOrder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormBooks";
            this.Text = "FormBooks";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            this.panelDetailOrder.ResumeLayout(false);
            this.panelDetailOrder.PerformLayout();
            this.tabAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelTitleOrders;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label labelDetailBook;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxBook;
        private System.Windows.Forms.Panel panelDetailOrder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label labelType;
    }
}