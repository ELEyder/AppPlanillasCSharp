using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace AppPlanillasCSharp.gui
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.FromArgb(156, 220, 254);
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void txtUsuario_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.FromArgb(225,225,200);
        }

        private void btn_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir del Sistema", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
