
namespace AppBooks
{
    partial class FormReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvOrdersAll = new System.Windows.Forms.DataGridView();
            this.panelDetailOrder = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.lbEdate = new System.Windows.Forms.Label();
            this.lbSdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSdate = new System.Windows.Forms.Label();
            this.lbDetail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.labelDetailBook = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.ptbOrder = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersAll)).BeginInit();
            this.panelDetailOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.dgvOrdersAll);
            this.panel1.Controls.Add(this.panelDetailOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 692);
            this.panel1.TabIndex = 0;
            // 
            // dgvOrdersAll
            // 
            this.dgvOrdersAll.AllowUserToAddRows = false;
            this.dgvOrdersAll.AllowUserToDeleteRows = false;
            this.dgvOrdersAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrdersAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdersAll.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrdersAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersAll.GridColor = System.Drawing.SystemColors.Control;
            this.dgvOrdersAll.Location = new System.Drawing.Point(22, 61);
            this.dgvOrdersAll.Name = "dgvOrdersAll";
            this.dgvOrdersAll.ReadOnly = true;
            this.dgvOrdersAll.RowHeadersVisible = false;
            this.dgvOrdersAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdersAll.Size = new System.Drawing.Size(621, 619);
            this.dgvOrdersAll.TabIndex = 10;
            this.dgvOrdersAll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdersAll_CellClick);
            // 
            // panelDetailOrder
            // 
            this.panelDetailOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetailOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDetailOrder.Controls.Add(this.lbPrice);
            this.panelDetailOrder.Controls.Add(this.label1);
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
            this.panelDetailOrder.Controls.Add(this.ptbOrder);
            this.panelDetailOrder.Location = new System.Drawing.Point(662, 61);
            this.panelDetailOrder.Name = "panelDetailOrder";
            this.panelDetailOrder.Size = new System.Drawing.Size(227, 619);
            this.panelDetailOrder.TabIndex = 11;
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.lbPrice.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Red;
            this.lbPrice.Location = new System.Drawing.Point(89, 444);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(120, 19);
            this.lbPrice.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "ค่าปรับ :";
            // 
            // lbPhone
            // 
            this.lbPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.lbPhone.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(92, 412);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(120, 19);
            this.lbPhone.TabIndex = 12;
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUserName.BackColor = System.Drawing.Color.Gainsboro;
            this.lbUserName.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(92, 384);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(120, 19);
            this.lbUserName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "เบอร์โทร :";
            // 
            // labelUser
            // 
            this.labelUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(43, 384);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(41, 19);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "ผู้ยืม :";
            // 
            // lbEdate
            // 
            this.lbEdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEdate.BackColor = System.Drawing.Color.Gainsboro;
            this.lbEdate.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdate.Location = new System.Drawing.Point(92, 349);
            this.lbEdate.Name = "lbEdate";
            this.lbEdate.Size = new System.Drawing.Size(120, 19);
            this.lbEdate.TabIndex = 8;
            // 
            // lbSdate
            // 
            this.lbSdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSdate.BackColor = System.Drawing.Color.Gainsboro;
            this.lbSdate.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdate.Location = new System.Drawing.Point(92, 321);
            this.lbSdate.Name = "lbSdate";
            this.lbSdate.Size = new System.Drawing.Size(120, 19);
            this.lbSdate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "กำหนดยืน :";
            // 
            // labelSdate
            // 
            this.labelSdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSdate.AutoSize = true;
            this.labelSdate.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSdate.Location = new System.Drawing.Point(30, 321);
            this.labelSdate.Name = "labelSdate";
            this.labelSdate.Size = new System.Drawing.Size(56, 19);
            this.labelSdate.TabIndex = 5;
            this.labelSdate.Text = "วันที่ยืม :";
            // 
            // lbDetail
            // 
            this.lbDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDetail.BackColor = System.Drawing.Color.Gainsboro;
            this.lbDetail.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetail.Location = new System.Drawing.Point(92, 254);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(120, 52);
            this.lbDetail.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbName.BackColor = System.Drawing.Color.Gainsboro;
            this.lbName.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(92, 225);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(120, 19);
            this.lbName.TabIndex = 3;
            // 
            // labelDetailBook
            // 
            this.labelDetailBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDetailBook.AutoSize = true;
            this.labelDetailBook.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailBook.Location = new System.Drawing.Point(8, 254);
            this.labelDetailBook.Name = "labelDetailBook";
            this.labelDetailBook.Size = new System.Drawing.Size(78, 19);
            this.labelDetailBook.TabIndex = 2;
            this.labelDetailBook.Text = "รายละเอียด :";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Prompt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(13, 225);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(73, 19);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ชื่อหนังสือ :";
            // 
            // ptbOrder
            // 
            this.ptbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbOrder.BackColor = System.Drawing.Color.White;
            this.ptbOrder.Location = new System.Drawing.Point(12, 13);
            this.ptbOrder.Name = "ptbOrder";
            this.ptbOrder.Size = new System.Drawing.Size(200, 200);
            this.ptbOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbOrder.TabIndex = 0;
            this.ptbOrder.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Prompt", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(374, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(170, 40);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "ประวัติการยืม";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(902, 692);
            this.Controls.Add(this.panel1);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersAll)).EndInit();
            this.panelDetailOrder.ResumeLayout(false);
            this.panelDetailOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvOrdersAll;
        private System.Windows.Forms.Panel panelDetailOrder;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label lbEdate;
        private System.Windows.Forms.Label lbSdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSdate;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label labelDetailBook;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox ptbOrder;
        private System.Windows.Forms.Label labelTitle;
    }
}