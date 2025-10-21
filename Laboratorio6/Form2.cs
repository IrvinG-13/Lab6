using Laboratorio6.Datos;
using Laboratorio6.Logica;
using Laboratorio6.Entidades;
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
    public partial class Form2 : Form
    {
        private LogicaLibros logicaLibros;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void FormatearColumnas()
        {
            if (dgvInventario.Columns.Contains("Salario"))
            {
                dgvInventario.Columns["Salario"].DefaultCellStyle.Format = "C2";
                dgvInventario.Columns["Salario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvInventario.Columns.Contains("Nombre"))
            {
                dgvInventario.Columns["Nombre"].Width = 200;
            }

            if (dgvInventario.Columns.Contains("Departamento"))
            {
                dgvInventario.Columns["Departamento"].Width = 150;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
            //obtener todos
        {
            try
            {

                List<Libros> lista = logicaLibros.ObtenerTodos();


                dgvInventario.DataSource = null;
                dgvInventario.DataSource = lista;

                FormatearColumnas();


                if (lista.Count == 0)
                {
                    MessageBox.Show(
                        "No hay empleados registrados en la base de datos.",
                        "Sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        $"Se encontraron {lista.Count} empleado(s).",
                        "Consulta exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al consultar empleados:\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }   
        }
    }
}
