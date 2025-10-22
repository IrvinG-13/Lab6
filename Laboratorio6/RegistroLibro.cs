using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratorio6.Entidades;
using Laboratorio6.Logica;

namespace Laboratorio6
{
    public partial class RegistroLibro : Form
    {
        public RegistroLibro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = false;
            cbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            txtAutor.TextChanged += ValidarFormulario;
            txtTitulo.TextChanged += ValidarFormulario;
            txtCantidad.TextChanged += ValidarFormulario;
            cbGenero.SelectedIndexChanged += ValidarFormulario;
            txtTitulo.ContextMenu = new ContextMenu();   
            txtAutor.ContextMenu = new ContextMenu();
            txtCantidad.ContextMenu = new ContextMenu();
        }

        private void ValidarFormulario(object sender, EventArgs e)
        {
            bool nombreAutor = !string.IsNullOrWhiteSpace(txtAutor.Text);
            bool tituloLibro = !string.IsNullOrWhiteSpace(txtTitulo.Text);
            bool cantidadDisponible = !string.IsNullOrWhiteSpace(txtCantidad.Text);
            bool generoSelecionado = cbGenero.SelectedIndex != -1;

            btnRegistrar.Enabled = nombreAutor && tituloLibro && generoSelecionado;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                

                //Crear un libro nuevo 
                Libros nuevoLibro = new Libros(
                    txtTitulo.Text.Trim(),
                    txtAutor.Text.Trim(),
                    cbGenero.SelectedItem.ToString(),
                    (int)txtCantidad.Value
                    );

                // Insertar en BD
                LogicaLibros logica = new LogicaLibros();
                logica.Registrar(nuevoLibro);

                MessageBox.Show(
                    "Libro registrado exitosamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                LimpiarCampos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al registrar libro:\n\n{ex.Message}",
                    "Error del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            void LimpiarCampos()
            {
                txtTitulo.Clear();
                txtAutor.Clear();
                cbGenero.SelectedIndex = -1;
                txtTitulo.Focus();
                btnRegistrar.Enabled = false;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaLibros form2 = new ConsultaLibros();
            this.Hide();
            form2.Show();
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten números en este campo.", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten números en este campo.", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtTitulo_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.V) || (e.Shift && e.KeyCode == Keys.Insert))
            {
                MessageBox.Show("No se admiten valores copiados");
                e.SuppressKeyPress = true;
                txtTitulo.Clear();

            }

        }

        private void txtAutor_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.V) || (e.Shift && e.KeyCode == Keys.Insert))
            {
                MessageBox.Show("No se admiten valores copiados");
                e.SuppressKeyPress = true;
                txtAutor.Clear();

            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.V) || (e.Shift && e.KeyCode == Keys.Insert))
            {
                MessageBox.Show("No se admiten valores copiados");
                e.SuppressKeyPress = true;
                txtCantidad.Value = 0;

            }
        }

        

       


    }
}
