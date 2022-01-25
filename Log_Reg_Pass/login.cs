using System;
using System.Windows.Forms;
using controlador;
using modelo.Entidades;
using vista;
using vista.Log_Reg_Pass;

namespace gestorJuegos
{
    public partial class login : Form
    {
        //We create a controller objet to send a recive data
        private Controlador objetoC = new Controlador();
        public login()
        {
            InitializeComponent();
        }
        //When i press log button
        private void btnLog_Click(object sender, EventArgs e)
        {
            User u = objetoC.getUser(txtUsername.Text); // i call the function to get the user by its username
            if (u != null) //if that user is not null (user exists)
            {
                if (u.password.Equals(txtPassword.Text)) //if passwords match
                {
                    //i load the main view
                    Main_view uv = new Main_view();
                    uv.userData = u;
                    this.Hide();
                    uv.ShowDialog();
                    //whait for the dialogReslt
                    if(uv.DialogResult == DialogResult.OK)
                    {
                        this.Show();
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                    }
                    else if(uv.DialogResult == DialogResult.Cancel)
                    {
                        this.Close();
                    }           
                }
                else
                {
                    //if username or password incorrect (doesnt especify which one)
                    MessageBox.Show("Username or password incorrect");
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                }
            }
            else
            {
                //same as above
                MessageBox.Show("Username or password incorrect");
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
        }
        //Function for register an user
        private void btnRegis_Click(object sender, EventArgs e)
        {
            //Load register form
            Register reg = new Register();
            this.Hide();
            reg.ShowDialog();
            //Show login form if everything went fine
            if (reg.DialogResult == DialogResult.OK)
            {
                this.Show();
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
        }
        //Function to change password
        private void btnPass_Click(object sender, EventArgs e)
        {
            //Load changepass form
            change_pass change = new change_pass();
            this.Hide();
            change.ShowDialog();
            //Show login form if everything went fine
            if (change.DialogResult == DialogResult.OK)
            {
                this.Show();
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
        }
    }
}
