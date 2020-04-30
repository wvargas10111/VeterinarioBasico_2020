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
                     
            dataGridView3.DataSource = conexion.myPets();
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
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
    }
}
