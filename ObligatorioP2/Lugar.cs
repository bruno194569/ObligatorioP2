using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioP2
{
    abstract class Lugar
    {
        #region atributos
        private int id;
        private string nombre;
        private decimal dimensiones;
        #endregion

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Dimensiones { get => dimensiones; set => dimensiones = value; }

        public Lugar(int id, string nombre, decimal dimensiones)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Dimensiones = dimensiones;
        }

        public override string ToString()
        {
            
            return $"ID : {id} \n" +
                $"Nombre : {nombre}\n" +
                $"Dimensiones : {dimensiones}\n";
            
        }


        public override bool Equals(object obj)
        {
            Lugar lugar = obj as Lugar;
            bool esIgual = false;
            if (this.GetHashCode() == lugar.GetHashCode())
            {
                esIgual = true;
            }
            return esIgual;
        }

        public override int GetHashCode() //identificador unico del objeto
        {
            return id;
        }




    }
}
