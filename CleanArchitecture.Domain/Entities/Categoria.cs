using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CleanArchitecture.Domain.Entities
{
    public class Categoria : EntidadBase
    {
        [Required, MaxLength(120)]
        public string Name { get; set; }

        public int? CategoriaPadreId { get; set; }
        public Categoria? CategoriaPadre { get; set; }

        // Inicializar la colección para evitar null reference exceptions
        public ICollection<Categoria> SubCategorias { get; set; } = new List<Categoria>();
    }
}