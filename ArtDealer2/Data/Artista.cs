using System.ComponentModel.DataAnnotations;

namespace ArtDealer2.Data
{
    public class Artista
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo Nombre no puede tener más de 100 caracteres.")]
        public string? NombreArtista { get; set; }

        [Required(ErrorMessage = "El campo Correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        [StringLength(100, ErrorMessage = "El campo Correo no puede tener más de 100 caracteres.")]
        public string? CorreoArtista { get; set; }


        public ICollection<Obra>? Obras { get; set; }
    }
}
