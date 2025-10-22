using Laboratorio6.Datos;
using Laboratorio6.Entidades;
using Laboratorio6.Logica;
using System;
using System.Collections;
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
    public partial class ConsultaLibros : Form
    {
        private LogicaLibros logicaLibros;
        public ConsultaLibros()
        {
            InitializeComponent();
            logicaLibros = new LogicaLibros();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            cbGenero2.ContextMenu = new ContextMenu();
            cbGenero2.DropDownStyle = ComboBoxStyle.DropDownList;
        }
       

        private void ConfigurarDataGridView()
        {
            // Modo de selección
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.MultiSelect = false;

            // Deshabilitar agregar filas
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = true;
            dgvInventario.ReadOnly = true;

            // Ajustar columnas
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
            //obtener todos
        {
            try
            {

                List<Libros> lista = logicaLibros.ObtenerTodos();


                dgvInventario.DataSource = null;
                dgvInventario.DataSource = lista;
                dgvInventario.SelectionMode = DataGridViewSelectionMode.CellSelect;

                //dgvInventario.Columns["CantidadDisponible"].ReadOnly = false;


                //FormatearColumnas();


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
                        $"Se encontraron {lista.Count} libro(s).",
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

        private void btnConsultar_Click(object sender, EventArgs e)
            //Busqueda por genero
        {
            try
            {
                // Validar selección
                if (cbGenero2.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Debe seleccionar un genero.",
                        "Campo requerido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    cbGenero2.Focus();
                    return;
                }

                string genero = cbGenero2.SelectedItem.ToString();

                // Consultar empleados
                List<Libros> libros = logicaLibros.ObtenerPorGenero(genero);

                // Mostrar en DataGridView
                dgvInventario.DataSource = null;
                dgvInventario.DataSource = libros;


                if (libros.Count == 0)
                {
                    MessageBox.Show(
                        $"No hay libros de tipo {genero}.",
                        "Sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        $"Se encontraron {libros.Count} libro(s).",
                        "Consulta exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    $"Error al consultar libros:\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al consultar libros:\n\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvInventario.SelectedRows[0];

                string titulo = filaSeleccionada.Cells["Titulo"].Value.ToString();
                string autor = filaSeleccionada.Cells["Autor"].Value.ToString();

                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de eliminar el libro?\n\n" +
                    $"Título: {titulo}\n" +
                    $"Autor: {autor}",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Ahora retorna booleano
                        bool eliminado = logicaLibros.EliminarLibroPorTitulo(titulo);

                        if (eliminado)
                        {
                            // Actualizar el DataGridView
                            List<Libros> listaActualizada = logicaLibros.ObtenerTodos();
                            dgvInventario.DataSource = null;
                            dgvInventario.DataSource = listaActualizada;

                            MessageBox.Show("Libro eliminado correctamente",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el libro para eliminar",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro de la lista");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EdicionLibro edicionLibro = new EdicionLibro();
            edicionLibro.Show();
            this.Hide();
        }
    }
}
