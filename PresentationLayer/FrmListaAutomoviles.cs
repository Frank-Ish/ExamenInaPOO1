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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer
{
     


    public partial class FrmListaAutomoviles : Form
    {
        BAutomovil _bl = new BAutomovil();
        public FrmListaAutomoviles()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstAutomoviles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmListaAutomoviles_Load(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void LoadListView()
        {
            // Llamar al método obtenerTodos de la capa BusinessLayer para obtener los datos
            var data = _bl.obtenerTodos();

            // Limpiar el control ListView
            lstAutomoviles.Items.Clear();

            // Agregar los datos al control ListView
            foreach (var item in data)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.placa.ToString();
                listViewItem.SubItems.Add(item.vin.ToString());
                listViewItem.SubItems.Add(item.marca.ToString());
                listViewItem.SubItems.Add(item.tipo.ToString());
                listViewItem.SubItems.Add(item.color.ToString());
                listViewItem.SubItems.Add(item.estado.ToString());

                lstAutomoviles.Items.Add(listViewItem);
            }
        }
    }
}
