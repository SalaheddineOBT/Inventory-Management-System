
namespace WindowsFormsApp1.Transferes
{
    partial class BonTransfert
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
            DevExpress.Utils.Layout.TablePanelColumn tablePanelColumn1 = new DevExpress.Utils.Layout.TablePanelColumn();
            DevExpress.Utils.Layout.TablePanelRow tablePanelRow1 = new DevExpress.Utils.Layout.TablePanelRow();
            DevExpress.Utils.Layout.TablePanelRow tablePanelRow2 = new DevExpress.Utils.Layout.TablePanelRow();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridLignTransfert = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValide = new System.Windows.Forms.Button();
            this.btnNveuArt = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtRemploi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQteNeuf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridArticles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtArticles = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.lblCodeTransfert = new System.Windows.Forms.Label();
            this.lblCodert = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLignTransfert)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tablePanel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1099, 750);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tablePanel1
            // 
            tablePanelColumn1.Style = DevExpress.Utils.Layout.TablePanelEntityStyle.Relative;
            tablePanelColumn1.Width = 30.16F;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            tablePanelColumn1});
            this.tablePanel1.Controls.Add(this.panel2);
            this.tablePanel1.Controls.Add(this.panel1);
            this.tablePanel1.Location = new System.Drawing.Point(12, 12);
            this.tablePanel1.Name = "tablePanel1";
            tablePanelRow1.Height = 337F;
            tablePanelRow1.Style = DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute;
            tablePanelRow2.Height = 26F;
            tablePanelRow2.Style = DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute;
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            tablePanelRow1,
            tablePanelRow2});
            this.tablePanel1.Size = new System.Drawing.Size(1075, 726);
            this.tablePanel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.tablePanel1.SetColumn(this.panel2, 0);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtValeur);
            this.panel2.Controls.Add(this.btnImprimer);
            this.panel2.Controls.Add(this.btnAnnuler);
            this.panel2.Controls.Add(this.btnValide);
            this.panel2.Controls.Add(this.btnNveuArt);
            this.panel2.Controls.Add(this.btnTransfer);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtMontant);
            this.panel2.Controls.Add(this.txtRemploi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtQteNeuf);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 340);
            this.panel2.Name = "panel2";
            this.tablePanel1.SetRow(this.panel2, 1);
            this.panel2.Size = new System.Drawing.Size(1069, 383);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridLignTransfert);
            this.panel3.Location = new System.Drawing.Point(3, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 151);
            this.panel3.TabIndex = 72;
            // 
            // gridLignTransfert
            // 
            this.gridLignTransfert.AllowUserToAddRows = false;
            this.gridLignTransfert.AllowUserToDeleteRows = false;
            this.gridLignTransfert.BackgroundColor = System.Drawing.Color.White;
            this.gridLignTransfert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLignTransfert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.gridLignTransfert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLignTransfert.Location = new System.Drawing.Point(0, 0);
            this.gridLignTransfert.Name = "gridLignTransfert";
            this.gridLignTransfert.ReadOnly = true;
            this.gridLignTransfert.RowHeadersVisible = false;
            this.gridLignTransfert.Size = new System.Drawing.Size(1063, 151);
            this.gridLignTransfert.TabIndex = 64;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "N° Ligne";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Article";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Désignation";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 300;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Unité Messure";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "QteNeuf";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 110;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "QteRemploi";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Prix Unitaire";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Valeur Transfert";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // txtValeur
            // 
            this.txtValeur.BackColor = System.Drawing.Color.White;
            this.txtValeur.Location = new System.Drawing.Point(871, 29);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.ReadOnly = true;
            this.txtValeur.Size = new System.Drawing.Size(175, 21);
            this.txtValeur.TabIndex = 71;
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(83)))), ((int)(((byte)(153)))));
            this.btnImprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.Location = new System.Drawing.Point(529, 318);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(161, 48);
            this.btnImprimer.TabIndex = 58;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(83)))), ((int)(((byte)(153)))));
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(313, 318);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(161, 48);
            this.btnAnnuler.TabIndex = 59;
            this.btnAnnuler.Text = "Nouveau";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnValide
            // 
            this.btnValide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(83)))), ((int)(((byte)(153)))));
            this.btnValide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValide.Enabled = false;
            this.btnValide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnValide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValide.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnValide.ForeColor = System.Drawing.Color.White;
            this.btnValide.Location = new System.Drawing.Point(102, 318);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(161, 48);
            this.btnValide.TabIndex = 60;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = false;
            // 
            // btnNveuArt
            // 
            this.btnNveuArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(83)))), ((int)(((byte)(153)))));
            this.btnNveuArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNveuArt.Enabled = false;
            this.btnNveuArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNveuArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNveuArt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNveuArt.ForeColor = System.Drawing.Color.White;
            this.btnNveuArt.Location = new System.Drawing.Point(583, 78);
            this.btnNveuArt.Name = "btnNveuArt";
            this.btnNveuArt.Size = new System.Drawing.Size(228, 43);
            this.btnNveuArt.TabIndex = 61;
            this.btnNveuArt.Text = "Nouveau Article";
            this.btnNveuArt.UseVisualStyleBackColor = false;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(83)))), ((int)(((byte)(153)))));
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.Enabled = false;
            this.btnTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(297, 78);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(228, 43);
            this.btnTransfer.TabIndex = 62;
            this.btnTransfer.Text = "Transfert";
            this.btnTransfer.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(717, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 21);
            this.label10.TabIndex = 70;
            this.label10.Text = "Valeur Transfert :";
            // 
            // txtMontant
            // 
            this.txtMontant.BackColor = System.Drawing.Color.White;
            this.txtMontant.Location = new System.Drawing.Point(871, 292);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.ReadOnly = true;
            this.txtMontant.Size = new System.Drawing.Size(186, 21);
            this.txtMontant.TabIndex = 68;
            // 
            // txtRemploi
            // 
            this.txtRemploi.Location = new System.Drawing.Point(529, 29);
            this.txtRemploi.Name = "txtRemploi";
            this.txtRemploi.Size = new System.Drawing.Size(175, 21);
            this.txtRemploi.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(784, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Montant :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(353, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 21);
            this.label9.TabIndex = 67;
            this.label9.Text = "Quantity Remploi :";
            // 
            // txtQteNeuf
            // 
            this.txtQteNeuf.Location = new System.Drawing.Point(172, 29);
            this.txtQteNeuf.Name = "txtQteNeuf";
            this.txtQteNeuf.Size = new System.Drawing.Size(175, 21);
            this.txtQteNeuf.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(25, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 21);
            this.label8.TabIndex = 64;
            this.label8.Text = "Quantity Neuf :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtA);
            this.panel1.Controls.Add(this.txtDe);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.lblCodeTransfert);
            this.panel1.Controls.Add(this.lblCodert);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 331);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(326, 21);
            this.comboBox1.TabIndex = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridArticles);
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Controls.Add(this.txtArticles);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(3, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1063, 222);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisire Les Articles Transferer :";
            // 
            // gridArticles
            // 
            this.gridArticles.AllowUserToAddRows = false;
            this.gridArticles.AllowUserToDeleteRows = false;
            this.gridArticles.BackgroundColor = System.Drawing.Color.White;
            this.gridArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gridArticles.Location = new System.Drawing.Point(6, 84);
            this.gridArticles.Name = "gridArticles";
            this.gridArticles.ReadOnly = true;
            this.gridArticles.RowHeadersVisible = false;
            this.gridArticles.Size = new System.Drawing.Size(1005, 130);
            this.gridArticles.TabIndex = 52;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 190;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Désignation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 470;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Unité Mesure";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stock Neuf";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 190;
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(83)))), ((int)(((byte)(153)))));
            this.btnRechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechercher.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRechercher.ForeColor = System.Drawing.Color.White;
            this.btnRechercher.Location = new System.Drawing.Point(607, 16);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(197, 43);
            this.btnRechercher.TabIndex = 51;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            // 
            // txtArticles
            // 
            this.txtArticles.Location = new System.Drawing.Point(330, 24);
            this.txtArticles.Name = "txtArticles";
            this.txtArticles.Size = new System.Drawing.Size(252, 21);
            this.txtArticles.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Article :";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(659, 78);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(205, 21);
            this.txtA.TabIndex = 57;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(659, 46);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(205, 21);
            this.txtDe.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "À :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "De :";
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Location = new System.Drawing.Point(462, 19);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(100, 13);
            this.Datelbl.TabIndex = 53;
            this.Datelbl.Text = "Date de Transfert :";
            // 
            // lblCodeTransfert
            // 
            this.lblCodeTransfert.AutoSize = true;
            this.lblCodeTransfert.Location = new System.Drawing.Point(253, 25);
            this.lblCodeTransfert.Name = "lblCodeTransfert";
            this.lblCodeTransfert.Size = new System.Drawing.Size(10, 13);
            this.lblCodeTransfert.TabIndex = 54;
            this.lblCodeTransfert.Text = "";
            // 
            // lblCodert
            // 
            this.lblCodert.AutoSize = true;
            this.lblCodert.Location = new System.Drawing.Point(44, 23);
            this.lblCodert.Name = "lblCodert";
            this.lblCodert.Size = new System.Drawing.Size(114, 13);
            this.lblCodert.TabIndex = 55;
            this.lblCodert.Text = "Numéro de Transfert :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Type De Transfert :";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1099, 750);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tablePanel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1079, 730);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // BonTransfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 750);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BonTransfert";
            this.Text = "BonTransfert";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLignTransfert)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gridLignTransfert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.Button btnNveuArt;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtRemploi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQteNeuf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridArticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtArticles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label lblCodeTransfert;
        private System.Windows.Forms.Label lblCodert;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}