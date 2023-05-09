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
    public partial class FrmLanding : Form
    {
        public FrmLanding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmListaAutomoviles frm = new FrmListaAutomoviles();
            frm.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegristo frm = new FrmRegristo();
            frm.Show();
            
            
        }
    }
}
