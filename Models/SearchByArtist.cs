using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtSpace_Project.Models
{
    public class SearchByArtist
    {
        [Key]
        public string Name { get; set; }
    }
}
