namespace GirisEkranı
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            btnFiyatTeklifi = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            btnBarkodOkut = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGrou = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, barButtonItem1, barButtonItem2, barButtonItem3, btnFiyatTeklifi, barButtonItem4, btnBarkodOkut, barButtonItem5, barButtonItem6, barButtonItem7, barButtonItem8, barButtonItem9, barButtonItem10 });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 13;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbon.Size = new System.Drawing.Size(1338, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Ürün Girişi";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem1.ImageOptions.Image");
            barButtonItem1.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem1.ImageOptions.LargeImage");
            barButtonItem1.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            barButtonItem1.ItemAppearance.Disabled.Options.UseFont = true;
            barButtonItem1.Name = "barButtonItem1";
            barButtonItem1.ItemClick += barButtonItem1_ItemClick;
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Satış İşlemi";
            barButtonItem2.Id = 2;
            barButtonItem2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem2.ImageOptions.Image");
            barButtonItem2.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem2.ImageOptions.LargeImage");
            barButtonItem2.Name = "barButtonItem2";
            barButtonItem2.ItemClick += barButtonItem2_ItemClick;
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Fiyat Gör";
            barButtonItem3.Id = 3;
            barButtonItem3.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem3.ImageOptions.Image");
            barButtonItem3.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem3.ImageOptions.LargeImage");
            barButtonItem3.Name = "barButtonItem3";
            barButtonItem3.ItemClick += barButtonItem3_ItemClick;
            // 
            // btnFiyatTeklifi
            // 
            btnFiyatTeklifi.Caption = "Fiyat Teklifi";
            btnFiyatTeklifi.Id = 4;
            btnFiyatTeklifi.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnFiyatTeklifi.ImageOptions.SvgImage");
            btnFiyatTeklifi.Name = "btnFiyatTeklifi";
            btnFiyatTeklifi.ItemClick += btnFiyatTeklifi_ItemClick;
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "Müşteriler";
            barButtonItem4.Id = 5;
            barButtonItem4.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem4.ImageOptions.Image");
            barButtonItem4.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem4.ImageOptions.LargeImage");
            barButtonItem4.Name = "barButtonItem4";
            barButtonItem4.ItemClick += barButtonItem4_ItemClick;
            // 
            // btnBarkodOkut
            // 
            btnBarkodOkut.Caption = "Barkod Okut";
            btnBarkodOkut.Id = 6;
            btnBarkodOkut.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnBarkodOkut.ImageOptions.Image");
            btnBarkodOkut.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("btnBarkodOkut.ImageOptions.LargeImage");
            btnBarkodOkut.Name = "btnBarkodOkut";
            btnBarkodOkut.ItemClick += btnBarkodOkut_ItemClick;
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "İade İşlemi";
            barButtonItem5.Id = 7;
            barButtonItem5.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem5.ImageOptions.Image");
            barButtonItem5.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem5.ImageOptions.LargeImage");
            barButtonItem5.Name = "barButtonItem5";
            barButtonItem5.ItemClick += barButtonItem5_ItemClick;
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "Stoklar";
            barButtonItem6.Id = 8;
            barButtonItem6.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("barButtonItem6.ImageOptions.SvgImage");
            barButtonItem6.Name = "barButtonItem6";
            barButtonItem6.ItemClick += barButtonItem6_ItemClick;
            // 
            // barButtonItem7
            // 
            barButtonItem7.Caption = "Şifre";
            barButtonItem7.Id = 9;
            barButtonItem7.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem7.ImageOptions.Image");
            barButtonItem7.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem7.ImageOptions.LargeImage");
            barButtonItem7.Name = "barButtonItem7";
            barButtonItem7.ItemClick += barButtonItem7_ItemClick;
            // 
            // barButtonItem8
            // 
            barButtonItem8.Caption = "Toptancılar";
            barButtonItem8.Id = 10;
            barButtonItem8.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem8.ImageOptions.Image");
            barButtonItem8.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem8.ImageOptions.LargeImage");
            barButtonItem8.Name = "barButtonItem8";
            barButtonItem8.ItemClick += barButtonItem8_ItemClick;
            // 
            // barButtonItem9
            // 
            barButtonItem9.Caption = "Ajanda";
            barButtonItem9.Id = 11;
            barButtonItem9.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem9.ImageOptions.Image");
            barButtonItem9.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem9.ImageOptions.LargeImage");
            barButtonItem9.Name = "barButtonItem9";
            barButtonItem9.ItemClick += barButtonItem9_ItemClick;
            // 
            // barButtonItem10
            // 
            barButtonItem10.Caption = "Ekran Klavyesi";
            barButtonItem10.Id = 12;
            barButtonItem10.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("barButtonItem10.ImageOptions.Image");
            barButtonItem10.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("barButtonItem10.ImageOptions.LargeImage");
            barButtonItem10.Name = "barButtonItem10";
            barButtonItem10.ItemClick += barButtonItem10_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, ribbonPageGroup2, ribbonPageGroup3, ribbonPageGroup4, ribbonPageGroup5, ribbonPageGrou, ribbonPageGroup6, ribbonPageGroup7, ribbonPageGroup8, ribbonPageGroup9, ribbonPageGroup10 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(barButtonItem2);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(barButtonItem3);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(btnFiyatTeklifi);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(barButtonItem4);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGrou
            // 
            ribbonPageGrou.ItemLinks.Add(btnBarkodOkut);
            ribbonPageGrou.Name = "ribbonPageGrou";
            // 
            // ribbonPageGroup6
            // 
            ribbonPageGroup6.ItemLinks.Add(barButtonItem5);
            ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            ribbonPageGroup7.ItemLinks.Add(barButtonItem6);
            ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            ribbonPageGroup8.ItemLinks.Add(barButtonItem8);
            ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            ribbonPageGroup9.ItemLinks.Add(barButtonItem9);
            ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            ribbonPageGroup10.ItemLinks.Add(barButtonItem10);
            ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new System.Drawing.Point(0, 694);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new System.Drawing.Size(1338, 30);
            // 
            // AnaSayfa
            // 
            Appearance.BackColor = System.Drawing.Color.Black;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1338, 724);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "AnaSayfa";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "AnaSayfa";
            Load += AnaSayfa_Load;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnFiyatTeklifi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnBarkodOkut;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGrou;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
    }
}