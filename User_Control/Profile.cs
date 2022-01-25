using controlador;
using modelo.Entidades;
using System;
using System.Windows.Forms;
using vista.Fucn_Views;

namespace vista.User_Control
{
    public partial class profileControl : UserControl
    {
        private Controlador objetoC = new Controlador();

        public User userValue { get; set; }
        public profileControl()
        {
            InitializeComponent();
        }
        private void profileControl_VisibleChanged(object sender, EventArgs e)
        {
            //If the controller is visible, we refesh the users data
            if (this.Visible)
            {
                try
                {
                    User u = objetoC.getUser(userValue.username);
                    if (u != null)
                    {
                        userValue.username = u.username;
                        labUser.Text = u.username;
                        labMail.Text = u.email;
                        labDesc.Text = u.description;
                        labMoney.Text = u.money.ToString();
                    }
                }
                catch (NullReferenceException nre)
                {
                    Console.WriteLine(nre.ToString());
                }
            }
        }
        //Button to go to the changeDesc form
        private void butChange_Click(object sender, EventArgs e)
        {
            Change_Desc cd = new Change_Desc();
            cd.username = userValue.username;
            cd.ShowDialog();
            if(cd.DialogResult == DialogResult.OK)
            {
                User u = objetoC.getUser(userValue.username);
                userValue.username = u.username;
                labDesc.Text = u.description;
            }
        }
        //Button to go to the butAdd money
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Money am = new Add_Money();
            am.username = userValue.username;
            am.ShowDialog();
            if (am.DialogResult == DialogResult.OK)
            {
                User u = objetoC.getUser(userValue.username);
                userValue.username = u.username;
                labMoney.Text = u.money.ToString();
            }
        }
    }
}
