using MigrationTest.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MigrationTest.Data.Entities
{
    public class Class
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public Dice DiceHits { get; set; }
        public virtual List<Adventurer> Adventurers { get; set; }
    }
}