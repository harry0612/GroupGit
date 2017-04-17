namespace QuanLyBanHang
{
    partial class frmTimKiemNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemNhanVien));
            this.DGVNhanVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colMaQuayGD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingNavigatorNhanVien = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCloseItem = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.cbHoTen = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbMaNV = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorNhanVien)).BeginInit();
            this.BindingNavigatorNhanVien.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVNhanVien
            // 
            this.DGVNhanVien.AllowUserToAddRows = false;
            this.DGVNhanVien.AllowUserToResizeRows = false;
            this.DGVNhanVien.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DGVNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colNgaySinh,
            this.colMaQuayGD,
            this.colDiaChi,
            this.colDienThoai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DGVNhanVien.Location = new System.Drawing.Point(0, 268);
            this.DGVNhanVien.Name = "DGVNhanVien";
            this.DGVNhanVien.Size = new System.Drawing.Size(948, 122);
            this.DGVNhanVien.TabIndex = 11;
            // 
            // colMaNV
            // 
            this.colMaNV.DataPropertyName = "MaNV";
            this.colMaNV.HeaderText = "Mã nhân viên";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTenNV";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colHoTen.Width = 170;
            // 
            // colNgaySinh
            // 
            // 
            // 
            // 
            this.colNgaySinh.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.Format = "dd/MM/yy";
            dataGridViewCellStyle1.NullValue = null;
            this.colNgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNgaySinh.HeaderText = "Ngày Sinh";
            this.colNgaySinh.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Center;
            this.colNgaySinh.MaxDate = new System.DateTime(2012, 12, 31, 0, 0, 0, 0);
            this.colNgaySinh.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.colNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colNgaySinh.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colNgaySinh.MonthCalendar.BackgroundStyle.Class = "";
            this.colNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.colNgaySinh.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.colNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2011, 11, 1, 0, 0, 0, 0);
            this.colNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colNgaySinh.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.colNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNgaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colMaQuayGD
            // 
            this.colMaQuayGD.DataPropertyName = "MaQuayGiaoDich";
            this.colMaQuayGD.HeaderText = "Quầy giao dịch";
            this.colMaQuayGD.Name = "colMaQuayGD";
            this.colMaQuayGD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaQuayGD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaQuayGD.Width = 180;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 200;
            // 
            // colDienThoai
            // 
            this.colDienThoai.DataPropertyName = "DienThoai";
            this.colDienThoai.HeaderText = "Số điện thoại";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Width = 150;
            // 
            // BindingNavigatorNhanVien
            // 
            this.BindingNavigatorNhanVien.AddNewItem = null;
            this.BindingNavigatorNhanVien.AutoSize = false;
            this.BindingNavigatorNhanVien.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigatorNhanVien.DeleteItem = null;
            this.BindingNavigatorNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorCloseItem});
            this.BindingNavigatorNhanVien.Location = new System.Drawing.Point(0, 228);
            this.BindingNavigatorNhanVien.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigatorNhanVien.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigatorNhanVien.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigatorNhanVien.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigatorNhanVien.Name = "BindingNavigatorNhanVien";
            this.BindingNavigatorNhanVien.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigatorNhanVien.Size = new System.Drawing.Size(948, 40);
            this.BindingNavigatorNhanVien.TabIndex = 10;
            this.BindingNavigatorNhanVien.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 37);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorCloseItem
            // 
            this.bindingNavigatorCloseItem.Image = global::QuanLyBanHang.Properties.Resources.Exit;
            this.bindingNavigatorCloseItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCloseItem.Name = "bindingNavigatorCloseItem";
            this.bindingNavigatorCloseItem.Size = new System.Drawing.Size(42, 37);
            this.bindingNavigatorCloseItem.Text = "Thoát";
            this.bindingNavigatorCloseItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorCloseItem.Click += new System.EventHandler(this.bindingNavigatorCloseItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 228);
            this.panel2.TabIndex = 9;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Silver;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnSearch);
            this.groupPanel2.Controls.Add(this.cbHoTen);
            this.groupPanel2.Controls.Add(this.cbMaNV);
            this.groupPanel2.Controls.Add(this.txtTimKiem);
            this.groupPanel2.Controls.Add(this.labelX9);
            this.groupPanel2.Location = new System.Drawing.Point(3, 3);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(942, 215);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.Class = "";
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.Class = "";
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.Class = "";
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 3;
            this.groupPanel2.Text = "Tìm kiếm thông tin";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::QuanLyBanHang.Properties.Resources.Search;
            this.btnSearch.Location = new System.Drawing.Point(743, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 28);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbHoTen
            // 
            this.cbHoTen.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbHoTen.BackgroundStyle.Class = "";
            this.cbHoTen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbHoTen.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.cbHoTen.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoTen.Location = new System.Drawing.Point(246, 100);
            this.cbHoTen.Name = "cbHoTen";
            this.cbHoTen.Size = new System.Drawing.Size(173, 22);
            this.cbHoTen.TabIndex = 5;
            this.cbHoTen.Text = "Tìm theo tên nhân viên";
            // 
            // cbMaNV
            // 
            this.cbMaNV.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cbMaNV.BackgroundStyle.Class = "";
            this.cbMaNV.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbMaNV.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.cbMaNV.Checked = true;
            this.cbMaNV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMaNV.CheckValue = "Y";
            this.cbMaNV.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNV.Location = new System.Drawing.Point(246, 78);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(173, 16);
            this.cbMaNV.TabIndex = 5;
            this.cbMaNV.Text = "Tìm theo mã nhân viên";
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimKiem.Location = new System.Drawing.Point(246, 43);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(382, 20);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.WatermarkText = "Nhập thông tin cần tìm";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(3, 3);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(212, 23);
            this.labelX9.TabIndex = 4;
            this.labelX9.Text = "Nhập thông tin cần tìm";
            // 
            // frmTimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 390);
            this.Controls.Add(this.DGVNhanVien);
            this.Controls.Add(this.BindingNavigatorNhanVien);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTimKiemNhanVien";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM NHÂN VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTimKiemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorNhanVien)).EndInit();
            this.BindingNavigatorNhanVien.ResumeLayout(false);
            this.BindingNavigatorNhanVien.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DGVNhanVien;
        private System.Windows.Forms.BindingNavigator BindingNavigatorNhanVien;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCloseItem;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbHoTen;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbMaNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaQuayGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;

    }
}