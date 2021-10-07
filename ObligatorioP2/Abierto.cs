using System;
using System.Collections.Generic;
using System.Text;



namespace ObligatorioP2
{
    class Abierto : Lugar
    {
        private static decimal precioXButaca = 40;
        public static decimal PrecioXButaca { get => precioXButaca; set => precioXButaca = value; }

        public Abierto(int id, string nombre, decimal dimensiones) : base (id, nombre, dimensiones)
        {
            
        }


        public override string ToString()
        {
            return base.ToString() + $"Precio por butaca: {precioXButaca}";
        }

        public static bool CambiarValorButaca(decimal precio) {

            precioXButaca = precio; //faltan validaciones
            return true;
        }

        
    }
}
