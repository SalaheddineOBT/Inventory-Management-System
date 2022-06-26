
namespace WindowsFormsApp1.GestionMaintenance.Articles
{
    partial class DétailsTransfert
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
            this.gridTransfert = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblType = new System.Windows.Forms.Label();
            this.benlbl = new System.Windows.Forms.Label();
            this.Originelbl = new System.Windows.Forms.Label();
            this.DateTlbl = new System.Windows.Forms.Label();
            this.CodeTrans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfert)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTransfert
            // 
            this.gridTransfert.AllowUserToAddRows = false;
            this.gridTransfert.AllowUserToDeleteRows = false;
            this.gridTransfert.BackgroundColor = System.Drawing.Color.White;
            this.gridTransfert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransfert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.gridTransfert.Location = new System.Drawing.Point(3, 201);
            this.gridTransfert.Name = "gridTransfert";
            this.gridTransfert.ReadOnly = true;
            this.gridTransfert.RowHeadersVisible = false;
            this.gridTransfert.Size = new System.Drawing.Size(1019, 343);
            this.gridTransfert.TabIndex = 83;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° Ligne";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Code Article";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Designation";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 350;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "QTE Neuf";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "QTE Remploi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Prix Unitair";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Valeur Transfert";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(372, 33);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 25);
            this.lblType.TabIndex = 81;
            this.lblType.Text = "Type";
            // 
            // benlbl
            // 
            this.benlbl.AutoSize = true;
            this.benlbl.Location = new System.Drawing.Point(676, 133);
            this.benlbl.Name = "benlbl";
            this.benlbl.Size = new System.Drawing.Size(205, 25);
            this.benlbl.TabIndex = 77;
            this.benlbl.Text = "Point Benificiaire :";
            // 
            // Originelbl
            // 
            this.Originelbl.AutoSize = true;
            this.Originelbl.Location = new System.Drawing.Point(122, 133);
            this.Originelbl.Name = "Originelbl";
            this.Originelbl.Size = new System.Drawing.Size(180, 25);
            this.Originelbl.TabIndex = 78;
            this.Originelbl.Text = "Point D\'origine :";
            // 
            // DateTlbl
            // 
            this.DateTlbl.AutoSize = true;
            this.DateTlbl.Location = new System.Drawing.Point(676, 87);
            this.DateTlbl.Name = "DateTlbl";
            this.DateTlbl.Size = new System.Drawing.Size(184, 25);
            this.DateTlbl.TabIndex = 79;
            this.DateTlbl.Text = "Date Transfert : ";
            // 
            // CodeTrans
            // 
            this.CodeTrans.AutoSize = true;
            this.CodeTrans.Location = new System.Drawing.Point(122, 87);
            this.CodeTrans.Name = "CodeTrans";
            this.CodeTrans.Size = new System.Drawing.Size(190, 25);
            this.CodeTrans.TabIndex = 80;
            this.CodeTrans.Text = "Code Transfert : ";
            // 
            // DétailsTransfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 568);
            this.Controls.Add(this.gridTransfert);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.benlbl);
            this.Controls.Add(this.Originelbl);
            this.Controls.Add(this.DateTlbl);
            this.Controls.Add(this.CodeTrans);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "DétailsTransfert";
            this.Text = "DétailsTransfert";
            ((System.ComponentModel.ISupportInitialize)(this.gridTransfert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTransfert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label benlbl;
        private System.Windows.Forms.Label Originelbl;
        private System.Windows.Forms.Label DateTlbl;
        private System.Windows.Forms.Label CodeTrans;
    }
}