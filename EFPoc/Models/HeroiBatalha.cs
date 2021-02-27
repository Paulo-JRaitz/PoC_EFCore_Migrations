using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFPoc.Models
{
    public class HeroiBatalha
    {
        [Key]
        public int HeroId { get; set; }
        public Hero Hero { get; set; }
        public int BatalhaId { get; set; }
        public Batalha Batalha { get; set; }
        public List<HeroiBatalha> HeroisBatalhas { get; set; }
    }
}
