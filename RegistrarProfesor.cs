using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codigos_profesores_gestion
{
    public partial class RegistrarProfesor : Form
    {
        private List<Profesor> profesores = new List<Profesor>();
        private Profesor profesorSeleccionado;
        public RegistrarProfesor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeProfesores Inicio = new GestionDeProfesores();
            Inicio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonRegistrarProfesor_Click(object sender, EventArgs e)
        {
            string nombre = campoNombre.Text.Trim();
            string apellido = campoApellido.Text.Trim();
            string especialidad = campoEspecialidad.Text.Trim();
            string telefono = campoTelefono.Text.Trim();
            string correoElectronico = campoCorreoElectronico.Text.Trim();
            string direccionResidencia = campoDireccionResidencia.Text.Trim();
            DateTime fechaNacimiento = fechaNacimientoPicker.Value;
            string numeroIdentificacion = campoNumeroIdentificacion.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(especialidad) ||
                string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(correoElectronico) || string.IsNullOrEmpty(direccionResidencia) ||
                string.IsNullOrEmpty(numeroIdentificacion))
            {
                MessageBox.Show("Todos los campos son requeridos");
                return;
            }

            Profesor nuevoProfesor = new Profesor(nombre, apellido, especialidad, telefono, correoElectronico, direccionResidencia, fechaNacimiento, numeroIdentificacion);

            profesores.Add(nuevoProfesor);

            MessageBox.Show("Profesor registrado con éxito");

            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            campoNombre.Clear();
            campoApellido.Clear();
            campoEspecialidad.Clear();
            campoTelefono.Clear();
            campoCorreoElectronico.Clear();
            campoDireccionResidencia.Clear();
            campoNumeroIdentificacion.Clear();
            fechaNacimientoPicker.Value = DateTime.Today;
        }

        private void campoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoDireccionResidencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void fechaNacimientoPicker_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarProfesor_Load(object sender, EventArgs e)
        {

        }

        private void campoNumeroIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void botonEditarProfesor_Click(object sender, EventArgs e)
        {
            if (profesorSeleccionado != null)
            {

                string nuevoNombre = campoNombre.Text.Trim();
                string nuevoApellido = campoApellido.Text.Trim();
                string nuevaEspecialidad = campoEspecialidad.Text.Trim();
                string nuevoTelefono = campoTelefono.Text.Trim();
                string nuevoCorreoElectronico = campoCorreoElectronico.Text.Trim();
                string nuevaDireccionResidencia = campoDireccionResidencia.Text.Trim();
                DateTime nuevaFechaNacimiento = fechaNacimientoPicker.Value;
                string nuevoNumeroIdentificacion = campoNumeroIdentificacion.Text.Trim();

                profesorSeleccionado.Nombre = nuevoNombre;
                profesorSeleccionado.Apellido = nuevoApellido;
                profesorSeleccionado.Especialidad = nuevaEspecialidad;
                profesorSeleccionado.Telefono = nuevoTelefono;
                profesorSeleccionado.CorreoElectronico = nuevoCorreoElectronico;
                profesorSeleccionado.DireccionResidencia = nuevaDireccionResidencia;
                profesorSeleccionado.FechaNacimiento = nuevaFechaNacimiento;
                profesorSeleccionado.NumeroIdentificacion = nuevoNumeroIdentificacion;

                MessageBox.Show("Profesor actualizado con éxito");

                LimpiarFormulario();
                profesorSeleccionado = null;
            }
            else
            {
                MessageBox.Show("Selecciona un profesor para editar.");
            }
        }

        private void ListarProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaProfesores.SelectedIndex >= 0)
            {
                profesorSeleccionado = profesores[listaProfesores.SelectedIndex];

                // Llena los campos del formulario con los datos del profesor seleccionado
                campoNombre.Text = profesorSeleccionado.Nombre;
                campoApellido.Text = profesorSeleccionado.Apellido;
                campoEspecialidad.Text = profesorSeleccionado.Especialidad;
                campoTelefono.Text = profesorSeleccionado.Telefono;
                campoCorreoElectronico.Text = profesorSeleccionado.CorreoElectronico;
                campoDireccionResidencia.Text = profesorSeleccionado.DireccionResidencia;
                fechaNacimientoPicker.Value = profesorSeleccionado.FechaNacimiento;
                campoNumeroIdentificacion.Text = profesorSeleccionado.NumeroIdentificacion;
            }
        }
    }
    
}
