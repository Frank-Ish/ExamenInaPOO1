using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Entities;

namespace PresentationLayer
{
    public partial class FrmRegristo : Form
    {
        BAutomovil _blAuto = new BAutomovil();
        BTipoVehiculo _blTipo = new BTipoVehiculo();
        BMarca _blMarca = new BMarca();
        BColor _blColor = new BColor();
        public FrmRegristo()
        {
            InitializeComponent();
        }

        private void lbVin_Click(object sender, EventArgs e)
        {

        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegristo_Load(object sender, EventArgs e)
        {
            LoadComboBoxMarca();
            LoadComboBoxTipo();
            LoadComboBoxColor();
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxTipo()
        {
            // Llamar al método obtenerTodos de la capa BusinessLayer para obtener los datos
            var data = _blTipo.obtenerTodos();
                cbxTipo.DataSource = data;
                cbxTipo.ValueMember = "id";
                cbxTipo.DisplayMember = "tipo";
                 
        }

        private void LoadComboBoxMarca()
        {
            // Llamar al método obtenerTodos de la capa BusinessLayer para obtener los datos
            var data = _blMarca.obtenerTodos();
            cbxMarca.DataSource = data;
            cbxMarca.ValueMember = "id";
            cbxMarca.DisplayMember = "marca";

        }

        private void LoadComboBoxColor()
        {
            // Llamar al método obtenerTodos de la capa BusinessLayer para obtener los datos
            var data = _blColor.obtenerTodos();
            cbxColor.DataSource = data;
            cbxColor.ValueMember = "id";
            cbxColor.DisplayMember = "color";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                tbAutomovil auto = new tbAutomovil();

                auto.placa = int.Parse(txtPlaca.Text);
                auto.vin = txtVin.Text;
                auto.tipo = (int)cbxTipo.SelectedValue;
                auto.marca = (int)cbxMarca.SelectedValue;
                auto.color = (int)cbxColor.SelectedValue;



                // Llamar al método Guardar de la clase ClienteBusiness para guardar los datos
                _blAuto.guardar(auto);
                Close();
            }
            else
            {
                MessageBox.Show("No se guardo, verifique los datos.");   
            }

        }

        private bool validar()
        {

            if (txtPlaca.Text == String.Empty)
            {
                MessageBox.Show("Falta la placa.");
                return false;
            }
            else if (txtVin.Text == String.Empty)
            {
                MessageBox.Show("Falta el numero de vin.");
                return false;
            }
            else if (cbxTipo.SelectedValue == null)
            {
                MessageBox.Show("Falta el tipo.");
                return false;
            }
            else if (cbxMarca.SelectedValue == null)
            {
                MessageBox.Show("Falta la marca.");
                return false;
            }
            else if (cbxColor.SelectedValue == null)
            {
                MessageBox.Show("Falta el color.");
                return false;
            }

            //todas las validaciones estan bien
            return true;
        }
    }
}
