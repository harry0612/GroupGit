namespace QuanLyBanHang.Report
{
    partial class frmDSMatHang
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MatHangInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportViewerDanhSachMatHang = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.MatHangInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewerDanhSachMatHang
            // 
            this.ReportViewerDanhSachMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MatHangInfo";
            reportDataSource1.Value = this.MatHangInfoBindingSource;
            this.ReportViewerDanhSachMatHang.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerDanhSachMatHang.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.Report.rptMatHang.rdlc";
            this.ReportViewerDanhSachMatHang.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerDanhSachMatHang.Name = "ReportViewerDanhSachMatHang";
            this.ReportViewerDanhSachMatHang.Size = new System.Drawing.Size(645, 447);
            this.ReportViewerDanhSachMatHang.TabIndex = 2;
            // 
            // frmDSMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 447);
            this.Controls.Add(this.ReportViewerDanhSachMatHang);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDSMatHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH MẶT HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MatHangInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerDanhSachMatHang;
        private System.Windows.Forms.BindingSource MatHangInfoBindingSource;
    }
}