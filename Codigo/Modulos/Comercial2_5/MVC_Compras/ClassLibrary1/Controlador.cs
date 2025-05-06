using System;
using System.Collections.Generic;
using Capa_Modelo_Compras;

namespace Capa_Controlador_Compras
{
    public class ControladorCompras
    {
        private Sentencias _sentencias = new Sentencias();

        public List<string> ObtenerSucursales()
        {
            return _sentencias.ObtenerSucursales();
        }

        public List<string> ObtenerProductos()
        {
            return _sentencias.ObtenerProductos();
        }
    }
}
