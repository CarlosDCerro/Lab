using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class FacturaDetalle
    {
        private int _facNumero;
        private String _facProducto;
        private int _facCantidad;

        public FacturaDetalle(int facNumero, string facProducto, int facCantidad)
        {
            _facNumero = facNumero;
            _facProducto = facProducto;
            _facCantidad = facCantidad;
        }

        public int FacNumero { get => _facNumero; set => _facNumero = value; }
        public string FacProducto { get => _facProducto; set => _facProducto = value; }
        public int FacCantidad { get => _facCantidad; set => _facCantidad = value; }
    }
}
