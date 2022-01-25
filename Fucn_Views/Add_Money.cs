using controlador;
using System;
using System.Windows.Forms;

namespace vista.Fucn_Views
{
    
    public partial class Add_Money : Form
    {
        private Controlador objetoC = new Controlador();
        public string username { get; set; }
        public Add_Money()
        {
            InitializeComponent();
        }
        //Button ad 5 
        private void btn5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wanna add 5€?",
                      "Add money", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    objetoC.addMoney(username, 5);
                    MessageBox.Show("Money Added");
                    this.DialogResult = DialogResult.OK;
                    break;
                default: break;
            }
        }
        //Button add 10
        private void btn10_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wanna add 10€?",
                     "Add money", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    objetoC.addMoney(username, 10);
                    MessageBox.Show("Money Added");
                    this.DialogResult = DialogResult.OK;
                    break;
                default: break;
            }
        }
        //Button add 20
        private void btn20_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wanna add 20€?",
                     "Add money", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    objetoC.addMoney(username, 20);
                    MessageBox.Show("Money Added");
                    this.DialogResult = DialogResult.OK;
                    break;
                default: break;
            }
        }
        //Button add 50
        private void btn50_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wanna add 50€?",
                     "Add money", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    objetoC.addMoney(username, 50);
                    MessageBox.Show("Money Added");
                    this.DialogResult = DialogResult.OK;
                    break;
                default: break;
            }
        }
        //Button add 100
        private void btn100_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wanna add 100€?",
                    "Add money", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    objetoC.addMoney(username, 100);
                    MessageBox.Show("Money Added");
                    this.DialogResult = DialogResult.OK;
                    break;
                default: break;
            }
        }

        private void Add_Money_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
