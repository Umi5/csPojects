using controlador;
using modelo.Entidades;
using System;
using System.Windows.Forms;

namespace vista.Log_Reg_Pass
{
    public partial class change_pass : Form
    {
        private Controlador objetoC = new Controlador();
        public change_pass()
        {
            InitializeComponent();
        }
        //Return DialogResult.OK when form closed
        private void change_pass_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        //Function when restore button clicked
        private void btnRes_Click(object sender, EventArgs e)
        {
            //Creates user to change
            User uSave = new User();
            if (txtPass1.Text.Equals(txtPass2.Text)) //check if both passwords are the same
            {
                uSave.username = txtUser.Text;
                uSave.password = txtPass1.Text;
                User uQuery = objetoC.getUser(uSave.username); //checks if user exits
                if (uQuery == null) //if it doesnt exists cant change password
                {
                    MessageBox.Show("Username not found");
                    txtUser.Text = "";
                    txtPass1.Text = "";
                    txtPass2.Text = "";
                }
                else //if exitrs
                {
                    if (uSave.password.Equals(uQuery.password)) //if password is the same as the saved one
                    {
                        MessageBox.Show("Cant be the same password");
                        txtUser.Text = "";
                        txtPass1.Text = "";
                        txtPass2.Text = "";
                    }
                    else //if passwords are different
                    {
                        objetoC.changePassword(uSave); //function to modify password
                        MessageBox.Show("Password modified");
                        this.DialogResult = DialogResult.OK; //return DialogResult.OK
                    }
                }
            }
            else //if passwords dont match
            {
                MessageBox.Show("Passwords dont match");
                txtUser.Text = "";
                txtPass1.Text = "";
                txtPass2.Text = "";
            }
        }
    }
}
