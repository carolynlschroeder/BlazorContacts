using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shared
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [Column(TypeName = "char(2)")]
        public string State { get; set; }
        [MaxLength(10)]
        public string Zip { get; set; }
    }
}
