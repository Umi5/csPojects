using controlador;
using modelo.Entidades;
using System;
using System.Windows.Forms;

namespace vista
{
    public partial class Register : Form
    {
        private Controlador objetoC = new Controlador();
        public Register()
        {
            InitializeComponent();
        }
        //Return DialogResult.OK when form closed
        private void register_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        //Function when register button is clicked
        private void btnReg_Click(object sender, EventArgs e)
        {
            //Creates a new user
            User uSave = new User();
            if (txtPass1.Text.Equals(txtPass2.Text))  //check if both passwords match
            {
                uSave.username = txtUser.Text;
                uSave.password = txtPass1.Text;
                uSave.email = txtEmail.Text;
                User uQuery = objetoC.getUser(uSave.username); //Checks if user exists
                if (uQuery != null) //if user exists
                {
                    MessageBox.Show("Username already registered");
                    txtUser.Text = "";
                    txtPass1.Text = "";
                    txtPass2.Text = "";
                }
                else //if user dont exits
                {
                    objetoC.registerUser(uSave);  //function to save user in database
                    MessageBox.Show("User created");
                    this.DialogResult = DialogResult.OK;  //return DialogResult.OK

                }  
            }
            else //if paswords dont match
            {
                MessageBox.Show("Passwords dont match");
                txtUser.Text = "";
                txtPass1.Text = "";
                txtPass2.Text = "";
            }         
        }
    }
}
