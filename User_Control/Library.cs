using controlador;
using modelo.Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace vista.User_Control
{
    public partial class libControl : UserControl
    {
        private Controlador objetoC = new Controlador();
        public libControl()
        {
            InitializeComponent();
        }
        public User userValue { get; set; }

        private void libControl_VisibleChanged(object sender, System.EventArgs e)
        {
            if (this.Visible)
            {
                try
                {
                   DataTable dt = objetoC.getUserGames(userValue.idusers);
                   dataGridView1.DataSource = dt;
                }catch(NullReferenceException nre)
                {
                    Console.WriteLine(nre);
                }
                
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int gameid = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int userid = userValue.idusers;
                float money = float.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("Are you sure you wanna sell the game?", "Sell game", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    objetoC.sellGame(userid, gameid, money, userValue.username);
                    MessageBox.Show("Game selled");
                    try
                    {
                        DataTable dt = objetoC.getUserGames(userValue.idusers);
                        dataGridView1.DataSource = dt;
                    }
                    catch (NullReferenceException nre)
                    {
                        Console.WriteLine(nre);
                    }
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //HACER QUE BUSQUE EN MI TABLA
        }
    }

}
