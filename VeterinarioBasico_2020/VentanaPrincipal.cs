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
    public partial class VentanaPrincipal : Form
    {
        Conexion conexion = new Conexion();
        public VentanaPrincipal()
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
            String textPass = textBoxPass.Text;
            string myHash = BCrypt.Net.BCrypt.HashPassword(textPass, BCrypt.Net.BCrypt.GenerateSalt());

            MessageBox.Show(conexion.addUser(textBoxName.Text, textBoxLastName.Text, textBoxUserName.Text, textBoxAddress.Text, textBoxPhone.Text, textBoxDni.Text, textBoxDate.Text, textBoxPass.Text));
        }
    }

  


}
