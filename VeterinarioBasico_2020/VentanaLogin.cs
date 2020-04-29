using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace VeterinarioBasico_2020
{
    public partial class VentanaLogin : Form
    { 
        Conexion conexion = new Conexion();
    
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conexion.compruebaUsr(textBoxUsr.Text, textBoxPass.Text))
            {
                //this.Hide();
                //VentanaPrincipal v = new VentanaPrincipal();
                //v.Show();


                this.Hide();
                VentanaPrincipal v = new VentanaPrincipal();
                v.Show();
                
            }
            else
            {
               
                

                MessageBox.Show("Usuario o contraseña incorrectos");

            }
        }

        private void VentanaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
