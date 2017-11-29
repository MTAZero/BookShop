namespace BookShop.GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barTheLoai = new DevExpress.XtraBars.BarButtonItem();
            this.barNhaXuatBan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barSach = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barNhapHang = new DevExpress.XtraBars.BarButtonItem();
            this.barBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barTimKiemSach = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.ribbonControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 690);
            this.panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 140);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1308, 548);
            this.panelMain.TabIndex = 1;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barNhanVien,
            this.barTheLoai,
            this.barNhaXuatBan,
            this.barButtonItem4,
            this.barSach,
            this.barButtonItem6,
            this.barNhapHang,
            this.barBanHang,
            this.barButtonItem9,
            this.barTimKiemSach,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barButtonItem14});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1308, 140);
            // 
            // barNhanVien
            // 
            this.barNhanVien.Caption = "Nhân viên";
            this.barNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("barNhanVien.Glyph")));
            this.barNhanVien.Id = 1;
            this.barNhanVien.Name = "barNhanVien";
            this.barNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNhanVien_ItemClick);
            // 
            // barTheLoai
            // 
            this.barTheLoai.Caption = "Thể loại";
            this.barTheLoai.Glyph = ((System.Drawing.Image)(resources.GetObject("barTheLoai.Glyph")));
            this.barTheLoai.Id = 2;
            this.barTheLoai.Name = "barTheLoai";
            this.barTheLoai.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barTheLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barTheLoai_ItemClick);
            // 
            // barNhaXuatBan
            // 
            this.barNhaXuatBan.Caption = "Nhà xuất bản";
            this.barNhaXuatBan.Glyph = ((System.Drawing.Image)(resources.GetObject("barNhaXuatBan.Glyph")));
            this.barNhaXuatBan.Id = 3;
            this.barNhaXuatBan.Name = "barNhaXuatBan";
            this.barNhaXuatBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barNhaXuatBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNhaXuatBan_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Tác giả";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barSach
            // 
            this.barSach.Caption = "Sách";
            this.barSach.Glyph = ((System.Drawing.Image)(resources.GetObject("barSach.Glyph")));
            this.barSach.Id = 5;
            this.barSach.Name = "barSach";
            this.barSach.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSach_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Văn phòng phẩm";
            this.barButtonItem6.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.Glyph")));
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barNhapHang
            // 
            this.barNhapHang.Caption = "Nhập hàng";
            this.barNhapHang.Glyph = ((System.Drawing.Image)(resources.GetObject("barNhapHang.Glyph")));
            this.barNhapHang.Id = 7;
            this.barNhapHang.Name = "barNhapHang";
            this.barNhapHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barNhapHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNhapHang_ItemClick);
            // 
            // barBanHang
            // 
            this.barBanHang.Caption = "Bán hàng";
            this.barBanHang.Glyph = ((System.Drawing.Image)(resources.GetObject("barBanHang.Glyph")));
            this.barBanHang.Id = 8;
            this.barBanHang.Name = "barBanHang";
            this.barBanHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBanHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBanHang_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Thống kê doanh thu";
            this.barButtonItem9.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.Glyph")));
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barTimKiemSach
            // 
            this.barTimKiemSach.Caption = "Tìm kiếm sách";
            this.barTimKiemSach.Glyph = ((System.Drawing.Image)(resources.GetObject("barTimKiemSach.Glyph")));
            this.barTimKiemSach.Id = 10;
            this.barTimKiemSach.Name = "barTimKiemSach";
            this.barTimKiemSach.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barTimKiemSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barTimKiemSach_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Tìm kiếm nhà xuất bản";
            this.barButtonItem11.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.Glyph")));
            this.barButtonItem11.Id = 11;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Tìm kiếm tác giả";
            this.barButtonItem12.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.Glyph")));
            this.barButtonItem12.Id = 12;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Tìm kiếm thể";
            this.barButtonItem13.Id = 13;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Thống kê bán hàng";
            this.barButtonItem14.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.Glyph")));
            this.barButtonItem14.Id = 14;
            this.barButtonItem14.Name = "barButtonItem14";
            this.barButtonItem14.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nhân viên";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barNhapHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBanHang);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Nhập xuất hàng";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem14);
            this.ribbonPageGroup4.ItemLinks.Add(this.barTimKiemSach);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Thống kê - Tìm kiếm";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản trị";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.barTheLoai);
            this.ribbonPageGroup2.ItemLinks.Add(this.barNhaXuatBan);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barSach);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Sản phẩm";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 740);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barTheLoai;
        private DevExpress.XtraBars.BarButtonItem barNhaXuatBan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barSach;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barNhapHang;
        private DevExpress.XtraBars.BarButtonItem barBanHang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barTimKiemSach;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}