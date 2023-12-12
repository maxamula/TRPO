using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    [Table("sensors")]
    public partial class Sensor
    {
        [Key]
        [Required]
        public string codename { get; set; }

        [Required]
        public float lat { get; set; }

        [Required]
        public float lng { get; set; }

        public ICollection<Record> Records { get; set; }

    }
}