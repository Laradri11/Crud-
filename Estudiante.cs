using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Estudiante
    {
        internal static readonly string nombre;
        internal static readonly string carnet;
        internal static readonly string seccion;

        public int Carnet { get; set; }
        public string Nombre { get; set; }
        public int Seccion { get; set; }

        public string Correo { get; set; }

        public Estudiante() { }
        public Estudiante(int carnet, string nombre, int seccion, string correo)
        {
            this.Carnet = carnet;
            this.Nombre = nombre;
            this.Seccion = seccion;
            this.Correo = correo;


        }

        internal static object PresentarRegistro()
        {
            throw new NotImplementedException();
        }
    }
}
