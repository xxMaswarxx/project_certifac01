using System;
using System.Collections.Generic;

#nullable disable

namespace CRUD03.Models
{
    public partial class Addenda
    {
        public Guid IdAddenda { get; set; }
        public string NombreAddenda { get; set; }
        public string Xml { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Usuario { get; set; }
        public bool? Estado { get; set; }
    }
}
