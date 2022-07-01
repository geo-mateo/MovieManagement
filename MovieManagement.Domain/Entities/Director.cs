using MovieManagement.Domain.Common;
using MovieManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public class Director : AuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public PersonName DirectorName { get; set; }

        public ICollection<Movie> Movies { get; set; }

        public DirectorBiography DirectorBiography { get; set; }
    }
}
