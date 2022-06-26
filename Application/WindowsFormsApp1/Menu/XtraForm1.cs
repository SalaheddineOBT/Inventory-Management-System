using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Menu
{
    public partial class Menu : DevExpress.XtraEditors.XtraForm
    {
        public Menu()
        {
            InitializeComponent();
        }
        private Form A = null;
        public void OpenForm(Form f)
        {
            if (A != null) A.Close();
            A = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            Content.Controls.Add(f);
            Content.Tag = f;
            f.BringToFront();
            f.Show();
        }
        
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Manimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            OpenForm(new GestionCommande.CreationCommand());
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}