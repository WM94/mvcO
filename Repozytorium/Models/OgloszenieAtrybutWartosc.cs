using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Repozytorium.Models
{
    public class OgloszenieAtrybutWartosc
    {

        [Key]
        public int Id { set; get; }
        public int IdOgloszenia { set; get; }
        public int IdAtrybutu { set; get; }

        public int IdAtybutWartosc { set; get; }
    }
}