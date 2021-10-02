using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioP2
{
    class Cerrado : Lugar
    {
        bool accesibilidad;
        decimal valorMantenimiento;
        static decimal porcentajeAforo;

        public bool Accesibilidad { get => accesibilidad; set => accesibilidad = value; }
        public decimal ValorMantenimiento { get => valorMantenimiento; set => valorMantenimiento = value; }
        public static decimal PorcentajeAforo { get => porcentajeAforo; set => porcentajeAforo = value; }

        public Cerrado(int id, string nombre, decimal dimensiones, bool accesibilidad, decimal valorMantenimiento) : base(id, nombre, dimensiones)
        {
            this.Accesibilidad = accesibilidad;
            this.ValorMantenimiento = valorMantenimiento;
        }

        public override string ToString()
        {
            return base.ToString() + $"Accesibilidad : {accesibilidad} \nValor de Mantenimiento : {valorMantenimiento}\nPorcentaje de Aforo : {porcentajeAforo} %";
        }

        public static bool CambiarPorcentajeAforo(decimal porcentaje)
        {
            porcentajeAforo = porcentaje;
            return true;
        }
        //TODO + CambiarPorcentajeAforo() : bool
    }
}
