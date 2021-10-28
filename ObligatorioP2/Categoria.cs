using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioP2
{
    class Categoria
    {
        private string nombre;
        private string descripcion;

        public Categoria(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return $"Nombre: {this.nombre}\nDescripcion: {this.descripcion}";
        }


        public override bool Equals(object obj)
        {
            Categoria unaCategoria = obj as Categoria;
            bool esValida = false;
            if (this.nombre == unaCategoria.nombre)
            {
                esValida = true;
            }
            return esValida;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
