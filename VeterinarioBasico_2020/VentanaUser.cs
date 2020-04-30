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
    public partial class VentanaUser : Form
    {

        Conexion conexion = new Conexion();
        DataTable pets = new DataTable();
       
        public VentanaUser()
        {
            InitializeComponent();

            dataGridView1.DataSource = conexion.myVac();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dataGridView2.DataSource = conexion.myVac();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dataGridView3.DataSource = conexion.myPets();
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dataGridView4.DataSource = conexion.myVac();
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dataGridView5.DataSource = conexion.myApps();
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView5.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dataGridView6.DataSource = conexion.myApps();
            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView6.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

      


        private void buttonAddVac_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.addVaccine(textBoxCodPetVac.Text, textBoxPetNameVac.Text, textBoxVaccine.Text));
            
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            MessageBox.Show(conexion.addAppointment(textBoxUserDniApp.Text, textBoxPetNameApp.Text, richTextBoxReason.Text));
            
        }

        private void textBoxReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            VentanaNewUser v = new VentanaNewUser();
            v.Show();
        }

        private void VentanaUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
