using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    [Table("pollutants")]
    public partial class Pollutant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public float GDK { get; set; }

        public ICollection<Value> Values { get; set; }

    }
}