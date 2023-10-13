using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigos_profesores_gestion
{
    internal class Profesor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string DireccionResidencia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NumeroIdentificacion { get; set; }

        public Profesor(string nombre, string apellido, string especialidad, string telefono, string correoElectronico, string direccionResidencia, DateTime fechaNacimiento, string numeroIdentificacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Especialidad = especialidad;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
            DireccionResidencia = direccionResidencia;
            FechaNacimiento = fechaNacimiento;
            NumeroIdentificacion = numeroIdentificacion;
        }
    }
}
