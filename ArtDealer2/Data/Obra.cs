using System.ComponentModel.DataAnnotations;


namespace ArtDealer2.Data
{
    public class Obra
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Titulo es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo Titulo no puede tener más de 100 caracteres.")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "Debes asignarle una categoría a tu obra.")]
        public string? Categoria { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaPublicacion { get; set; }


        [Required(ErrorMessage = "Debes proporcionar la url de tu obra")]
        public string? Source { get; set; }


        [Required(ErrorMessage = "Debes asignar un precio a tu obra")]
        public int? Precio { get; set; }
        public int ArtistaId { get; set; }


        public ICollection<Comision>? Comisiones { get; set; }
        virtual public Artista? Artista { get; set; }

    }
}
