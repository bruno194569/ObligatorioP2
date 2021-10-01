using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;



namespace ObligatorioP2
{
    class Abierto : Lugar
    {
        private decimal precioXButaca;

        public Abierto(int id, string nombre, decimal dimensiones, decimal precioXButaca) : base (id, nombre, dimensiones)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Dimensiones = dimensiones;
        }

    }
}
