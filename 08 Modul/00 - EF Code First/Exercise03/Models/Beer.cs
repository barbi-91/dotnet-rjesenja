using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise03.Models
{
    public class Beer
    {
        //BeerStyle(BeerStyle)
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public decimal Pric { get; set; }

        //Foreign key
        public int BeerStyleId { get; set; }
        [ForeignKey(nameof(BeerStyleId))]
        public BeerStyle BeerStyle { get; set; }

    }
}
