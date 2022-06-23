using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int PremierYear { get; set; }

        public Director Director { get; set; }
    }
}
