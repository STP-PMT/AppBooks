
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabAll.SuspendLayout();
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
            this.dgvOrders.Size = new System.Drawing.Size(546, 297);
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
            this.tabControl1.Size = new System.Drawing.Size(560, 329);
            this.tabControl1.TabIndex = 2;
            // 
            // tabAll
            // 
            this.tabAll.Controls.Add(this.dgvOrders);
            this.tabAll.Font = new System.Drawing.Font("Prompt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAll.Location = new System.Drawing.Point(4, 22);
            this.tabAll.Name = "tabAll";
            this.tabAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabAll.Size = new System.Drawing.Size(552, 303);
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
            this.btnSearch.Location = new System.Drawing.Point(511, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 20);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "ค้นหา";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panelDetailOrder
            // 
            this.panelDetailOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetailOrder.Location = new System.Drawing.Point(584, 192);
            this.panelDetailOrder.Name = "panelDetailOrder";
            this.panelDetailOrder.Size = new System.Drawing.Size(227, 300);
            this.panelDetailOrder.TabIndex = 5;
            // 
            // labelTitleOrders
            // 
            this.labelTitleOrders.Font = new System.Drawing.Font("Prompt", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(254)))));
            this.labelTitleOrders.Location = new System.Drawing.Point(12, 26);
            this.labelTitleOrders.Name = "labelTitleOrders";
            this.labelTitleOrders.Size = new System.Drawing.Size(140, 45);
            this.labelTitleOrders.TabIndex = 6;
            this.labelTitleOrders.Text = "รายการยืม";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 511);
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
    }
}