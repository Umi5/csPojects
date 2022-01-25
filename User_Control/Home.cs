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
    public partial class homeControl : UserControl
    {
        private Controlador objetoC = new Controlador();
        public homeControl()
        {
            InitializeComponent();
        }
        public User userValue { get; set; }

        private void homeControl_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                try
                {
                    txtTotal.Text = objetoC.getTotalUserGames(userValue.idusers).ToString();
                    txtGames.Text = objetoC.getGamesCount().ToString();
                    addUsers();
                }
                catch(NullReferenceException nro)
                {
                    Console.WriteLine(nro);
                }
            }
        }

        private void addUsers()
        {
            txtUsers.Text = "";
            List<User> listU = objetoC.getUsersList();
            for(int i = 0; i < listU.Count; i++)
            {
                if(listU[i].idusers != userValue.idusers)
                {
                    string userString = listU[i].username + Environment.NewLine;
                    txtUsers.Text += userString;
                }
            }
        }
    }
}
