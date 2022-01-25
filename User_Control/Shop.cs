using controlador;
using modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vista.User_Control
{
    public partial class shopControl : UserControl
    {
        private Controlador objetoC = new Controlador();
        public shopControl()
        {
            InitializeComponent();
        }
        public User userValue { get; set; }
        //Function when the controller changes visibility
        private void shopControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                try
                {
                    DataTable dt = objetoC.getGames();
                    dataGridView1.DataSource = dt;
                }
                catch(Exception exe)
                {
                    Console.Write(exe);
                }
            }
        }
        //Function to refresh the dataTable
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            DataTable dtChange = objetoC.getGamesChange(txtName.Text);
            dataGridView1.DataSource = dtChange;
        }
        //Function to add a game to an user  
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                User u = objetoC.getUser(userValue.username);
                float price = float.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                int game = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if(u.money >= price)  //check if we have money
                {
                    UG ug = objetoC.gotGame(u.idusers, game);
                    if(ug == null)  //if null it means it does not have it
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you wanna buy the game?", "Buy game", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes) //buy game if we click it
                        {
                            objetoC.buyGame(u.idusers, game);
                            MessageBox.Show("Game bought");
                            objetoC.removeMoney(u.username, price);
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Game already bought");
                    }
                }
                else
                {
                    MessageBox.Show("Not enough money");
                }
            }
            else
            {
                MessageBox.Show("Select a game");
            }
        }
    }
}
