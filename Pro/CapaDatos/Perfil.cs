using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Perfil
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        private List<Tarea> ltareas;

        public List<Tarea> Ltareas
        {
            get { return ltareas; }
            set { ltareas = value; }
        }

    }
}
