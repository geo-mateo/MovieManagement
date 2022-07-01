using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public class DirectorBiography
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime DoB { get; set; }

        [ForeignKey("Director")]
        public int? DirectorId { get; set; }
        public Director Director { get; set; }

        public string PlaceOfBirth { get; set; }
    }
}
