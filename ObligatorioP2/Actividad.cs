using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioP2
{
    class Actividad
    {
        private int id;
        private string nombre;
        private DateTime fechaYHora;
        private string edadMinima;
        private int meGusta;
        private Lugar lugar;
        private Categoria categoria;
        private static int ultimoID = 0;
        private static decimal precioBase = 200;

        public static decimal PrecioBase { get => precioBase; set => precioBase = value; }
        public string EdadMinima { get => edadMinima; set => edadMinima = value; }
        internal Categoria Categoria { get => categoria; set => categoria = value; }
        public DateTime FechaYHora { get => fechaYHora; set => fechaYHora = value; }

        public Actividad(string nombre, DateTime fechaYHora, string edadMinima, Lugar lugar, Categoria categoria)
        {
            this.id = ++ultimoID;
            this.nombre = nombre;
            this.FechaYHora = fechaYHora;
            this.EdadMinima = edadMinima;
            this.meGusta = 0;
            this.lugar = lugar;
            this.Categoria = categoria;
        }

        public override string ToString()
        {
            return $"Id: {this.id}\n" +
                $"Nombre: {this.nombre}\n" +
                $"Fecha: {this.FechaYHora}\n" +
                $"Edad Minima: {this.EdadMinima}\n" +
                $"Cantidad de Megusta: {this.meGusta}\n" +
                $"Lugar: {this.lugar.Nombre}\n" +
                $"Categoria: {this.Categoria.Nombre}";
        }

        public bool AsignarMeGusta(int cantidad)
        {
            
            bool MeGusto = false;
            if (cantidad >= 0)
            {
                MeGusto = true;
                this.meGusta = cantidad;
            }
            return MeGusto;

        }
    }
}
