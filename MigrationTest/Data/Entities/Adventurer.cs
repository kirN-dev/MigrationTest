using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MigrationTest.Data.Entities
{
    public class Adventurer
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual List<Class> Classes { get; set; }
        public virtual Race Race { get; set; }
        public int HitPoints { get; set; }
    }
}
