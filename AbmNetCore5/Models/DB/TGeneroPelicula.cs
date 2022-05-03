﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AbmNetCore5.Models.DB
{
    public partial class TGeneroPelicula
    {
        public int CodPelicula { get; set; }
        public int CodGenero { get; set; }

        public virtual TGenero CodGeneroNavigation { get; set; }
        public virtual TPelicula CodPeliculaNavigation { get; set; }
    }
}
