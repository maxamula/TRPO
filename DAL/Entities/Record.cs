using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    [Table("records")]
    public partial class Record
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public int engeneerId { get; set; }

        [Required]
        public int appointmentId { get; set; }

        [Required]
        public string sensorCodename { get; set; }

        public Appointment Appointment { get; set; }

        public Engineer Engineer { get; set; }

        public Sensor Sensor { get; set; }

        public ICollection<Value> Values { get; set; }

    }
}