using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Valenzuela
{
    class Deposito
    {
        private string Nombre;
        private string Direccion;
        private string Localidad;
        private string Telefono;
        private int CantPasillos;
        Persona Per = new Persona();
        Transporte Trans = new Transporte();
        Medidas Med = new Medidas();
        Pasillo Pas = new Pasillo();
        public int DepGS { get; set; }
    }
}
