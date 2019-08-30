using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Valenzuela
{
    class Persona
    {
        private string Nombre;
        private string Apellido;
        private string RazonSocial;
        private string Direccion;
        private int Telefono;
        public int PerGS { get; set; }

        public Compartimiento Compartimiento
        {
            get => default(Compartimiento);
            set
            {
            }
        }
    }
}
