using System;
using System.Collections.Generic;
using System.Text;

namespace PelisItic92Yen.Data
{
    public class Pelicula
    {
        public long Id { get; set; }

        public string Titulo { get; set; }

        public string Genero { get; set; }

        public string Director { get; set; }

        public string Anio { get; set; }
    }
}
