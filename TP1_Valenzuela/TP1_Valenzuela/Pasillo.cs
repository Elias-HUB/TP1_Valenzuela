using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1_Valenzuela
{
    public class Pasillo
    {
        private string Nombre;
        Medidas Med = new Medidas();
        Lado Lado1 = new Lado();
        Lado Lado2 = new Lado();
        Cliente ClientePropietario = new Cliente();
        public int PasGS { get; set; }
    }
}