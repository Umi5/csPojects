using controlador;
using modelo.Entidades;
using System.Windows.Forms;
using vista.Fucn_Views;

namespace vista
{
    public partial class Main_view : Form
    {
        //We show the home view when iniciated
        public Main_view()
        {
            InitializeComponent();
        }
        public User userData { get; set; } //We take the userdata
        //Send ok when form closed
        private void user_view_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        //Show home when clicked
        private void btnHome_Click(object sender, System.EventArgs e)
        {
            homeControl1.userValue = userData;
            homeControl1.Show();
            shopControl1.Hide();
            libControl1.Hide();
            profileControl1.Hide();
        }
        //Show shop when clicked
        private void btnShop_Click(object sender, System.EventArgs e)
        {
            shopControl1.userValue = userData;
            homeControl1.Hide();
            shopControl1.Show();
            libControl1.Hide();
            profileControl1.Hide();
        }
        //Show library when clicked
        private void btnLib_Click(object sender, System.EventArgs e)
        {
            libControl1.userValue = userData;
            homeControl1.Hide();
            shopControl1.Hide();
            libControl1.Show();
            profileControl1.Hide();
        }
        //Show Profile when clicked
        private void btnProfile_Click(object sender, System.EventArgs e)
        {
            profileControl1.userValue = userData;
            homeControl1.Hide();
            shopControl1.Hide();
            libControl1.Hide();
            profileControl1.Show();
        }

        private void Main_view_Load(object sender, System.EventArgs e)
        {
            homeControl1.userValue = userData;
            homeControl1.Show();
            shopControl1.Hide();
            libControl1.Hide();
            profileControl1.Hide();
        }

        private void addMoneyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Add_Money am = new Add_Money();
            am.username = userData.username;
            am.ShowDialog();
        }

        private void buyGameToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            shopControl1.userValue = userData;
            homeControl1.Hide();
            shopControl1.Show();
            libControl1.Hide();
            profileControl1.Hide();
        }

        private void sellGameToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            libControl1.userValue = userData;
            homeControl1.Hide();
            shopControl1.Hide();
            libControl1.Show();
            profileControl1.Hide();
        }

        private void changeDescriptionToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Change_Desc cd = new Change_Desc();
            cd.username = userData.username;
            cd.ShowDialog();
        }
    }
}
