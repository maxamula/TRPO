using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    [Table("values")]
    public partial class Value
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int pollutantId { get; set; }

        [Required]
        public int recordId { get; set; }

        [Column("value")]
        [Required]
        public float value1 { get; set; }

        public Pollutant Pollutant { get; set; }

        public Record Record { get; set; }

    }
}