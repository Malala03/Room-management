using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomManagement.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(5)]
        public required string RoomNumber { get; set; }

        [Required]
        public required string Type { get; set; } //simple, double et familiale

        [Required]
        public required decimal PricePerNight { get; set; }

        [Required]
        public bool Statut { get; set; } = true; //libre ou occupé

    }
}
