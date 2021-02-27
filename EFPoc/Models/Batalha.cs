using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFPoc.Models
{
    public class Batalha
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInit { get; set; }
        public DateTime DtEnd { get; set; }
        public List<HeroiBatalha> HeroiBatalhas { get; set; }
    }
}
