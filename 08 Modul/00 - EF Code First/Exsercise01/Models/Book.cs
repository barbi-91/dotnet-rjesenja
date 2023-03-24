using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exsercise01.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        [Column(TypeName="nvarchar")]
        public string Title { get; set; }


        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Author { get; set; }


        [Required]
        [Column(TypeName = "date")]
        public DateTime PublicationDate { get; set; }


        [Required]
        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Genere { get; set; }


    }
}
