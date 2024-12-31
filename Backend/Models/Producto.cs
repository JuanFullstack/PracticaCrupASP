using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Producto
    {
        // Identificador único del producto
        public int Id { get; set; }


        // Nombre del producto, con una longitud máxima de 50 caracteres
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string Nombre { get; set; } = null!;


        // Descripción del producto, con posibilidad de texto multilínea y una longitud máxima de 500 caracteres
        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        public string Descripcion { get; set; } = null!;


        // Precio del producto, almacenado como decimal con 18 dígitos en total y 2 decimales
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Precio { get; set; }
    }

}
