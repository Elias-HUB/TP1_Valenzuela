using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1_Valenzuela
{
    public class Compartimiento
    {
        Producto Prod = new Producto();
        Medidas Med = new Medidas();
        Cliente ClientePropietario = new Cliente();
        private string Nombre;
        private float PesoQSoporta;
        public int ComGS { get; set; }
    }
}