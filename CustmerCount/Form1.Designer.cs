namespace CustmerCount
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Mastermain = new System.Windows.Forms.DataGridView();
            this.detail = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvTotalMaster = new System.Windows.Forms.DataGridView();
            this.dgvTotalDetail = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mastermain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 707);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1103, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "客戶數統計";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1103, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "訂單金額總計";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Mastermain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.detail);
            this.splitContainer1.Size = new System.Drawing.Size(1097, 669);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 1;
            // 
            // Mastermain
            // 
            this.Mastermain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mastermain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mastermain.Location = new System.Drawing.Point(0, 0);
            this.Mastermain.Name = "Mastermain";
            this.Mastermain.RowHeadersWidth = 62;
            this.Mastermain.RowTemplate.Height = 31;
            this.Mastermain.Size = new System.Drawing.Size(492, 669);
            this.Mastermain.TabIndex = 0;
            this.Mastermain.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Mastermain_RowEnter);
            // 
            // detail
            // 
            this.detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detail.Location = new System.Drawing.Point(0, 0);
            this.detail.Name = "detail";
            this.detail.RowHeadersWidth = 62;
            this.detail.RowTemplate.Height = 31;
            this.detail.Size = new System.Drawing.Size(601, 669);
            this.detail.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvTotalMaster);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvTotalDetail);
            this.splitContainer2.Size = new System.Drawing.Size(1097, 669);
            this.splitContainer2.SplitterDistance = 307;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvTotalMaster
            // 
            this.dgvTotalMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTotalMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvTotalMaster.Name = "dgvTotalMaster";
            this.dgvTotalMaster.RowHeadersWidth = 62;
            this.dgvTotalMaster.RowTemplate.Height = 31;
            this.dgvTotalMaster.Size = new System.Drawing.Size(1097, 307);
            this.dgvTotalMaster.TabIndex = 0;
            this.dgvTotalMaster.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTotalMaster_RowEnter);
            // 
            // dgvTotalDetail
            // 
            this.dgvTotalDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTotalDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvTotalDetail.Name = "dgvTotalDetail";
            this.dgvTotalDetail.RowHeadersWidth = 62;
            this.dgvTotalDetail.RowTemplate.Height = 31;
            this.dgvTotalDetail.Size = new System.Drawing.Size(1097, 358);
            this.dgvTotalDetail.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 707);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Groupbr練習";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Mastermain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Mastermain;
        private System.Windows.Forms.DataGridView detail;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvTotalMaster;
        private System.Windows.Forms.DataGridView dgvTotalDetail;
    }
}

