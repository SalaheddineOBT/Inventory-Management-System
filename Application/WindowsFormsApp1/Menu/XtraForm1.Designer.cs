
namespace WindowsFormsApp1.Menu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Close = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.DragePanelBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Panel();
            this.xuiFlatTab1 = new XanderUI.XUIFlatTab();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement22 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement20 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement18 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement19 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement16 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement17 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement14 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement15 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement21 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement23 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            this.DragePanelBar.SuspendLayout();
            this.Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.Image = global::WindowsFormsApp1.Properties.Resources.close_32;
            this.Close.Location = new System.Drawing.Point(986, 0);
            this.Close.Name = "Close";
            this.Close.Padding = new System.Windows.Forms.Padding(5);
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize.Image = global::WindowsFormsApp1.Properties.Resources.minimize;
            this.Minimize.Location = new System.Drawing.Point(954, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Padding = new System.Windows.Forms.Padding(7);
            this.Minimize.Size = new System.Drawing.Size(32, 32);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 1;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Manimize_Click);
            // 
            // DragePanelBar
            // 
            this.DragePanelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(146)))));
            this.DragePanelBar.Controls.Add(this.label1);
            this.DragePanelBar.Controls.Add(this.Minimize);
            this.DragePanelBar.Controls.Add(this.Close);
            this.DragePanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragePanelBar.Location = new System.Drawing.Point(274, 0);
            this.DragePanelBar.Name = "DragePanelBar";
            this.DragePanelBar.Size = new System.Drawing.Size(1018, 32);
            this.DragePanelBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // Content
            // 
            this.Content.Controls.Add(this.xuiFlatTab1);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(274, 32);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1018, 568);
            this.Content.TabIndex = 5;
            // 
            // xuiFlatTab1
            // 
            this.xuiFlatTab1.ActiveHeaderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.xuiFlatTab1.InActiveHeaderColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatTab1.InActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.ItemSize = new System.Drawing.Size(240, 16);
            this.xuiFlatTab1.Location = new System.Drawing.Point(174, 362);
            this.xuiFlatTab1.Name = "xuiFlatTab1";
            this.xuiFlatTab1.PageColor = System.Drawing.Color.White;
            this.xuiFlatTab1.SelectedIndex = 0;
            this.xuiFlatTab1.ShowBorder = true;
            this.xuiFlatTab1.Size = new System.Drawing.Size(200, 100);
            this.xuiFlatTab1.TabIndex = 0;
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.accordionControlElement7.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement7.Expanded = true;
            this.accordionControlElement7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement7.ImageOptions.Image")));
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement7.Text = "DICONNEXION";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement22,
            this.accordionControlElement20});
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement6.ImageOptions.Image")));
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "GESTION MAGASIN";
            // 
            // accordionControlElement22
            // 
            this.accordionControlElement22.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement22.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement22.Name = "accordionControlElement22";
            this.accordionControlElement22.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement22.Text = "Mise à Jour";
            // 
            // accordionControlElement20
            // 
            this.accordionControlElement20.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement20.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement20.Name = "accordionControlElement20";
            this.accordionControlElement20.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement20.Text = "Statut de Stock";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement18,
            this.accordionControlElement19});
            this.accordionControlElement5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement5.ImageOptions.SvgImage")));
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "TRANSFERE";
            // 
            // accordionControlElement18
            // 
            this.accordionControlElement18.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement18.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement18.Name = "accordionControlElement18";
            this.accordionControlElement18.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement18.Text = "Faire Transfére";
            // 
            // accordionControlElement19
            // 
            this.accordionControlElement19.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement19.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement19.Name = "accordionControlElement19";
            this.accordionControlElement19.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement19.Text = "Consulter";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement16,
            this.accordionControlElement17});
            this.accordionControlElement4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement4.ImageOptions.SvgImage")));
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "RECEPTION";
            // 
            // accordionControlElement16
            // 
            this.accordionControlElement16.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement16.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement16.Name = "accordionControlElement16";
            this.accordionControlElement16.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement16.Text = "Réception d\'une Commande";
            // 
            // accordionControlElement17
            // 
            this.accordionControlElement17.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement17.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement17.Name = "accordionControlElement17";
            this.accordionControlElement17.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement17.Text = "Liste des Réception";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement14,
            this.accordionControlElement15});
            this.accordionControlElement3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement3.ImageOptions.SvgImage")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "MOUVEMENT";
            // 
            // accordionControlElement14
            // 
            this.accordionControlElement14.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement14.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement14.Name = "accordionControlElement14";
            this.accordionControlElement14.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement14.Text = "Les Entrées";
            // 
            // accordionControlElement15
            // 
            this.accordionControlElement15.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement15.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement15.Name = "accordionControlElement15";
            this.accordionControlElement15.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement15.Text = "Les Sorties";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement10,
            this.accordionControlElement11,
            this.accordionControlElement12,
            this.accordionControlElement13,
            this.accordionControlElement21});
            this.accordionControlElement2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement2.ImageOptions.SvgImage")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "MANTENANCE";
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement10.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = "Fournisseures";
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement11.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement11.Text = "Articles";
            // 
            // accordionControlElement12
            // 
            this.accordionControlElement12.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement12.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement12.Name = "accordionControlElement12";
            this.accordionControlElement12.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement12.Text = "Catégories";
            // 
            // accordionControlElement13
            // 
            this.accordionControlElement13.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement13.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement13.Name = "accordionControlElement13";
            this.accordionControlElement13.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement13.Text = "Points de Consommation";
            // 
            // accordionControlElement21
            // 
            this.accordionControlElement21.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.accordionControlElement21.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement21.Name = "accordionControlElement21";
            this.accordionControlElement21.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement21.Text = "Établissements";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement8,
            this.accordionControlElement9});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement1.ImageOptions.SvgImage")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "GESTION COMMANDE";
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.accordionControlElement8.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement8.Text = "Crée Commande";
            this.accordionControlElement8.Click += new System.EventHandler(this.accordionControlElement8_Click);
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Appearance.Default.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.accordionControlElement9.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement9.Text = "Mise à Jour";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement4,
            this.accordionControlElement5,
            this.accordionControlElement3,
            this.accordionControlElement23,
            this.accordionControlElement6,
            this.accordionControlElement7});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(274, 600);
            this.accordionControl1.TabIndex = 3;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement23
            // 
            this.accordionControlElement23.Expanded = true;
            this.accordionControlElement23.ImageOptions.Image = global::WindowsFormsApp1.Properties.Resources.scan_32;
            this.accordionControlElement23.Name = "accordionControlElement23";
            this.accordionControlElement23.Text = "INVENTAIRE";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.DragePanelBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 600);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.DragePanelBar);
            this.Controls.Add(this.accordionControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            this.DragePanelBar.ResumeLayout(false);
            this.DragePanelBar.PerformLayout();
            this.Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Panel DragePanelBar;
        private System.Windows.Forms.Panel Content;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement18;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement19;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement16;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement17;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement14;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement15;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement12;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement13;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement20;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement21;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement23;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement22;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIFlatTab xuiFlatTab1;
    }
}