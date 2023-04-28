using System;
using System.Collections.Generic;

#nullable disable

namespace CRUD03.Models
{
    public partial class DocumentType
    {
        public Guid Id { get; set; }
        public short TypeDocuments { get; set; }
        public string Nombre { get; set; }
        public short CodigoAddenda { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
