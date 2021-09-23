using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatraSport.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = " Bicicleta estática";
            producto1.Precio = 1000;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = " Cinta de Correr";
            producto2.Precio = 1500;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = " Bicicleta eliptica";
            producto3.Precio = 1800;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return listadeProductos;
        }
    }
}
