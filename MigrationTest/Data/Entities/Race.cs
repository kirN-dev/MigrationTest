using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MigrationTest.Data.Entities
{
    public class Race
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public virtual List<Adventurer> Adventurers { get; set; }
        [Required]
        public int Speed { get; set; }
    }
}