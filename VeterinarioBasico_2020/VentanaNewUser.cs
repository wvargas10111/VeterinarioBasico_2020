using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient.Authentication;

namespace VeterinarioBasico_2020
{
    public partial class VentanaNewUser : Form

    {



        Conexion conexion = new Conexion();
        public VentanaNewUser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreaUser_Click(object sender, EventArgs e)
        {
           
            string myHash = BCrypt.Net.BCrypt.HashPassword(textBoxUserName.Text, BCrypt.Net.BCrypt.GenerateSalt());
            MessageBox.Show(conexion.addUser(textBoxName.Text, textBoxLastName.Text, textBoxUserName.Text, textBoxAddress.Text, textBoxPhone.Text, textBoxDni.Text, textBoxDate.Text, textBoxPass.Text myHash));
            this.Hide();    
        }

        private void VentanaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }

    


}
