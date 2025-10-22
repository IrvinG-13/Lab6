using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio6
{
    public partial class EdicionLibro : Form
    {
        public EdicionLibro()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ConsultaLibros form2 = new ConsultaLibros();
            form2.Show();
            this.Close();
        }
    }
}
