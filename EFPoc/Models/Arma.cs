using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFPoc.Models
{
    public class Arma
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Hero> Heroes { get; set; }
        public int HeroId { get; set; }
    }
}
