using System;
using System.Collections.Generic;
using System.Text;

namespace ObligatorioP2
{
    class Sistema
    {
        private List<Actividad> actividades;
        private List<Lugar> lugares;
        private List<Categoria> categorias;

        internal List<Actividad> Actividades { get => actividades; }
        internal List<Lugar> Lugares { get => lugares;  }
        internal List<Categoria> Categorias { get => categorias;  }

        public Sistema()
        {
            actividades = new List<Actividad>();
            lugares = new List<Lugar>();
            categorias = new List<Categoria>();
        }

        public void Precarga()
        {
            PrecargarLugares();
            PrecargarCategorias();
            PrecargarActividades();
        }

        public void PrecargarActividades()
        {

            Actividad unActividad = new Actividad("Concierto", new DateTime(2021, 11, 22, 21, 30, 0), "C18", lugares[0], categorias[0]);
            actividades.Add(unActividad);
            unActividad = new Actividad("Feria gastronomica", new DateTime(2021, 11, 21, 21, 30, 0), "P", lugares[1], categorias[1]);
            actividades.Add(unActividad);
            unActividad = new Actividad("Cacino", new DateTime(2021, 10, 2, 4, 30, 0), "C16", lugares[2], categorias[2]);
            actividades.Add(unActividad);
            unActividad = new Actividad("Feria navideña", new DateTime(2021, 9, 1, 20, 20, 0), "C13", lugares[3], categorias[3]);
            actividades.Add(unActividad);
            unActividad = new Actividad("Barbacoa con los vecinos", new DateTime(2022, 9, 13, 12, 30, 0), "P", lugares[4], categorias[4]);// yyyy mm dd, hh, mm, ss
            actividades.Add(unActividad);
            unActividad = new Actividad("Fiesta en la playa", new DateTime(2021, 11, 21, 21, 30, 0), "C13", lugares[5], categorias[1]);
            actividades.Add(unActividad);
            unActividad = new Actividad("Parcial?", new DateTime(2021, 10, 18, 19, 30, 0), "P", lugares[6], categorias[0]);
            actividades.Add(unActividad);
            unActividad = new Actividad("Clasico", new DateTime(2021, 10, 10, 10, 30, 0), "C13", lugares[7], categorias[0]);
            actividades.Add(unActividad);
            unActividad = new Actividad("Vacunación masiva", new DateTime(2023, 8, 20, 14, 30, 0), "P", lugares[8], categorias[2]);
            actividades.Add(unActividad);
            unActividad = new Actividad("Invasión a la Luna", new DateTime(2045, 1, 1, 0, 0, 0), "C18", lugares[9], categorias[4]);
            actividades.Add(unActividad);

        }
        public void PrecargarLugares()
        {
            Cerrado unCerrado = new Cerrado(1, "La casa grande", 124, true, 250);
            lugares.Add(unCerrado);
            unCerrado = new Cerrado(2, "Divertilandia", 60, false, 150);
            lugares.Add(unCerrado);
            unCerrado = new Cerrado(3, "Mundo Dinosaurio", 540, false, 760);
            lugares.Add(unCerrado);
            unCerrado = new Cerrado(4, "El Dorado", 250, true, 2400);
            lugares.Add(unCerrado);
            unCerrado = new Cerrado(5, "El Plateado", 250, true, 2399);
            lugares.Add(unCerrado);
            Abierto unAbierto = new Abierto(6, "La plaza", 400);
            lugares.Add(unAbierto);
            unAbierto = new Abierto(7, "La otra plaza", 450);
            lugares.Add(unAbierto);
            unAbierto = new Abierto(8, "La plazita", 200);
            lugares.Add(unAbierto);
            unAbierto = new Abierto(9, "La mega plaza", 850);
            lugares.Add(unAbierto);
            unAbierto = new Abierto(10, "La luna", 80);
            lugares.Add(unAbierto);


        }
        public void PrecargarCategorias()
        {
            Categoria unCategoria = new Categoria("Cine", "Aca la gente ve muchas peliculas.");
            categorias.Add(unCategoria);
            unCategoria = new Categoria("Teatro", "Obras de teatro de todo tipo.");
            categorias.Add(unCategoria);
            unCategoria = new Categoria("Baile", "Una local bailable");
            categorias.Add(unCategoria);
            unCategoria = new Categoria("Comida", "Un lugar para comer");
            categorias.Add(unCategoria);
            unCategoria = new Categoria("Otro", "No entra en ninguna categoria");
            categorias.Add(unCategoria);
        }

        private List<Actividad> ListarActividades()
        {
            List<Actividad> listaActividades = new List<Actividad>();
            foreach (Actividad unaActividad in actividades)
            {
                listaActividades.Add(unaActividad);
            }
            return listaActividades;
        }

        public List<Actividad> ListarPorCategoria(string categoria, DateTime primerFecha, DateTime segundaFecha)
        {
            List<Actividad> listaActividades = new List<Actividad>();
            foreach (Actividad unaActividad in actividades)
            {
                if (primerFecha < unaActividad.FechaYHora && unaActividad.FechaYHora < segundaFecha && unaActividad.Categoria.Nombre == categoria)
                {
                    listaActividades.Add(unaActividad);
                }
            }
            return listaActividades;
        }

        public List<Actividad> ListarActividadesP()
        {
            List<Actividad> listaActividades = new List<Actividad>();
            foreach (Actividad unaActividad in actividades)
            {
                if (unaActividad.EdadMinima == "P")
                {
                    listaActividades.Add(unaActividad);
                }
            }
            return listaActividades;
        }

    }
}
