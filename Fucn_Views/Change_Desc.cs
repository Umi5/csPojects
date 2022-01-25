using controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vista.Fucn_Views
{
    public partial class Change_Desc : Form
    {
        private Controlador objetoC = new Controlador();
        public string username { get; set; }
        public Change_Desc()
        {
            InitializeComponent();
        }

        private void Change_Desc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            int lettes_left = 200 - txtDesc.Text.Length;
            labChar.Text = lettes_left.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(txtDesc.Text.Length > 200)
            {
                MessageBox.Show("Too much characters");
            }
            else
            {
                objetoC.changeDesc(username, txtDesc.Text);
                MessageBox.Show("Description changed");
                this.Close();
            }
        }
    }
}
