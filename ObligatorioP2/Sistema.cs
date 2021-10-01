using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioP2
{
    class Sistema
    {
        private List<Actividad> actividades;
        private List<Lugar> lugares;
        private List<Usuario> usuarios;
        private List<Compra> compras;
        private List<Categoria> categorias;

        public Sistema()
        {
            actividades = new List<Actividad>();
            lugares = new List<Lugar>();
            usuarios = new List<Usuario>();
            compras = new List<Compra>();
            categorias = new List<Categoria>();
        }

        public void Precarga()
        {
            PrecargarActividades();
            PrecargarLugares();
            PrecargarCategorias();
        }

        public void PrecargarActividades()
        {

        }
        public void PrecargarLugares()
        {

        }
        public void PrecargarCategorias()
        {

        }

        private List<Actividad> ListarActividades()
        {
            return new List<Actividad>();
        }

        private List<Actividad> ListarPorCategoria(Categoria categoria, DateTime primerFecha, DateTime segundaFecha)
        {
            return new List<Actividad>();
        }

        private List<Actividad> ListarActividadesP()
        {
            return new List<Actividad>();
        }

    }
}
