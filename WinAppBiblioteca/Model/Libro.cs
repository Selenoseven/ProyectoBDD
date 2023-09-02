using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppBiblioteca.Model
{
    public class Libro
    {
        public string CodigoLibro { get; set; }
        public string NombreLibro { get; set; }
        public string FechaPublicacion { get; set; }
        public string Edicion { get; set; }
        public string NombreAutor { get; set; }
        public string ApellidoAutor { get; set; }
        public string Categoria { get; set; }
        public int Stock { get; set; }
        public int Disponibilidad { get; set; }

        public Libro() { }


        public Libro(string codigoLibro, string nombreLibro, string fechaPublicacion, string edicion,
        string nombreAutor, string apellidoAutor, string categoria, int stock, int disponibilidad)
        {
            CodigoLibro = codigoLibro;
            NombreLibro = nombreLibro;
            FechaPublicacion = fechaPublicacion;
            Edicion = edicion;
            NombreAutor = nombreAutor;
            ApellidoAutor = apellidoAutor;
            Categoria = categoria;
            Stock = stock;
            Disponibilidad = disponibilidad;
        }


    }

}
