using System;
using System.ComponentModel.DataAnnotations;

namespace EFPoc.Models
{
    public class IdentidadeSecreta
    {
        [Key]
        public int Id { get; set; }
        public string NomeReal { get; set; }
        public int HeroId { get; set; }
        public virtual Hero Hero { get; set; }

    }
}