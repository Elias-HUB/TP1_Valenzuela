using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP1_Valenzuela
{
    public class Producto
    {
        private string CodProducto;
        private string Nombre;
        Proveedor Pro = new Proveedor();
        Stock Sto = new Stock();
        public int ProGS { get; set; }
    }
}