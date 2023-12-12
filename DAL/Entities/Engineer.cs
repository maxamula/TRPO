using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    [Table("engineers")]
    public partial class Engineer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Phone { get; set; }

        public byte[] Picture { get; set; }

        public ICollection<Record> Records { get; set; }

    }
}