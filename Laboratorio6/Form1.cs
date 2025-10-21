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
    public partial class Form1 : Form
    {
        public Form1()
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
        }

        private void ValidarFormulario(object sender, EventArgs e)
        {
            bool nombreAutor = !string.IsNullOrWhiteSpace(txtAutor.Text);
            bool tituloLibro = !string.IsNullOrWhiteSpace(txtTitulo.Text);
            bool cantidadDisponible =!string.IsNullOrWhiteSpace(txtCantidad.Text);
            bool generoSelecionado = cbGenero.SelectedIndex != -1;

            btnRegistrar.Enabled = nombreAutor && tituloLibro && generoSelecionado;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 0)
                {
                    MessageBox.Show(
                        "La cantidad debe ser un número entero válido y no negativo.\n\nEjemplo: 10",
                        "Error de formato",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    txtCantidad.Focus();
                    txtCantidad.SelectAll();
                    return;
                }

                //Crear un libro nuevo 
                Libros nuevoLibro = new Libros(
                    txtTitulo.Text.Trim(),
                    txtAutor.Text.Trim(),
                    cbGenero.SelectedItem.ToString(),
                    cantidad
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
                txtCantidad.Clear();
                cbGenero.SelectedIndex = -1;
                txtTitulo.Focus();
                btnRegistrar.Enabled = false;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en este campo.", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
