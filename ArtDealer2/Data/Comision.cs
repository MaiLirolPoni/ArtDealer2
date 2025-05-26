using System.ComponentModel.DataAnnotations;

namespace ArtDealer2.Data
{
    public class Comision
    {
        public int Id { get; set; }
        public int ObraId { get; set; }
        public int ArtistaId { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo Nombre no puede tener más de 100 caracteres.")]
        public string? NombreCliente { get; set; }
        public string? Comentarios { get; set; }

        virtual public Artista? Artista { get; set; }   
        virtual public Obra? Obra { get; set; }

    }
}
